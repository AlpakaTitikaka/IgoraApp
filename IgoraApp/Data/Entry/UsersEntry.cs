using IgoraApp.Data.DataBase;
using IgoraApp.Data.Entry;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IgoraApp
{
    public partial class UsersEntry : Form
    {
        public UsersEntry(int rang)
        {
            InitializeComponent();
            UserRang = rang;
        }

        private int UserRang;
        private int Incorrect = 0;
        private int BlockTime = 180;

        private void AuthorizeClick(object sender, EventArgs e)
        {
            try 
            {
                Session.Start(DataBase.GetDataBase().GetUsers().Single
                    (user => user.Login.Equals(Login.Text) && user.Password.Equals(Password.Text)));
                Hide();
                Incorrect = 0;
                DataBase.GetDataBase().AddLog(Login.Text, 1);
            }
            catch 
            {
                Incorrect++;
                DataBase.GetDataBase().AddLog(Login.Text, 0);
                if (Incorrect == 2)
                {
                    Hide();
                    new CheckingForm().Show();
                }
                else
                    MessageBox.Show(
                        "Неверный логин или пароль", "Ошибка входа",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordVisibleCheckStateChanged(object sender, EventArgs e) 
            => Password.UseSystemPasswordChar = !PasswordVisible.Checked;

        private void BlockTimerTick(object sender, EventArgs e)
        {
            if (BlockTime == 0)
            {
                Authorize.Enabled = true;
                BlockTime = 180;
                Text = "Вход";
                BlockTimer.Enabled = false;
                BlockTimer.Stop();
            }
            else
            {
                BlockTime--;
                Text = $"До конца блокировки {BlockTime}";
            }
        }

        private void UsersEntryFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            DataBase.GetDataBase().CloseConnection();
        }

        private void UsersEntryShown(object sender, EventArgs e)
        {
            if (UserRang != 0)
            {
                BlockTimer.Enabled = true;
                BlockTimer.Start();
                Authorize.Enabled = false;
            }
        }
    }
}
