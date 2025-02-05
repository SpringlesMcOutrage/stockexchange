using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace stockexchange
{
    public partial class comments : Form
    {
        private int assetId;
        private TextBox commentTextBox;
        private Button addCommentButton;

        public comments(int assetId)
        {
            InitializeComponent();
            this.assetId = assetId;
            LoadComments();
            CreateCommentInput();
        }

        private void LoadComments()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT TOP 5 comment_text, created_at 
                        FROM Comments 
                        WHERE asset_id = @AssetId 
                        ORDER BY created_at DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssetId", assetId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int yPosition = 20;

                            while (reader.Read())
                            {
                                string commentText = reader["comment_text"].ToString();
                                string createdAt = Convert.ToDateTime(reader["created_at"]).ToString("yyyy-MM-dd HH:mm");

                                Label commentLabel = new Label
                                {
                                    Text = commentText,
                                    Font = new Font("Arial", 13, FontStyle.Regular),
                                    AutoSize = true,
                                    Location = new Point(10, yPosition),
                                    MaximumSize = new Size(380, 0),
                                };
                                this.Controls.Add(commentLabel);
                                yPosition += commentLabel.Height + 5;

                                Label dateLabel = new Label
                                {
                                    Text = createdAt,
                                    Font = new Font("Arial", 9, FontStyle.Italic),
                                    ForeColor = Color.Gray,
                                    AutoSize = true,
                                    Location = new Point(10, yPosition)
                                };
                                this.Controls.Add(dateLabel);
                                yPosition += dateLabel.Height + 15;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void CreateCommentInput()
        {
            commentTextBox = new TextBox
            {
                Location = new Point(10, 370),
                Width = 280,
                Height = 50,
                Multiline = true,
                Font = new Font("Arial", 12),
            };
            this.Controls.Add(commentTextBox);

            addCommentButton = new Button
            {
                Text = "Додати коментар",
                Location = new Point(300, 370),
                Width = 120,
                Height = 50,
                Font = new Font("Arial", 10),
                BackColor = Color.LightBlue
            };
            addCommentButton.Click += AddCommentButton_Click;
            this.Controls.Add(addCommentButton);
        }

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            string commentText = commentTextBox.Text.Trim();

            if (string.IsNullOrEmpty(commentText))
            {
                MessageBox.Show("Коментар не може бути порожнім!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Comments (asset_id, comment_text, created_at) VALUES (@AssetId, @CommentText, GETDATE())";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssetId", assetId);
                        command.Parameters.AddWithValue("@CommentText", commentText);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Коментар успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                commentTextBox.Text = "";
                this.Controls.Clear();
                this.Controls.Add(closebutton);
                LoadComments();
                CreateCommentInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні коментаря: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
