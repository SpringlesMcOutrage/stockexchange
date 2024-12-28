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
    public partial class CreateOrder : Form
    {
        private int userId;
        private int selectedAssetId;
        private decimal assetBalance;
        private decimal usdtBalance;
        private decimal currentPrice;

        public CreateOrder(int id)
        {
            InitializeComponent();
            userId = id;
            LoadAssets();
            LoadBalances();
            InitializeComboBoxes();


        }
        private void InitializeComboBoxes()
        {
            comboBoxOrderType.Items.Add("Market");
            comboBoxOrderType.Items.Add("Limit");

            comboBoxTradeType.Items.Add("Buy");
            comboBoxTradeType.Items.Add("Sell");

            comboBoxAssetType.Items.Add("All");
            comboBoxAssetType.Items.Add("Stock");
            comboBoxAssetType.Items.Add("Crypto");
            comboBoxAssetType.Items.Add("Commodity");

            comboBoxAssetType.SelectedIndex = 0;
            comboBoxOrderType.SelectedIndex = 0;
            comboBoxTradeType.SelectedIndex = 0;
        }

        private void LoadAssets()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectedType = comboBoxAssetType.SelectedItem?.ToString() ?? "All";
                    string query;

                    if (selectedType == "All")
                    {
                        query = "SELECT asset_id, name, current_price, type FROM Assets WHERE name != 'USDT'";
                    }
                    else
                    {
                        query = "SELECT asset_id, name, current_price, type FROM Assets WHERE name != 'USDT' AND type = @AssetType";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (selectedType != "All")
                        {
                            command.Parameters.AddWithValue("@AssetType", selectedType);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridViewAssets.DataSource = dt;

                            dataGridViewAssets.Columns["name"].HeaderText = "Назва активу";
                            dataGridViewAssets.Columns["current_price"].HeaderText = "Поточна ціна";
                            dataGridViewAssets.Columns["type"].HeaderText = "Тип активу";

                            dataGridViewAssets.Columns["asset_id"].Visible = false;
                            dataGridViewAssets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження активів: {ex.Message}");
            }
        }





        private void LoadBalances()
        {
            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    SUM(CASE WHEN a.name = 'USDT' THEN p.quantity ELSE 0 END) AS usdt_balance,
                    SUM(CASE WHEN a.asset_id = @AssetId THEN p.quantity ELSE 0 END) AS asset_balance
                FROM Portfolios p
                JOIN Assets a ON p.asset_id = a.asset_id
                WHERE p.user_id = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@AssetId", selectedAssetId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usdtBalance = Convert.ToDecimal(reader["usdt_balance"] ?? 0);
                                assetBalance = Convert.ToDecimal(reader["asset_balance"] ?? 0);
                            }

                            labelUSDTBalance.Text = $"USDT Баланс: {usdtBalance}";
                            labelAssetBalance.Text = $"Баланс Активу: {assetBalance}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження балансу: {ex.Message}");
            }
        }


        private void dataGridViewAssets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAssets.Rows[e.RowIndex];
                selectedAssetId = Convert.ToInt32(row.Cells["asset_id"].Value);
                labelSelectedAsset.Text = $"Актив: {row.Cells["name"].Value}";
                currentPrice = Convert.ToDecimal(row.Cells["current_price"].Value);

                LoadBalances();
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            string orderType = comboBoxOrderType.SelectedItem?.ToString();
            string tradeType = comboBoxTradeType.SelectedItem?.ToString();

            if (orderType == "Limit" && string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Введіть ціну для Limit Order.");
                return;
            }

            decimal price = orderType == "Limit" ? Convert.ToDecimal(textBoxPrice.Text) : currentPrice;
            decimal quantity = Convert.ToDecimal(textBoxQuantity.Text);

            if (tradeType == "Buy" && usdtBalance < price * quantity)
            {
                MessageBox.Show("Недостатньо коштів для купівлі.");
                return;
            }

            if (tradeType == "Sell" && assetBalance < quantity)
            {
                MessageBox.Show("Недостатньо активів для продажу.");
                return;
            }

            string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (orderType == "Market" ||
                        (orderType == "Limit" && ((tradeType == "Buy" && price >= currentPrice) ||
                                                  (tradeType == "Sell" && price <= currentPrice))))
                    {
                        string tradeQuery = @"
                INSERT INTO Trades (user_id, asset_id, price, quantity, trade_type, trade_date)
                VALUES (@UserId, @AssetId, @Price, @Quantity, @TradeType, GETDATE())";

                        using (SqlCommand command = new SqlCommand(tradeQuery, connection))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@AssetId", selectedAssetId);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@TradeType", tradeType);

                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string orderQuery = @"
                INSERT INTO Orders (user_id, asset_id, price, quantity, order_type, status, trade_type, created_at)
                VALUES (@UserId, @AssetId, @Price, @Quantity, @OrderType, 'open', @TradeType, GETDATE())";

                        using (SqlCommand command = new SqlCommand(orderQuery, connection))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@AssetId", selectedAssetId);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@OrderType", orderType);
                            command.Parameters.AddWithValue("@TradeType", tradeType);

                            command.ExecuteNonQuery();
                        }
                    }

                    if (tradeType == "Buy")
                    {
                        string portfolioQuery = @"
                    IF EXISTS (SELECT 1 FROM Portfolios WHERE user_id = @UserId AND asset_id = @AssetId)
                    BEGIN
                        UPDATE Portfolios
                        SET quantity = quantity + @Quantity,
                            average_price = ((average_price * quantity) + (@Price * @Quantity)) / (quantity + @Quantity)
                        WHERE user_id = @UserId AND asset_id = @AssetId
                    END
                    ELSE
                    BEGIN
                        INSERT INTO Portfolios (user_id, asset_id, average_price, quantity)
                        VALUES (@UserId, @AssetId, @Price, @Quantity)
                    END";

                        using (SqlCommand command = new SqlCommand(portfolioQuery, connection))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@AssetId", selectedAssetId);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Quantity", quantity);

                            command.ExecuteNonQuery();
                        }

                        string updateUSDTQuery = @"
                    UPDATE Portfolios
                    SET quantity = quantity - @TotalPrice
                    WHERE user_id = @UserId AND asset_id = (SELECT asset_id FROM Assets WHERE name = 'USDT')";

                        using (SqlCommand command = new SqlCommand(updateUSDTQuery, connection))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@TotalPrice", price * quantity);

                            command.ExecuteNonQuery();
                        }
                    }
                    else if (tradeType == "Sell")
                    {
                        string portfolioQuery = @"
                    UPDATE Portfolios
                    SET quantity = quantity - @Quantity
                    WHERE user_id = @UserId AND asset_id = @AssetId";

                        using (SqlCommand command = new SqlCommand(portfolioQuery, connection))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@AssetId", selectedAssetId);
                            command.Parameters.AddWithValue("@Quantity", quantity);

                            command.ExecuteNonQuery();
                        }

                        string updateUSDTQuery = @"
                    UPDATE Portfolios
                    SET quantity = quantity + @TotalPrice
                    WHERE user_id = @UserId AND asset_id = (SELECT asset_id FROM Assets WHERE name = 'USDT')";

                        using (SqlCommand command = new SqlCommand(updateUSDTQuery, connection))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@TotalPrice", price * quantity);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Ордер створено успішно!");
                    LoadAssets();
                    LoadBalances();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка створення ордеру: {ex.Message}");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAssetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssets();
        }
    }
}
