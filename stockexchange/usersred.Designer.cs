namespace stockexchange
{
    partial class usersred
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
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxRole = new ComboBox();
            buttonSave = new Button();
            Emao = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(777, -2);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 4;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(309, 87);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Введіть email";
            textBoxEmail.Size = new Size(302, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(309, 145);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введіть Імя";
            textBoxName.Size = new Size(302, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(309, 206);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Введіть пароль";
            textBoxPassword.Size = new Size(302, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(309, 274);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(302, 23);
            comboBoxRole.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(309, 357);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(116, 45);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Зберегти запис";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Emao
            // 
            Emao.AutoSize = true;
            Emao.Font = new Font("Segoe UI", 12F);
            Emao.Location = new Point(217, 85);
            Emao.Name = "Emao";
            Emao.Size = new Size(48, 21);
            Emao.TabIndex = 11;
            Emao.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(232, 147);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 12;
            label1.Text = "Імя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(202, 208);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 13;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(221, 272);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 14;
            label4.Text = "Роль";
            // 
            // usersred
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Emao);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "usersred";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usersred";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private ComboBox comboBoxRole;
        private Button buttonSave;
        private Label Emao;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}