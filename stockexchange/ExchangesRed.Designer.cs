namespace stockexchange
{
    partial class ExchangesRed
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
            textBoxCountry = new TextBox();
            textBoxCurrency = new TextBox();
            textBoxName = new TextBox();
            textBoxFee = new TextBox();
            buttonSave = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(774, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(348, 101);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.PlaceholderText = "Введіть країну";
            textBoxCountry.Size = new Size(281, 23);
            textBoxCountry.TabIndex = 4;
            // 
            // textBoxCurrency
            // 
            textBoxCurrency.Location = new Point(348, 163);
            textBoxCurrency.Name = "textBoxCurrency";
            textBoxCurrency.PlaceholderText = "Введіть валюту";
            textBoxCurrency.Size = new Size(281, 23);
            textBoxCurrency.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(348, 226);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введіть імя";
            textBoxName.Size = new Size(281, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxFee
            // 
            textBoxFee.Location = new Point(348, 289);
            textBoxFee.Name = "textBoxFee";
            textBoxFee.PlaceholderText = "Введіть комісію";
            textBoxFee.Size = new Size(281, 23);
            textBoxFee.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(477, 368);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(124, 23);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Зберегти запис";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(241, 99);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 9;
            label1.Text = "Країна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(235, 163);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 10;
            label3.Text = "Валюта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(265, 226);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 11;
            label4.Text = "Імя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(236, 287);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 12;
            label5.Text = "Комісія";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(208, 368);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(136, 23);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Видалити запис";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDeleteExchange_Click;
            // 
            // ExchangesRed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFee);
            Controls.Add(textBoxName);
            Controls.Add(textBoxCurrency);
            Controls.Add(textBoxCountry);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExchangesRed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExchangesRed";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxCountry;
        private TextBox textBoxCurrency;
        private TextBox textBoxName;
        private TextBox textBoxFee;
        private Button buttonSave;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonDelete;
    }
}