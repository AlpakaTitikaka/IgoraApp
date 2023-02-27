using IgoraApp.Data.DataBase.Models;
using IgoraApp.Users;
using System.Windows.Forms;

namespace IgoraApp.Data.Entry
{
    internal class Session
    {
        private static Session session;
        public static User User;
        public static int Time;

        private Session(User user)
        {
            Time = 0;
            User = user;
        }

        public static void Start(User user) 
        {
            if (session == null)
                session = new Session(user);
            if (User.Photo == null)
                User.AddPhoto();
            GetForm(user.Rang).Show();
        }

        private static Form GetForm(int rang)
        {
            if (rang == 1)
                return new Admin();
            if (rang == 2)
                return new ShiftSupervisor();
            return new Vendor();
        }

        public static void End()
        {
            Time = 0;
            session = null;
            new UsersEntry(User.Rang).Show();
            User = null;
        }
    }
}
