using System.Drawing;

namespace IgoraApp.Data.DataBase.Models
{
    internal class User
    {
        public int Id { get; }
        public string FullName { get; }
        public string Login { get; }
        public string Password { get; }
        public string Post { get; }
        public int Rang { get; }
        public Bitmap Photo { get; set; }

        public User(int id, string fullname, string login, string password, string post, int rang)
        {
            Id = id;
            FullName = fullname;
            Login = login;
            Password = password;
            Post = post;
            Rang = rang;
        }

        public void AddPhoto() => Photo = DataBase.GetDataBase().ImportUserPhotoById(Id);
    }
}
