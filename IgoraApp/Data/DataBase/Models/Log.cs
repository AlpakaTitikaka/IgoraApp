namespace IgoraApp.Data.DataBase.Models
{
    internal class Log
    {
        public int Id { get; }
        public string Login { get; }
        public string AttemptTime { get; }
        public bool Authorized { get; }

        public Log(int id, string login, string attemptTime, bool authorized)
        {
            Id = id;
            Login = login;
            AttemptTime = attemptTime;
            Authorized = authorized;
        }
    }
}
