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
    public partial class portfolio : Form
    {
        private int userId;
        public portfolio(int id)
        {
            InitializeComponent();
            userId = id;
            LoadPortfolio();

        }
        private void LoadPortfolio()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT a.name AS asset_name, p.quantity, p.average_price
                        FROM Portfolios p
                        JOIN Assets a ON p.asset_id = a.asset_id
                        WHERE p.user_id = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridViewPortfolio.DataSource = dt;

                            dataGridViewPortfolio.Columns["asset_name"].HeaderText = "Назва активу";
                            dataGridViewPortfolio.Columns["quantity"].HeaderText = "Кількість";
                            dataGridViewPortfolio.Columns["average_price"].HeaderText = "Середня ціна";


                            dataGridViewPortfolio.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                            dataGridViewPortfolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        }
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
            this.Close();
        }
    }
}
