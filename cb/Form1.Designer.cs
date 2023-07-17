namespace cb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetAnsw = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxInputName = new System.Windows.Forms.ComboBox();
            this.comboBoxOutputName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGetAnsw
            // 
            this.btnGetAnsw.Location = new System.Drawing.Point(149, 122);
            this.btnGetAnsw.Name = "btnGetAnsw";
            this.btnGetAnsw.Size = new System.Drawing.Size(114, 23);
            this.btnGetAnsw.TabIndex = 0;
            this.btnGetAnsw.Text = "Перевести";
            this.btnGetAnsw.UseVisualStyleBackColor = true;
            this.btnGetAnsw.Click += new System.EventHandler(this.btnGetAnsw_Click);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(54, 64);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 22);
            this.textBoxSum.TabIndex = 1;
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Location = new System.Drawing.Point(288, 122);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.ReadOnly = true;
            this.textBoxTotalSum.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotalSum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исходная валюта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Целевая валюта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Перевод";
            // 
            // comboBoxInputName
            // 
            this.comboBoxInputName.FormattingEnabled = true;
            this.comboBoxInputName.Location = new System.Drawing.Point(177, 64);
            this.comboBoxInputName.Name = "comboBoxInputName";
            this.comboBoxInputName.Size = new System.Drawing.Size(151, 24);
            this.comboBoxInputName.TabIndex = 7;
            // 
            // comboBoxOutputName
            // 
            this.comboBoxOutputName.FormattingEnabled = true;
            this.comboBoxOutputName.Location = new System.Drawing.Point(334, 64);
            this.comboBoxOutputName.Name = "comboBoxOutputName";
            this.comboBoxOutputName.Size = new System.Drawing.Size(151, 24);
            this.comboBoxOutputName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 167);
            this.Controls.Add(this.comboBoxOutputName);
            this.Controls.Add(this.comboBoxInputName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotalSum);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.btnGetAnsw);
            this.Name = "Form1";
            this.Text = "Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAnsw;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxInputName;
        private System.Windows.Forms.ComboBox comboBoxOutputName;
    }
}

