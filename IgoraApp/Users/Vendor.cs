using IgoraApp.Data.Entry;
using IgoraApp.Users.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IgoraApp.Users
{
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
        }

        private void RegisterOrder(object sender, EventArgs e) => new CreateOrder().Show();

        private void SessionTimerTick(object sender, EventArgs e) 
        { 
            if (Session.Time.Equals(600))
                Close();
            else
                SessionTime.Text = TimeGetter.GetTime();
        }

        private void VendorFormClosing(object sender, FormClosingEventArgs e)
        {
            SessionTimer.Stop();
            Session.End();
        }

        private void VendorFormLoad(object sender, EventArgs e)
        {
            SessionTimer.Start();
            Post.Text = "Продавец";
            FullName.Text= Session.User.FullName;
            UserPhoto.Image = Session.User.Photo;
        }

        private void SeeAllOrdersClick(object sender, EventArgs e) => new AllOrders().Show();

        private void SeeAllClientsClick(object sender, EventArgs e) => new AllClients().Show();
    }
}
