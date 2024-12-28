namespace stockexchange
{
    partial class assetsred
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
            textBoxName = new TextBox();
            textBoxSymbol = new TextBox();
            textBoxPrice = new TextBox();
            comboBoxType = new ComboBox();
            buttonSave = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(774, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 5;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(354, 62);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введіть імя";
            textBoxName.Size = new Size(258, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxSymbol
            // 
            textBoxSymbol.Location = new Point(354, 134);
            textBoxSymbol.Name = "textBoxSymbol";
            textBoxSymbol.PlaceholderText = "Введіть символ";
            textBoxSymbol.Size = new Size(258, 23);
            textBoxSymbol.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(354, 195);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Введіть ціну";
            textBoxPrice.Size = new Size(258, 23);
            textBoxPrice.TabIndex = 8;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(354, 261);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(258, 23);
            comboBoxType.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(307, 359);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(155, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Зберегти запис";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(264, 60);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 11;
            label1.Text = "Імя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(232, 136);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 12;
            label3.Text = "Символ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(254, 197);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 13;
            label4.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(264, 263);
            label5.Name = "label5";
            label5.Size = new Size(36, 21);
            label5.TabIndex = 14;
            label5.Text = "Тип";
            // 
            // assetsred
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxSymbol);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "assetsred";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "assetsred";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxSymbol;
        private TextBox textBoxPrice;
        private ComboBox comboBoxType;
        private Button buttonSave;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}