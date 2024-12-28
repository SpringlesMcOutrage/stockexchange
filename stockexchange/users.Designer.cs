namespace stockexchange
{
    partial class users
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
            dataGridViewUsers = new DataGridView();
            buttonAddUser = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(776, -2);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(81, 85);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.Size = new Size(629, 297);
            dataGridViewUsers.TabIndex = 4;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(304, 404);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(180, 23);
            buttonAddUser.TabIndex = 5;
            buttonAddUser.Text = "Додати користувача";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(334, 41);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 6;
            label1.Text = "Користувачі";
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonAddUser);
            Controls.Add(dataGridViewUsers);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "users";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewUsers;
        private Button buttonAddUser;
        private Label label1;
    }
}