using IgoraApp.Data.Entry;
using IgoraApp.Users.Functions;
using System;
using System.Windows.Forms;

namespace IgoraApp.Users
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void SessionTimerTick(object sender, EventArgs e)
        {
            if (Session.Time.Equals(600))
                Close();
            else
                SessionTime.Text = TimeGetter.GetTime();
        }

        private void AdminLoad(object sender, EventArgs e)
        {
            SessionTimer.Start();
            Post.Text = "Администратор";
            FullName.Text = Session.User.FullName;
            UserPhoto.Image = Session.User.Photo;
        }

        private void AdminFormClosing(object sender, FormClosingEventArgs e)
        {
            SessionTimer.Stop();
            Session.End();
        }

        private void UsersHistory_Click(object sender, EventArgs e) => new UsersLogs().Show();
    }
}
