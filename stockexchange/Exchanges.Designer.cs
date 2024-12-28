namespace stockexchange
{
    partial class Exchanges
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
            dataGridViewExchanges = new DataGridView();
            buttonAddExchange = new Button();
            dd = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExchanges).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(777, -2);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // dataGridViewExchanges
            // 
            dataGridViewExchanges.AllowUserToAddRows = false;
            dataGridViewExchanges.AllowUserToDeleteRows = false;
            dataGridViewExchanges.AllowUserToOrderColumns = true;
            dataGridViewExchanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExchanges.Location = new Point(110, 80);
            dataGridViewExchanges.Name = "dataGridViewExchanges";
            dataGridViewExchanges.ReadOnly = true;
            dataGridViewExchanges.Size = new Size(575, 303);
            dataGridViewExchanges.TabIndex = 3;
            dataGridViewExchanges.CellClick += dataGridViewExchanges_CellDoubleClick;
            // 
            // buttonAddExchange
            // 
            buttonAddExchange.Location = new Point(332, 400);
            buttonAddExchange.Name = "buttonAddExchange";
            buttonAddExchange.Size = new Size(144, 23);
            buttonAddExchange.TabIndex = 4;
            buttonAddExchange.Text = "Додати запис";
            buttonAddExchange.UseVisualStyleBackColor = true;
            buttonAddExchange.Click += buttonAddExchange_Click;
            // 
            // dd
            // 
            dd.AutoSize = true;
            dd.Font = new Font("Segoe UI", 16F);
            dd.Location = new Point(354, 34);
            dd.Name = "dd";
            dd.Size = new Size(89, 30);
            dd.TabIndex = 5;
            dd.Text = "Обміни";
            // 
            // Exchanges
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dd);
            Controls.Add(buttonAddExchange);
            Controls.Add(dataGridViewExchanges);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Exchanges";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exchanges";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExchanges).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewExchanges;
        private Button buttonAddExchange;
        private Label dd;
    }
}