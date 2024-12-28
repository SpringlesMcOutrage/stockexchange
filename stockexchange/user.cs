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
    public partial class user : Form
    {
        private int userId;
        public user(int id)
        {
            InitializeComponent();
            userId = id;
            LoadUserName();
            LoadOrders();

        }
        private void LoadUserName()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT name FROM Users WHERE user_id = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string userName = result.ToString();
                            label1.Text = $"Привіт, {userName}!";
                        }
                        else
                        {
                            label1.Text = "Привіт, Користувач!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private void LoadOrders()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT TOP 10 
                    a.name AS Назва, 
                    a.symbol AS Символ, 
                    a.current_price AS ПоточнаЦіна
                FROM Assets a
                LEFT JOIN Orders o ON a.asset_id = o.asset_id AND o.created_at >= DATEADD(DAY, -1, GETDATE())
                LEFT JOIN Trades t ON a.asset_id = t.asset_id AND t.trade_date >= DATEADD(DAY, -1, GETDATE())
                GROUP BY a.asset_id, a.name, a.symbol, a.current_price
                ORDER BY ISNULL(SUM(o.quantity), 0) + ISNULL(SUM(t.quantity), 0) DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewOrders.DataSource = dt;

                        dataGridViewOrders.Columns["Назва"].HeaderText = "Назва активу";
                        dataGridViewOrders.Columns["Символ"].HeaderText = "Символ";
                        dataGridViewOrders.Columns["ПоточнаЦіна"].HeaderText = "Поточна ціна";

                        dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            portfolio portfolioForm = new portfolio(userId);
            portfolioForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateOrder createOrderForm = new CreateOrder(userId);
            createOrderForm.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            popovnenia popovnenia = new popovnenia(userId);
            popovnenia.Show();
        }
    }
}
