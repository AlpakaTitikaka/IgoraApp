namespace IgoraApp.Users.Functions
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SelectedItems = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsSum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTitle = new System.Windows.Forms.Label();
            this.ClientId = new System.Windows.Forms.ComboBox();
            this.ClientName = new System.Windows.Forms.ComboBox();
            this.ClientBirthday = new System.Windows.Forms.ComboBox();
            this.ClientPassport = new System.Windows.Forms.ComboBox();
            this.ClientAddress = new System.Windows.Forms.ComboBox();
            this.ClientEmail = new System.Windows.Forms.ComboBox();
            this.ClientPhone = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.AddOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllItems = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeeAllOrders = new System.Windows.Forms.Button();
            this.BarCode = new System.Windows.Forms.PictureBox();
            this.OrderTimeCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTimeCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SelectedItems);
            this.groupBox4.Location = new System.Drawing.Point(334, 431);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 275);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выбранные товары";
            // 
            // SelectedItems
            // 
            this.SelectedItems.AllowUserToAddRows = false;
            this.SelectedItems.AllowUserToOrderColumns = true;
            this.SelectedItems.AllowUserToResizeColumns = false;
            this.SelectedItems.AllowUserToResizeRows = false;
            this.SelectedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SelectedItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SelectedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Price,
            this.Count});
            this.SelectedItems.Location = new System.Drawing.Point(17, 32);
            this.SelectedItems.MultiSelect = false;
            this.SelectedItems.Name = "SelectedItems";
            this.SelectedItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SelectedItems.Size = new System.Drawing.Size(506, 226);
            this.SelectedItems.TabIndex = 0;
            this.SelectedItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedItemsCellValueChanged);
            this.SelectedItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SelectedItemsRowsAdded);
            this.SelectedItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.SelectedItemsRowsRemoved);
            this.SelectedItems.DoubleClick += new System.EventHandler(this.SelectedItemsDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Код товара";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 108;
            // 
            // Title
            // 
            this.Title.HeaderText = "Наименование";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 131;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 68;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.Width = 111;
            // 
            // ItemsSum
            // 
            this.ItemsSum.AutoSize = true;
            this.ItemsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsSum.Location = new System.Drawing.Point(178, 620);
            this.ItemsSum.Name = "ItemsSum";
            this.ItemsSum.Size = new System.Drawing.Size(19, 20);
            this.ItemsSum.TabIndex = 2;
            this.ItemsSum.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Стоимость заказа";
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(12, 128);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(169, 32);
            this.AddClientButton.TabIndex = 57;
            this.AddClientButton.Text = "Добавить покупателя";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IdTitle);
            this.groupBox2.Controls.Add(this.ClientId);
            this.groupBox2.Controls.Add(this.ClientName);
            this.groupBox2.Controls.Add(this.ClientBirthday);
            this.groupBox2.Controls.Add(this.ClientPassport);
            this.groupBox2.Controls.Add(this.ClientAddress);
            this.groupBox2.Controls.Add(this.ClientEmail);
            this.groupBox2.Controls.Add(this.ClientPhone);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 422);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о покупателе";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Паспорт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // IdTitle
            // 
            this.IdTitle.AutoSize = true;
            this.IdTitle.Location = new System.Drawing.Point(6, 29);
            this.IdTitle.Name = "IdTitle";
            this.IdTitle.Size = new System.Drawing.Size(114, 17);
            this.IdTitle.TabIndex = 0;
            this.IdTitle.Text = "Код покупателя";
            // 
            // ClientId
            // 
            this.ClientId.FormattingEnabled = true;
            this.ClientId.Location = new System.Drawing.Point(9, 49);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(270, 24);
            this.ClientId.TabIndex = 14;
            this.ClientId.SelectedIndexChanged += new System.EventHandler(this.ClientIdSelectedIndexChanged);
            // 
            // ClientName
            // 
            this.ClientName.FormattingEnabled = true;
            this.ClientName.Location = new System.Drawing.Point(9, 110);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(270, 24);
            this.ClientName.TabIndex = 15;
            this.ClientName.SelectedIndexChanged += new System.EventHandler(this.ClientNameSelectedIndexChanged);
            // 
            // ClientBirthday
            // 
            this.ClientBirthday.FormattingEnabled = true;
            this.ClientBirthday.Location = new System.Drawing.Point(9, 156);
            this.ClientBirthday.Name = "ClientBirthday";
            this.ClientBirthday.Size = new System.Drawing.Size(270, 24);
            this.ClientBirthday.TabIndex = 16;
            this.ClientBirthday.SelectedIndexChanged += new System.EventHandler(this.ClientBirthdaySelectedIndexChanged);
            // 
            // ClientPassport
            // 
            this.ClientPassport.FormattingEnabled = true;
            this.ClientPassport.Location = new System.Drawing.Point(9, 218);
            this.ClientPassport.Name = "ClientPassport";
            this.ClientPassport.Size = new System.Drawing.Size(270, 24);
            this.ClientPassport.TabIndex = 17;
            this.ClientPassport.SelectedIndexChanged += new System.EventHandler(this.ClientPassportSelectedIndexChanged);
            // 
            // ClientAddress
            // 
            this.ClientAddress.FormattingEnabled = true;
            this.ClientAddress.Location = new System.Drawing.Point(9, 265);
            this.ClientAddress.Name = "ClientAddress";
            this.ClientAddress.Size = new System.Drawing.Size(270, 24);
            this.ClientAddress.TabIndex = 18;
            this.ClientAddress.SelectedIndexChanged += new System.EventHandler(this.ClientAddressSelectedIndexChanged);
            // 
            // ClientEmail
            // 
            this.ClientEmail.FormattingEnabled = true;
            this.ClientEmail.Location = new System.Drawing.Point(9, 332);
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.Size = new System.Drawing.Size(270, 24);
            this.ClientEmail.TabIndex = 19;
            this.ClientEmail.SelectedIndexChanged += new System.EventHandler(this.ClientEmailSelectedIndexChanged);
            // 
            // ClientPhone
            // 
            this.ClientPhone.FormattingEnabled = true;
            this.ClientPhone.Location = new System.Drawing.Point(9, 378);
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(270, 24);
            this.ClientPhone.TabIndex = 20;
            this.ClientPhone.SelectedIndexChanged += new System.EventHandler(this.ClientPhoneSelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Заказ №";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Дата оформления";
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(81, 10);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(143, 23);
            this.OrderId.TabIndex = 0;
            this.OrderId.TextChanged += new System.EventHandler(this.OrderIdTextChanged);
            this.OrderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderIdKeyPress);
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(12, 669);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(169, 32);
            this.AddOrder.TabIndex = 59;
            this.AddOrder.Text = "Создать заказ";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrderClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllItems);
            this.groupBox1.Location = new System.Drawing.Point(334, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 278);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Все товары";
            // 
            // AllItems
            // 
            this.AllItems.AllowUserToAddRows = false;
            this.AllItems.AllowUserToDeleteRows = false;
            this.AllItems.AllowUserToResizeColumns = false;
            this.AllItems.AllowUserToResizeRows = false;
            this.AllItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AllItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductTitle,
            this.ProductPrice,
            this.ProductCount});
            this.AllItems.Location = new System.Drawing.Point(17, 30);
            this.AllItems.MultiSelect = false;
            this.AllItems.Name = "AllItems";
            this.AllItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AllItems.Size = new System.Drawing.Size(506, 224);
            this.AllItems.TabIndex = 43;
            this.AllItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllItems_CellContentClick);
            this.AllItems.DoubleClick += new System.EventHandler(this.AllItemsDoubleClick);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Код товара";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 108;
            // 
            // ProductTitle
            // 
            this.ProductTitle.HeaderText = "Наименование";
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.ReadOnly = true;
            this.ProductTitle.Width = 131;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Цена";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 68;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Склад";
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.ReadOnly = true;
            this.ProductCount.Width = 73;
            // 
            // SeeAllOrders
            // 
            this.SeeAllOrders.Location = new System.Drawing.Point(334, 10);
            this.SeeAllOrders.Name = "SeeAllOrders";
            this.SeeAllOrders.Size = new System.Drawing.Size(169, 32);
            this.SeeAllOrders.TabIndex = 44;
            this.SeeAllOrders.Text = "Все заказы >>";
            this.SeeAllOrders.UseVisualStyleBackColor = true;
            this.SeeAllOrders.Click += new System.EventHandler(this.SeeAllOrdersClick);
            // 
            // BarCode
            // 
            this.BarCode.Location = new System.Drawing.Point(525, 10);
            this.BarCode.Name = "BarCode";
            this.BarCode.Size = new System.Drawing.Size(349, 91);
            this.BarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BarCode.TabIndex = 61;
            this.BarCode.TabStop = false;
            // 
            // OrderTimeCount
            // 
            this.OrderTimeCount.Location = new System.Drawing.Point(414, 105);
            this.OrderTimeCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.OrderTimeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OrderTimeCount.Name = "OrderTimeCount";
            this.OrderTimeCount.Size = new System.Drawing.Size(48, 23);
            this.OrderTimeCount.TabIndex = 62;
            this.OrderTimeCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OrderTimeCount.ValueChanged += new System.EventHandler(this.OrderTimeCountValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "Аренда на";
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Location = new System.Drawing.Point(9, 67);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(54, 17);
            this.OrderDate.TabIndex = 64;
            this.OrderDate.Text = "label11";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 713);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OrderTimeCount);
            this.Controls.Add(this.BarCode);
            this.Controls.Add(this.SeeAllOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.ItemsSum);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateOrder";
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.CreateOrderLoad);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTimeCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ItemsSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdTitle;
        private System.Windows.Forms.ComboBox ClientId;
        private System.Windows.Forms.ComboBox ClientName;
        private System.Windows.Forms.ComboBox ClientPassport;
        private System.Windows.Forms.ComboBox ClientAddress;
        private System.Windows.Forms.ComboBox ClientEmail;
        private System.Windows.Forms.ComboBox ClientPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.ComboBox ClientBirthday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView AllItems;
        private System.Windows.Forms.DataGridView SelectedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.Button SeeAllOrders;
        private System.Windows.Forms.PictureBox BarCode;
        private System.Windows.Forms.NumericUpDown OrderTimeCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label OrderDate;
    }
}