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
    public partial class Exchanges : Form
    {
        public Exchanges()
        {
            InitializeComponent();
            LoadExchanges();

        }
        private void LoadExchanges()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT exchange_id, country, currency, name, trading_fee FROM Exchanges";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewExchanges.DataSource = dt;

                        dataGridViewExchanges.Columns["country"].HeaderText = "Країна";
                        dataGridViewExchanges.Columns["currency"].HeaderText = "Валюта";
                        dataGridViewExchanges.Columns["name"].HeaderText = "Назва біржі";
                        dataGridViewExchanges.Columns["trading_fee"].HeaderText = "Комісія за торгівлю";

                        dataGridViewExchanges.Columns["exchange_id"].Visible = false; 
                        dataGridViewExchanges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading exchanges: {ex.Message}");
            }
        }
        private void buttonAddExchange_Click(object sender, EventArgs e)
        {
            ExchangesRed form = new ExchangesRed(null);
            form.ShowDialog();
            LoadExchanges();
        }

        private void dataGridViewExchanges_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int exchangeId = Convert.ToInt32(dataGridViewExchanges.Rows[e.RowIndex].Cells["exchange_id"].Value);

                ExchangesRed form = new ExchangesRed(exchangeId);
                form.ShowDialog();
                LoadExchanges();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
