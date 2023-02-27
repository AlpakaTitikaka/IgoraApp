using System;
using System.Windows.Forms;

namespace IgoraApp.Data.Entry
{
    public partial class CheckingForm : Form
    {
        public CheckingForm()
        {
            InitializeComponent();
        }

        private void CheckUserLoad(object sender, EventArgs e) => GenerateCaptcha();

        private Captcha Picture;
        private int Seconds = 11;

        private void GenerateCaptcha()
        {
            Picture = new Captcha(CaptchaPicture.Width, CaptchaPicture.Height);
            CaptchaPicture.Image = Picture.Get();
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            if (Picture.Check(Answer.Text))
                Close();
            else 
            {
                Enabled = false;
                IncorrectAuthorization.Enabled = true;
                IncorrectAuthorization.Start(); 
            }
        }

        private void IncorrectAuthorizationTick(object sender, EventArgs e)
        {
            if (Seconds == 0) 
            {
                Enabled = true;
                Seconds = 11;
                Text = "Проверка";
                GenerateCaptcha();
                IncorrectAuthorization.Stop();
                IncorrectAuthorization.Enabled = false;
            }
            else 
            {
                Seconds--;
                Text = "Повторите попытку через " + Seconds;
            }
        }

        private void CheckingFormFormClosing(object sender, FormClosingEventArgs e) => new UsersEntry(0).Show();
    }
}
