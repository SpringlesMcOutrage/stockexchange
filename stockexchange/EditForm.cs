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
namespace threetables
{
    public partial class EditForm : Form
    {
        private const string connectionString = "Server=localhost;Database=BLACK;Integrated Security=True;TrustServerCertificate=True;";
        private string tableName;
        private string[] columnNames;
        private object[] values;
        private Dictionary<string, ComboBox> comboBoxes = new Dictionary<string, ComboBox>();

        public EditForm(string tableName, string[] columnNames, object[] values)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.columnNames = columnNames;
            this.values = values;
            InitializeFields();
        }

        private void InitializeFields()
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                Label label = new Label
                {
                    Text = columnNames[i],
                    Top = 10 + (i * 40),
                    Left = 10
                };
                this.Controls.Add(label);

                if (columnNames[i] == "asset_id" || columnNames[i] == "exchange_id" || columnNames[i] == "user_id")
                {
                    ComboBox comboBox = new ComboBox
                    {
                        Name = "comboBox_" + columnNames[i],
                        Top = 10 + (i * 40),
                        Left = 120,
                        Width = 200,
                        DropDownStyle = ComboBoxStyle.DropDownList
                    };
                    LoadComboBoxData(comboBox, columnNames[i]);
                    this.Controls.Add(comboBox);
                    comboBoxes[columnNames[i]] = comboBox;
                }
                else
                {
                    TextBox textBox = new TextBox
                    {
                        Name = "textBox_" + columnNames[i],
                        Text = values[i]?.ToString(),
                        Top = 10 + (i * 40),
                        Left = 120,
                        Width = 200
                    };
                    this.Controls.Add(textBox);
                }
            }

            Button buttonSave = new Button
            {
                Text = "Зберегти",
                Top = 10 + (columnNames.Length * 40),
                Left = 10
            };
            buttonSave.Click += ButtonSave_Click;
            this.Controls.Add(buttonSave);

            Button buttonCancel = new Button
            {
                Text = "Відміна",
                Top = 10 + (columnNames.Length * 40),
                Left = 120
            };
            buttonCancel.Click += (sender, e) => this.Close();
            this.Controls.Add(buttonCancel);
        }

        private void LoadComboBoxData(ComboBox comboBox, string columnName)
        {
            string query = "";
            string displayColumn = "";

            switch (columnName)
            {
                case "asset_id":
                    query = "SELECT asset_id, name FROM Assets";
                    displayColumn = "name";
                    break;
                case "exchange_id":
                    query = "SELECT exchange_id, name FROM Exchanges";
                    displayColumn = "name";
                    break;
                case "user_id":
                    query = "SELECT user_id, name FROM Users";
                    displayColumn = "name";
                    break;
            }

            if (query != "")
            {
                try
                {
                    using (SqlConnection sqlconn = new SqlConnection(connectionString))
                    {
                        sqlconn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Dictionary<int, string> items = new Dictionary<int, string>();

                            while (reader.Read())
                            {
                                items.Add(reader.GetInt32(0), reader.GetString(1));
                            }

                            comboBox.DataSource = new BindingSource(items, null);
                            comboBox.DisplayMember = "Value";
                            comboBox.ValueMember = "Key";

                            if (values != null)
                            {
                                comboBox.SelectedValue = Convert.ToInt32(values[Array.IndexOf(columnNames, columnName)]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка завантаження {columnName}: {ex.Message}");
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    string updateQuery = GenerateUpdateQuery();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, sqlconn))
                    {
                        for (int i = 1; i < columnNames.Length; i++)
                        {
                            string columnName = columnNames[i];
                            if (comboBoxes.ContainsKey(columnName))
                            {
                                cmd.Parameters.AddWithValue("@" + columnName, comboBoxes[columnName].SelectedValue);
                            }
                            else
                            {
                                string controlName = "textBox_" + columnName;
                                TextBox textBox = (TextBox)this.Controls[controlName];
                                cmd.Parameters.AddWithValue("@" + columnName, textBox.Text);
                            }
                        }
                        cmd.Parameters.AddWithValue("@id", values[0]);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Дані оновлено!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні: " + ex.Message);
            }
        }

        private string GenerateUpdateQuery()
        {
            string primaryKey = columnNames[0];
            string setClause = "";

            for (int i = 1; i < columnNames.Length; i++)
            {
                setClause += columnNames[i] + " = @" + columnNames[i] + ",";
            }
            setClause = setClause.TrimEnd(',');

            return $"UPDATE {tableName} SET {setClause} WHERE {primaryKey} = @id";
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
        }
    }
}
