namespace IgoraApp.Users.Functions
{
    partial class AcceptProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewProductTitle = new System.Windows.Forms.TextBox();
            this.NewProduct = new System.Windows.Forms.CheckBox();
            this.ProductTitle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.PriceTitle = new System.Windows.Forms.Label();
            this.ProductCount = new System.Windows.Forms.TextBox();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutButton = new System.Windows.Forms.Button();
            this.GetProductButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewProductTitle);
            this.groupBox1.Controls.Add(this.NewProduct);
            this.groupBox1.Controls.Add(this.ProductTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.PriceTitle);
            this.groupBox1.Controls.Add(this.ProductCount);
            this.groupBox1.Controls.Add(this.ProductId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о товаре";
            // 
            // NewProductTitle
            // 
            this.NewProductTitle.Location = new System.Drawing.Point(13, 163);
            this.NewProductTitle.Name = "NewProductTitle";
            this.NewProductTitle.Size = new System.Drawing.Size(169, 23);
            this.NewProductTitle.TabIndex = 6;
            this.NewProductTitle.Visible = false;
            this.NewProductTitle.TextChanged += new System.EventHandler(this.NewProductTitleTextChanged);
            // 
            // NewProduct
            // 
            this.NewProduct.AutoSize = true;
            this.NewProduct.Location = new System.Drawing.Point(16, 40);
            this.NewProduct.Name = "NewProduct";
            this.NewProduct.Size = new System.Drawing.Size(170, 21);
            this.NewProduct.TabIndex = 4;
            this.NewProduct.Text = "Принять новый товар";
            this.NewProduct.UseVisualStyleBackColor = true;
            this.NewProduct.CheckedChanged += new System.EventHandler(this.NewProductCheckedChanged);
            // 
            // ProductTitle
            // 
            this.ProductTitle.FormattingEnabled = true;
            this.ProductTitle.Location = new System.Drawing.Point(13, 162);
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.Size = new System.Drawing.Size(169, 24);
            this.ProductTitle.TabIndex = 5;
            this.ProductTitle.SelectedIndexChanged += new System.EventHandler(this.ProductTitleSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наименование";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(16, 218);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 23);
            this.Price.TabIndex = 5;
            this.Price.Visible = false;
            this.Price.TextChanged += new System.EventHandler(this.PriceTextChanged);
            // 
            // PriceTitle
            // 
            this.PriceTitle.AutoSize = true;
            this.PriceTitle.Location = new System.Drawing.Point(13, 198);
            this.PriceTitle.Name = "PriceTitle";
            this.PriceTitle.Size = new System.Drawing.Size(43, 17);
            this.PriceTitle.TabIndex = 4;
            this.PriceTitle.Text = "Цена";
            this.PriceTitle.Visible = false;
            // 
            // ProductCount
            // 
            this.ProductCount.Location = new System.Drawing.Point(227, 134);
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Size = new System.Drawing.Size(95, 23);
            this.ProductCount.TabIndex = 3;
            this.ProductCount.TextChanged += new System.EventHandler(this.ProductCountTextChanged);
            // 
            // ProductId
            // 
            this.ProductId.Location = new System.Drawing.Point(13, 103);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(169, 23);
            this.ProductId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код товара";
            // 
            // OutButton
            // 
            this.OutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutButton.Location = new System.Drawing.Point(246, 292);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(116, 34);
            this.OutButton.TabIndex = 2;
            this.OutButton.Text = "Назад";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButtonClick);
            // 
            // GetProductButton
            // 
            this.GetProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetProductButton.Location = new System.Drawing.Point(12, 292);
            this.GetProductButton.Name = "GetProductButton";
            this.GetProductButton.Size = new System.Drawing.Size(116, 34);
            this.GetProductButton.TabIndex = 3;
            this.GetProductButton.Text = "Принять";
            this.GetProductButton.UseVisualStyleBackColor = true;
            this.GetProductButton.Click += new System.EventHandler(this.GetProductButtonClick);
            // 
            // AcceptProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 346);
            this.Controls.Add(this.GetProductButton);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AcceptProduct";
            this.Text = "Прием товара";
            this.Load += new System.EventHandler(this.AcceptProductLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ProductTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductCount;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label PriceTitle;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button GetProductButton;
        private System.Windows.Forms.CheckBox NewProduct;
        private System.Windows.Forms.TextBox NewProductTitle;
    }
}