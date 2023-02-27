using IgoraApp.Data.DataBase;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IgoraApp.Users.Functions
{
    public partial class AddClient : Form
    {
        private bool IsOrderForm;
        public AddClient(bool isorderform)
        {
            InitializeComponent();
            IsOrderForm = isorderform;
        }

        private void CancelButtonClick(object sender, EventArgs e) 
            => Close();

        private void AddClientLoad(object sender, EventArgs e) 
            => ClientId.Text = (DataBase.GetDataBase().GetClients().Count + 1).ToString();

        private void AddNewClientClick(object sender, EventArgs e)
        {
            try
            {
                DataBase.GetDataBase().AddClientData(Convert.ToInt32(ClientId.Text), ClientName.Text, 
                    Birthday.Value.ToShortDateString(), PassportSeria.Text, PassportNumber.Text, 
                    ClientAddress.Text, Email.Text, Phone.Text);
                MessageBox.Show("Клиент добавлен", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch 
            {
                MessageBox.Show("Неверный формат данных", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClientNameTextChanged(object sender, EventArgs e)
            => ClientName.Text = Format.LetterString(ClientName.Text);

        private void PassportSeriaTextChanged(object sender, EventArgs e)
            => PassportSeria.Text = Format.NumberString(PassportSeria.Text);

        private void PassportNumberTextChanged(object sender, EventArgs e)
            => PassportNumber.Text = Format.NumberString(PassportNumber.Text);

        private void AddClientFormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsOrderForm)
                new CreateOrder().Show();
        }
    }
}
