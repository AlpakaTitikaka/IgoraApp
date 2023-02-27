using Aspose.BarCode.Generation;
using IgoraApp.Data.DataBase;
using IgoraApp.Data.DataBase.Models;
using IgoraApp.Data.Entry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IgoraApp.Users.Functions
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
            
        }

        private List<Client> Clients = DataBase.GetDataBase().GetClients();
        private BarcodeGenerator OrderBarcode;

        private void ClientIdSelectedIndexChanged(object sender, EventArgs e) => FillClientInfo(Clients[ClientId.SelectedIndex]);
        private void ClientNameSelectedIndexChanged(object sender, EventArgs e) => FillClientInfo(Clients[ClientName.SelectedIndex]);
        private void ClientBirthdaySelectedIndexChanged(object sender, EventArgs e) => FillClientInfo(Clients[ClientBirthday.SelectedIndex]);
        private void ClientPassportSelectedIndexChanged(object sender, EventArgs e) => FillClientInfo(Clients[ClientPassport.SelectedIndex]);
        private void ClientAddressSelectedIndexChanged(object sender, EventArgs e) => FillClientInfo(Clients[ClientAddress.SelectedIndex]);
        private void ClientEmailSelectedIndexChanged(object sender, EventArgs e) => FillClientInfo(Clients[ClientEmail.SelectedIndex]);
        private void ClientPhoneSelectedIndexChanged(object sender, EventArgs e) => FillClientInfo(Clients[ClientPhone.SelectedIndex]);

        private void FillClientInfo(Client client)
        {
            ClientId.Text = client.Id.ToString();
            ClientName.Text = client.FullName;
            ClientBirthday.Text = client.Birthday;
            ClientPassport.Text = client.Passport;
            ClientAddress.Text = client.Address;
            ClientEmail.Text = client.Email;
            ClientPhone.Text = client.Phone;
        }

        private void SuggestOrderId()
        {
            OrderId.ForeColor = Color.Gray;
            OrderId.Text = DataBase.GetDataBase().GetNewOrderId().ToString();
        }
        // бизнес логика
        private void GenerateBarCode()
        {
            string BarcodeString = $"{OrderId.Text}{string.Concat(DateTime.Now.ToShortDateString().Except("."))}" +
                $"{string.Concat(DateTime.Now.ToShortTimeString().Except(":"))}{OrderTimeCount.Value}";
            OrderBarcode = new BarcodeGenerator(EncodeTypes.Code39Standard, BarcodeString);
            BarCode.Image = OrderBarcode.GenerateBarCodeImage();
        }

        private void CreateOrderLoad(object sender, EventArgs e)
        {
            foreach (Product product in DataBase.GetDataBase().GetProducts())
                AllItems.Rows.Add(product.Id, product.Title, product.Price, product.Count);
            foreach (var client in Clients)
            {
                ClientId.Items.Add(client.Id);
                ClientName.Items.Add(client.FullName);
                ClientBirthday.Items.Add(client.Birthday);
                ClientPassport.Items.Add(client.Passport);
                ClientAddress.Items.Add(client.Address);
                ClientEmail.Items.Add(client.Email);
                ClientPhone.Items.Add(client.Phone);
            }
            OrderDate.Text = DateTime.Now.ToLongDateString();
            SuggestOrderId();
        }

        private void AddClientButtonClick(object sender, EventArgs e)
        {
            Close();
            new AddClient(true).Show();
        }

        private int GetEqualRow(DataGridViewRowCollection rows1, DataGridViewSelectedRowCollection selectedRows2)
        {
            for (int i = 0; i < rows1.Count; i++)
                if (rows1[i].Cells[0].Value.Equals(selectedRows2[0].Cells[0].Value))
                    return i;
            return -1;
        }

        private void AllItemsDoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (AllItems.SelectedRows[0].Cells[3].Value.ToString() == "0")
                    MessageBox.Show(
                        "Товара больше нет", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    if (GetEqualRow(SelectedItems.Rows, AllItems.SelectedRows) == -1)
                        SelectedItems.Rows.Add(
                            AllItems.SelectedRows[0].Cells[0].Value,
                            AllItems.SelectedRows[0].Cells[1].Value,
                            AllItems.SelectedRows[0].Cells[2].Value, "1");
                    else
                        SelectedItems.Rows[GetEqualRow(SelectedItems.Rows, AllItems.SelectedRows)].Cells[3].Value =
                            (Int32.Parse(SelectedItems.Rows[GetEqualRow(SelectedItems.Rows, AllItems.SelectedRows)].Cells[3].Value.ToString()) + 1).ToString();
                    AllItems.SelectedRows[0].Cells[3].Value = (Int32.Parse(AllItems.SelectedRows[0].Cells[3].Value.ToString()) - 1).ToString(); 
                }
            }
            catch { }
        }

        private void SelectedItemsDoubleClick(object sender, EventArgs e)
        {
            try 
            {
                string count = (string)SelectedItems.SelectedRows[0].Cells[3].Value;
                AllItems.Rows[GetEqualRow(AllItems.Rows, SelectedItems.SelectedRows)].Cells[3].Value =
                    (Int32.Parse(AllItems.Rows[GetEqualRow(AllItems.Rows, SelectedItems.SelectedRows)].
                    Cells[3].Value.ToString()) + 1).ToString();
                if (count == "1")
                    SelectedItems.Rows.Remove(SelectedItems.SelectedRows[0]);
                else
                    SelectedItems.SelectedRows[0].Cells[3].Value = (Int32.Parse(count) - 1).ToString();
            }
            catch { }
        }

        private void RefreshOrder()
        {
            double Sum = 0.0;
            foreach(DataGridViewRow row in SelectedItems.Rows)
                Sum += Convert.ToDouble(row.Cells[2].Value) * 
                    Convert.ToInt32(row.Cells[3].Value) * 
                    (int)OrderTimeCount.Value;
            ItemsSum.Text = Sum.ToString();
            OrderId.ForeColor = Color.Black;
            GenerateBarCode();
        }

        private void SaveBarCode(BarcodeGenerator barcode)
        {
            using (Stream ms = new MemoryStream())
            {
                barcode.Save(ms, BarCodeImageFormat.Bmp);
                Aspose.Pdf.Document doc = new Aspose.Pdf.Document();
                doc.Pages.Add();
                Aspose.Pdf.Facades.PdfFileMend mender = new Aspose.Pdf.Facades.PdfFileMend();
                mender.BindPdf(doc);
                mender.AddImage(ms, 1, 100, 600, 200, 700);
                mender.Save($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Barcodes")}\\{OrderId.Text}.pdf");
                mender.Dispose();
                ms.Dispose();
                ms.Close();
            }
        }

        private void SelectedItemsRowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => RefreshOrder();
        private void SelectedItemsRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => RefreshOrder();
        private void SelectedItemsCellValueChanged(object sender, DataGridViewCellEventArgs e) => RefreshOrder();

        private void AddOrderClick(object sender, EventArgs e)
        {
            if (!DataBase.GetDataBase().GetOrders().Any(order => order.Id.Equals(Convert.ToInt32(OrderId.Text))))
            {
                foreach (DataGridViewRow row in SelectedItems.Rows)
                    DataBase.GetDataBase().AddOrder(
                        Convert.ToInt32(OrderId.Text),
                        DateTime.Now.ToShortDateString(),
                        Convert.ToInt32(ClientId.Text),
                        Session.User.Id,
                        Convert.ToInt32(row.Cells[0].Value),
                        (int)OrderTimeCount.Value,
                        Convert.ToInt32(row.Cells[3].Value),
                        Convert.ToDouble(ItemsSum.Text));
                SaveBarCode(OrderBarcode);
                MessageBox.Show(
                    "Заказ был добавлен", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelectedItems.Rows.Clear();
                OrderTimeCount.Value = 1;
                SuggestOrderId();
            }
            else 
            {
                MessageBox.Show(
                    "Возможно данный заказ уже существует", "Ошибка добавления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeeAllOrdersClick(object sender, EventArgs e) => new AllOrders().Show();

        private void OrderIdKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                OrderId.ForeColor = Color.Black;
        }

        private void OrderIdTextChanged(object sender, EventArgs e)
        {
            if (OrderId.Text == "")
                SuggestOrderId();
            RefreshOrder();
            OrderId.Text = Format.NumberString(OrderId.Text);
        }

        private void OrderTimeCountValueChanged(object sender, EventArgs e) => RefreshOrder();

        private void AllItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
