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
using Microsoft.VisualBasic.ApplicationServices;


namespace stockexchange
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введіть email та пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT user_id, role 
                FROM Users 
                WHERE email = @Email AND password_hash = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string role = reader.GetString(1);

                                if (role == "admin")
                                {
                                    MessageBox.Show("Вітаємо, Адміністратор!", "Успішний вхід", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    OpenAdminPanel();
                                }
                                else if (role == "user")
                                {
                                    MessageBox.Show("Вітаємо, Користувач!", "Успішний вхід", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    OpenUserPanel(userId); 
                                }
                            }
                            else
                            {
                                MessageBox.Show("Невірний email або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OpenAdminPanel()
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }

        private void OpenUserPanel(int userId)
        {
            user userForm = new user(userId);
            userForm.Show();
            this.Hide();
        }


    }
}
