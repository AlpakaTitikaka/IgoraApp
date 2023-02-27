namespace IgoraApp.Users.Functions
{
    partial class AllOrders
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
            this.ProductsFromOrder = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllOrdersData = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsFromOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllOrdersData)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsFromOrder
            // 
            this.ProductsFromOrder.AllowUserToAddRows = false;
            this.ProductsFromOrder.AllowUserToDeleteRows = false;
            this.ProductsFromOrder.AllowUserToOrderColumns = true;
            this.ProductsFromOrder.AllowUserToResizeColumns = false;
            this.ProductsFromOrder.AllowUserToResizeRows = false;
            this.ProductsFromOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductsFromOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductsFromOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsFromOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Column1,
            this.Count});
            this.ProductsFromOrder.Location = new System.Drawing.Point(7, 23);
            this.ProductsFromOrder.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsFromOrder.MultiSelect = false;
            this.ProductsFromOrder.Name = "ProductsFromOrder";
            this.ProductsFromOrder.Size = new System.Drawing.Size(407, 321);
            this.ProductsFromOrder.TabIndex = 1;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Код товара";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 99;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Наименование";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 131;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время Аренды";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 119;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 111;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductsFromOrder);
            this.groupBox1.Location = new System.Drawing.Point(512, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 363);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товары";
            // 
            // AllOrdersData
            // 
            this.AllOrdersData.AllowUserToAddRows = false;
            this.AllOrdersData.AllowUserToDeleteRows = false;
            this.AllOrdersData.AllowUserToOrderColumns = true;
            this.AllOrdersData.AllowUserToResizeColumns = false;
            this.AllOrdersData.AllowUserToResizeRows = false;
            this.AllOrdersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllOrdersData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllOrdersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllOrdersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.Date,
            this.OrderSum,
            this.ClientName,
            this.StaffName});
            this.AllOrdersData.Location = new System.Drawing.Point(13, 13);
            this.AllOrdersData.Margin = new System.Windows.Forms.Padding(4);
            this.AllOrdersData.MultiSelect = false;
            this.AllOrdersData.Name = "AllOrdersData";
            this.AllOrdersData.Size = new System.Drawing.Size(492, 363);
            this.AllOrdersData.TabIndex = 4;
            this.AllOrdersData.Click += new System.EventHandler(this.AllOrdersDataClick);
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Код заказа";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 107;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 67;
            // 
            // OrderSum
            // 
            this.OrderSum.HeaderText = "Стоимость";
            this.OrderSum.Name = "OrderSum";
            this.OrderSum.ReadOnly = true;
            this.OrderSum.Width = 103;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Клиент";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Width = 81;
            // 
            // StaffName
            // 
            this.StaffName.HeaderText = "Сотрудник";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            this.StaffName.Width = 103;
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 392);
            this.Controls.Add(this.AllOrdersData);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllOrders";
            this.Text = "Все заказы";
            this.Load += new System.EventHandler(this.AllOrdersLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsFromOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllOrdersData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductsFromOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView AllOrdersData;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}