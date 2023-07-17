using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace cb
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> valueCurs = new Dictionary<string, decimal>();
        public Form1()
        {
            InitializeComponent();
            using (var client  = new ServiceReference1.DailyInfoSoapClient())
            {
                DateTime currentDate = DateTime.Today;

               var result = client.GetCursOnDate(currentDate);

                var valuteCursOnDateTable = result.Tables["ValuteCursOnDate"];


                if (valuteCursOnDateTable != null)
                {

                    foreach (DataRow row in valuteCursOnDateTable.Rows)
                    {

                        string vname = row["Vname"].ToString();
                        decimal vcurs = (decimal)row["Vcurs"];
                        valueCurs.Add(vname, vcurs);
                        comboBoxInputName.Items.Add(vname);
                        comboBoxOutputName.Items.Add(vname);
                    }
                }
            }
        }

        private void btnGetAnsw_Click(object sender, EventArgs e)
        {
            decimal sum;
            string input, output;
            if (!decimal.TryParse(textBoxSum.Text,out sum))
            {
                MessageBox.Show($"Не числовое значение суммы {sum}");
                return;
            }
            if (comboBoxInputName.SelectedItem is null)
            {
                MessageBox.Show($"Не выбрали исходную валюту!");
                return;
            }
            else input = comboBoxInputName.SelectedItem.ToString();
            if (comboBoxOutputName.SelectedItem is null)
            {
                MessageBox.Show($"Не выбрали целевую валюту!");
                return;
            }
            else output = comboBoxOutputName.SelectedItem.ToString();
            GetAnsw(sum, input, output);
        }
        private void GetAnsw(decimal sum, string input, string output)
        {
            decimal curs1 = valueCurs[input];
            decimal curs2 = valueCurs[output];
            decimal sumAnsw = sum * curs1 / curs2;
            textBoxTotalSum.Text = sumAnsw.ToString("F2");
        }
    }
}
