namespace stockexchange
{
    partial class comments
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
            closebutton = new Label();
            SuspendLayout();
            // 
            // closebutton
            // 
            closebutton.AutoSize = true;
            closebutton.Font = new Font("Segoe UI", 14F);
            closebutton.Location = new Point(776, -1);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(23, 25);
            closebutton.TabIndex = 0;
            closebutton.Text = "X";
            closebutton.Click += close_Click;
            // 
            // comments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closebutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "comments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "comments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closebutton;
    }
}