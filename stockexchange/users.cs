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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            LoadUsers();

        }
        private void LoadUsers()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT user_id, email, name, role FROM Users";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewUsers.DataSource = dt;

                        dataGridViewUsers.Columns["email"].HeaderText = "Електронна пошта";
                        dataGridViewUsers.Columns["name"].HeaderText = "Ім'я";
                        dataGridViewUsers.Columns["role"].HeaderText = "Роль";



                        dataGridViewUsers.Columns["user_id"].Visible = false;
                        dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження користувачів: {ex.Message}");
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["user_id"].Value);
                usersred editForm = new usersred(userId);
                editForm.ShowDialog();
                LoadUsers();
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            usersred addForm = new usersred(null);
            addForm.ShowDialog();
            LoadUsers();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
