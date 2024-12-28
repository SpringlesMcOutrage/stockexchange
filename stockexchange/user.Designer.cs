namespace stockexchange
{
    partial class user
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
            label1 = new Label();
            label2 = new Label();
            dataGridViewOrders = new DataGridView();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(42, 65);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 0;
            label1.Text = "Привіт, Користувач";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(774, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(335, 163);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.Size = new Size(431, 197);
            dataGridViewOrders.TabIndex = 2;
            dataGridViewOrders.CellContentClick += dataGridViewOrders_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(364, 118);
            label3.Name = "label3";
            label3.Size = new Size(363, 30);
            label3.TabIndex = 3;
            label3.Text = "Активи, які користуються попитом";
            // 
            // button1
            // 
            button1.Location = new Point(594, 390);
            button1.Name = "button1";
            button1.Size = new Size(172, 48);
            button1.TabIndex = 4;
            button1.Text = "Створити ордер";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(42, 243);
            label4.Name = "label4";
            label4.Size = new Size(207, 30);
            label4.TabIndex = 5;
            label4.Text = "Увійти в портфоліо";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(1, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 6;
            label5.Text = "Вийти з акаунту";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(325, 390);
            button2.Name = "button2";
            button2.Size = new Size(117, 48);
            button2.TabIndex = 7;
            button2.Text = "Поповнити баланс";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dataGridViewOrders);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "user";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewOrders;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}