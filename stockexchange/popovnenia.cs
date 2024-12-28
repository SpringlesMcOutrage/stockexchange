using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace stockexchange
{
    public partial class popovnenia : Form
    {
        private int userId;

        public popovnenia(int id)
        {
            InitializeComponent();
            userId = id;
            LoadCurrencies();

        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text; 
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCurrencies()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT exchange_id, currency FROM Exchanges";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxCurrencies.Items.Add(new ComboBoxItem
                            {
                                Text = reader["currency"].ToString(),
                                Value = Convert.ToInt32(reader["exchange_id"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження валют: {ex.Message}");
            }
        }


        private void buttonConvertToUSDT_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            if (comboBoxCurrencies.SelectedItem == null || !decimal.TryParse(textBoxAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Оберіть валюту та введіть коректну суму.");
                return;
            }

            ComboBoxItem selectedCurrency = (ComboBoxItem)comboBoxCurrencies.SelectedItem;
            int exchangeId = selectedCurrency.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            ap.price AS usdt_price,
                            e.trading_fee AS fee
                        FROM AssetPrices ap
                        JOIN Exchanges e ON e.exchange_id = @ExchangeId
                        WHERE ap.asset_id = 5";

                    decimal usdtPrice = 0;
                    decimal tradingFee = 0;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExchangeId", exchangeId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usdtPrice = Convert.ToDecimal(reader["usdt_price"]);
                                tradingFee = Convert.ToDecimal(reader["fee"]);
                            }
                            else
                            {
                                MessageBox.Show("Не вдалося отримати дані про курс USDT.");
                                return;
                            }
                        }
                    }

                    decimal usdtAmount = (amount / usdtPrice) * (1 - tradingFee);

                    string updateQuery = @"
                        BEGIN TRANSACTION;
                        IF EXISTS (SELECT 1 FROM Portfolios WHERE user_id = @UserId AND asset_id = 5)
                        BEGIN
                            UPDATE Portfolios
                            SET quantity = quantity + @USDTAmount
                            WHERE user_id = @UserId AND asset_id = 5;
                        END
                        ELSE
                        BEGIN
                            INSERT INTO Portfolios (user_id, asset_id, average_price, quantity)
                            VALUES (@UserId, 5, 1, @USDTAmount);
                        END

                        COMMIT TRANSACTION;";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@USDTAmount", usdtAmount);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Поповнення успішне! Додано {usdtAmount:F2} USDT.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка поповнення: {ex.Message}");
            }
        }

    }
}
