using IgoraApp.Data.DataBase;
using IgoraApp.Data.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IgoraApp.Users.Functions
{
    public partial class AcceptProduct : Form
    {
        public AcceptProduct()
        {
            InitializeComponent();
        }

        private List<Product> Products = DataBase.GetDataBase().GetProducts();

        private void GetProductButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (NewProduct.Checked)
                {
                    if (Convert.ToInt32(ProductId.Text) < 0)
                        throw new Exception("Код не может быть отрицательным");
                    DataBase.GetDataBase().AddProduct(Convert.ToInt32(ProductId.Text),
                        NewProductTitle.Text, Convert.ToDouble(Price.Text), Convert.ToInt32(ProductCount.Text));
                }
                else
                    DataBase.GetDataBase().AddProduct(Convert.ToInt32(ProductId.Text), Convert.ToInt32(ProductCount.Text));
                Close();
                MessageBox.Show("Товар обновлен", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ошибка добавления товара", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OutButtonClick(object sender, EventArgs e) => Close();

        private void NewProductCheckedChanged(object sender, EventArgs e)
        {
            Price.Visible = NewProduct.Checked;
            PriceTitle.Visible = NewProduct.Checked;
            ProductTitle.Visible = !NewProduct.Checked;
            NewProductTitle.Visible = NewProduct.Checked;
            ProductId.ReadOnly = NewProduct.Checked;
            ProductId.Text = NewProduct.Checked ? (Products.Count + 1).ToString() : "";
        }

        private void AcceptProductLoad(object sender, EventArgs e)
        {
            foreach(var product in Products)
                ProductTitle.Items.Add(product.Title);
        }

        private void ProductTitleSelectedIndexChanged(object sender, EventArgs e) 
            => ProductId.Text = Products[ProductTitle.SelectedIndex].Id.ToString();

        private void ProductCountTextChanged(object sender, EventArgs e)
            => ProductCount.Text = Format.NumberString(ProductCount.Text);

        private void NewProductTitleTextChanged(object sender, EventArgs e)
            => NewProductTitle.Text = Format.LetterString(NewProductTitle.Text);

        private void PriceTextChanged(object sender, EventArgs e)
            => Price.Text = Format.MoneyString(Price.Text);
    }
}
