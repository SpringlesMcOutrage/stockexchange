namespace stockexchange
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            dataGridViewAssets = new DataGridView();
            labelUSDTBalance = new Label();
            labelAssetBalance = new Label();
            labelSelectedAsset = new Label();
            comboBoxOrderType = new ComboBox();
            comboBoxTradeType = new ComboBox();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            buttonCreateOrder = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxAssetType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssets).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(776, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // dataGridViewAssets
            // 
            dataGridViewAssets.AllowUserToAddRows = false;
            dataGridViewAssets.AllowUserToDeleteRows = false;
            dataGridViewAssets.AllowUserToOrderColumns = true;
            dataGridViewAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssets.Location = new Point(35, 53);
            dataGridViewAssets.Name = "dataGridViewAssets";
            dataGridViewAssets.ReadOnly = true;
            dataGridViewAssets.Size = new Size(292, 359);
            dataGridViewAssets.TabIndex = 3;
            dataGridViewAssets.CellClick += dataGridViewAssets_CellClick;
            // 
            // labelUSDTBalance
            // 
            labelUSDTBalance.AutoSize = true;
            labelUSDTBalance.Location = new Point(389, 101);
            labelUSDTBalance.Name = "labelUSDTBalance";
            labelUSDTBalance.Size = new Size(30, 15);
            labelUSDTBalance.TabIndex = 4;
            labelUSDTBalance.Text = "usdt";
            // 
            // labelAssetBalance
            // 
            labelAssetBalance.AutoSize = true;
            labelAssetBalance.Location = new Point(580, 101);
            labelAssetBalance.Name = "labelAssetBalance";
            labelAssetBalance.Size = new Size(82, 15);
            labelAssetBalance.TabIndex = 5;
            labelAssetBalance.Text = "assets balance";
            // 
            // labelSelectedAsset
            // 
            labelSelectedAsset.AutoSize = true;
            labelSelectedAsset.Font = new Font("Segoe UI", 14F);
            labelSelectedAsset.Location = new Point(34, 18);
            labelSelectedAsset.Name = "labelSelectedAsset";
            labelSelectedAsset.Size = new Size(157, 25);
            labelSelectedAsset.TabIndex = 6;
            labelSelectedAsset.Text = "Виберіть Валюту";
            // 
            // comboBoxOrderType
            // 
            comboBoxOrderType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderType.FormattingEnabled = true;
            comboBoxOrderType.Location = new Point(488, 155);
            comboBoxOrderType.Name = "comboBoxOrderType";
            comboBoxOrderType.Size = new Size(210, 23);
            comboBoxOrderType.TabIndex = 7;
            // 
            // comboBoxTradeType
            // 
            comboBoxTradeType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTradeType.FormattingEnabled = true;
            comboBoxTradeType.Location = new Point(488, 221);
            comboBoxTradeType.Name = "comboBoxTradeType";
            comboBoxTradeType.Size = new Size(210, 23);
            comboBoxTradeType.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(488, 278);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Введіть ціну";
            textBoxPrice.Size = new Size(210, 23);
            textBoxPrice.TabIndex = 9;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(488, 344);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.PlaceholderText = "Введіть кількість";
            textBoxQuantity.Size = new Size(210, 23);
            textBoxQuantity.TabIndex = 10;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(456, 393);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(111, 31);
            buttonCreateOrder.TabIndex = 11;
            buttonCreateOrder.Text = "Створити ордер";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 66);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 12;
            label1.Text = "Баланси";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 155);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 13;
            label3.Text = "Тип ордеру";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 224);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 14;
            label4.Text = "Купівля/Продаж";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 281);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 15;
            label5.Text = "Ціна за одиницю";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 347);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 16;
            label6.Text = "Кількість";
            // 
            // comboBoxAssetType
            // 
            comboBoxAssetType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAssetType.FormattingEnabled = true;
            comboBoxAssetType.Location = new Point(206, 18);
            comboBoxAssetType.Name = "comboBoxAssetType";
            comboBoxAssetType.Size = new Size(121, 23);
            comboBoxAssetType.TabIndex = 17;
            comboBoxAssetType.SelectedIndexChanged += comboBoxAssetType_SelectedIndexChanged;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxAssetType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonCreateOrder);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(comboBoxTradeType);
            Controls.Add(comboBoxOrderType);
            Controls.Add(labelSelectedAsset);
            Controls.Add(labelAssetBalance);
            Controls.Add(labelUSDTBalance);
            Controls.Add(dataGridViewAssets);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateOrder";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewAssets;
        private Label labelUSDTBalance;
        private Label labelAssetBalance;
        private Label labelSelectedAsset;
        private ComboBox comboBoxOrderType;
        private ComboBox comboBoxTradeType;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private Button buttonCreateOrder;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxAssetType;
    }
}