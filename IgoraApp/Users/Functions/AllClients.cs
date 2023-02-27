using IgoraApp.Data.DataBase;
using System;
using System.Windows.Forms;

namespace IgoraApp.Users.Functions
{
    public partial class AllClients : Form
    {
        public AllClients()
        {
            InitializeComponent();
        }

        private void AllClientsLoad(object sender, EventArgs e)
        {
            foreach (var client in DataBase.GetDataBase().GetClients())
                AllClientsData.Rows.Add
                    (client.Id, client.FullName, client.Phone, client.Email, client.Passport, client.Address, client.Birthday);
        }

        private void AddingClientClick(object sender, EventArgs e) => new AddClient(false).Show();
    }
}
