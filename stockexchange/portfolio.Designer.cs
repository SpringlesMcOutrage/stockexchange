namespace stockexchange
{
    partial class portfolio
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
            dataGridViewPortfolio = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPortfolio).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(776, -1);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // dataGridViewPortfolio
            // 
            dataGridViewPortfolio.AllowUserToAddRows = false;
            dataGridViewPortfolio.AllowUserToDeleteRows = false;
            dataGridViewPortfolio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPortfolio.Location = new Point(105, 94);
            dataGridViewPortfolio.Name = "dataGridViewPortfolio";
            dataGridViewPortfolio.ReadOnly = true;
            dataGridViewPortfolio.Size = new Size(583, 266);
            dataGridViewPortfolio.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(300, 49);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 4;
            label1.Text = "Моє портфоліо";
            // 
            // portfolio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewPortfolio);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "portfolio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "portfolio";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPortfolio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewPortfolio;
        private Label label1;
    }
}