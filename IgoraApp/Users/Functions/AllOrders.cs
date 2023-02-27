using IgoraApp.Data.DataBase;
using IgoraApp.Data.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IgoraApp.Users.Functions
{
    public partial class AllOrders : Form
    {
        public AllOrders()
        {
            InitializeComponent();
        }

        private List<Order> Orders = DataBase.GetDataBase().GetOrders();

        private void AllOrdersLoad(object sender, EventArgs e)
        {
            foreach (Order order in Orders) 
            {
                order.Find();
                AllOrdersData.Rows.Add(order.Id, order.Date, order.Sum, order.Client.FullName, order.Staff.FullName);
            }
        }

        private void AllOrdersDataClick(object sender, EventArgs e)
        {
            try
            {
                ProductsFromOrder.Rows.Clear();
                foreach (var product in DataBase.GetDataBase().GetProductsForOrder(Orders[AllOrdersData.SelectedRows[0].Index]).Products)
                    ProductsFromOrder.Rows.Add(product.Item1, product.Item2, product.Item3, product.Item4);
            }
            catch { }
        }
    }
}
