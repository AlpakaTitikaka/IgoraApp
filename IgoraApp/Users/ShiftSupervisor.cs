using IgoraApp.Data.Entry;
using IgoraApp.Users.Functions;
using System;
using System.Windows.Forms;

namespace IgoraApp.Users
{
    public partial class ShiftSupervisor : Form
    {
        public ShiftSupervisor()
        {
            InitializeComponent();
        }


        private void ShiftSupervisorFormClosing(object sender, FormClosingEventArgs e)
        {
            SessionTimer.Stop();
            Session.End();
        }

        private void CreateOrderClick(object sender, EventArgs e) => new CreateOrder().Show();
        private void GetProductsClick(object sender, EventArgs e) => new AcceptProduct().Show();

        private void ShiftSupervisorFormLoad(object sender, EventArgs e)
        {
            SessionTimer.Start();
            FullName.Text = Session.User.FullName;
            UserPhoto.Image = Session.User.Photo;
            Post.Text = "Старший смены";
        }

        private void SessionTimerTick(object sender, EventArgs e)
        {
            if (Session.Time.Equals(600))
                Close();
            else
                SessionTime.Text = TimeGetter.GetTime();
        }

        private void SeeAllOrdersClick(object sender, EventArgs e) => new AllOrders().Show();

        private void SeeAllClientsClick(object sender, EventArgs e) => new AllClients().Show();
    }
}
