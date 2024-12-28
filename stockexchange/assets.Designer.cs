namespace stockexchange
{
    partial class assets
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
            dataGridViewAssets = new DataGridView();
            buttonAddAsset = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssets).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(775, -1);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 4;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // dataGridViewAssets
            // 
            dataGridViewAssets.AllowUserToAddRows = false;
            dataGridViewAssets.AllowUserToDeleteRows = false;
            dataGridViewAssets.AllowUserToOrderColumns = true;
            dataGridViewAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssets.Location = new Point(98, 97);
            dataGridViewAssets.Name = "dataGridViewAssets";
            dataGridViewAssets.ReadOnly = true;
            dataGridViewAssets.Size = new Size(617, 269);
            dataGridViewAssets.TabIndex = 5;
            dataGridViewAssets.CellClick += dataGridViewAssets_CellDoubleClick;
            // 
            // buttonAddAsset
            // 
            buttonAddAsset.Location = new Point(337, 388);
            buttonAddAsset.Name = "buttonAddAsset";
            buttonAddAsset.Size = new Size(139, 23);
            buttonAddAsset.TabIndex = 6;
            buttonAddAsset.Text = "Додати запис";
            buttonAddAsset.UseVisualStyleBackColor = true;
            buttonAddAsset.Click += buttonAddAsset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(365, 48);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 7;
            label1.Text = "Активи";
            // 
            // assets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonAddAsset);
            Controls.Add(dataGridViewAssets);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "assets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "assets";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewAssets;
        private Button buttonAddAsset;
        private Label label1;
    }
}