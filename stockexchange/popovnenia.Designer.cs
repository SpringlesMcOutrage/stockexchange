namespace stockexchange
{
    partial class popovnenia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            comboBoxCurrencies = new ComboBox();
            textBoxAmount = new TextBox();
            buttonConvertToUSDT = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(774, -2);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // comboBoxCurrencies
            // 
            comboBoxCurrencies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrencies.FormattingEnabled = true;
            comboBoxCurrencies.Location = new Point(340, 114);
            comboBoxCurrencies.Name = "comboBoxCurrencies";
            comboBoxCurrencies.Size = new Size(310, 23);
            comboBoxCurrencies.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(340, 205);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.PlaceholderText = "Введіть кількість ";
            textBoxAmount.Size = new Size(310, 23);
            textBoxAmount.TabIndex = 4;
            // 
            // buttonConvertToUSDT
            // 
            buttonConvertToUSDT.Location = new Point(317, 309);
            buttonConvertToUSDT.Name = "buttonConvertToUSDT";
            buttonConvertToUSDT.Size = new Size(132, 60);
            buttonConvertToUSDT.TabIndex = 5;
            buttonConvertToUSDT.Text = "Додати кошти";
            buttonConvertToUSDT.UseVisualStyleBackColor = true;
            buttonConvertToUSDT.Click += buttonConvertToUSDT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(213, 112);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 6;
            label1.Text = "Валюти";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(213, 207);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 7;
            label3.Text = "Кількість";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(297, 37);
            label4.Name = "label4";
            label4.Size = new Size(201, 30);
            label4.TabIndex = 8;
            label4.Text = "Поповнення USDT";
            // 
            // popovnenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonConvertToUSDT);
            Controls.Add(textBoxAmount);
            Controls.Add(comboBoxCurrencies);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "popovnenia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "popovnenia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBoxCurrencies;
        private TextBox textBoxAmount;
        private Button buttonConvertToUSDT;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}