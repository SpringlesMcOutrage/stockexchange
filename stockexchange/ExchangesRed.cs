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
    public partial class ExchangesRed : Form
    {
        private int? exchangeId;

        public ExchangesRed(int? exchangeId = null)
        {
            InitializeComponent();
            this.exchangeId = exchangeId;

            if (exchangeId.HasValue)
            {
                LoadExchangeDetails(exchangeId.Value);
            }
        }
        private void LoadExchangeDetails(int exchangeId)
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT exchange_id, country, currency, name, trading_fee FROM Exchanges WHERE exchange_id = @exchangeId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@exchangeId", exchangeId);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            textBoxCountry.Text = reader["country"].ToString();
                            textBoxCurrency.Text = reader["currency"].ToString();
                            textBoxName.Text = reader["name"].ToString();
                            textBoxFee.Text = reader["trading_fee"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading exchange details: {ex.Message}");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string country = textBoxCountry.Text;
            string currency = textBoxCurrency.Text;
            string name = textBoxName.Text;
            if (!decimal.TryParse(textBoxFee.Text, out decimal tradingFee))
            {
                MessageBox.Show("Enter a valid trading fee.");
                return;
            }

            if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(currency) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (exchangeId.HasValue)
                    {
                        string updateQuery = @"
                            UPDATE Exchanges
                            SET country = @Country, currency = @Currency, name = @Name, trading_fee = @TradingFee
                            WHERE exchange_id = @ExchangeId";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Country", country);
                            command.Parameters.AddWithValue("@Currency", currency);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@TradingFee", tradingFee);
                            command.Parameters.AddWithValue("@ExchangeId", exchangeId.Value);

                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = @"
                            INSERT INTO Exchanges (country, currency, name, trading_fee)
                            VALUES (@Country, @Currency, @Name, @TradingFee)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Country", country);
                            command.Parameters.AddWithValue("@Currency", currency);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@TradingFee", tradingFee);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Exchange saved successfully.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving exchange: {ex.Message}");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
