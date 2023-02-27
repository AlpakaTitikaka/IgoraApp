using System;

namespace IgoraApp.Data.DataBase.Models
{
    internal class Client
    {
        public int Id { get; }
        public string FullName { get; }
        public string Birthday { get; }
        public string Passport { get; }
        public string Address { get; }
        public string Email { get; }
        public string Phone { get; }

        public Client(int clientId, string fullName, string birthday,
            string passport, string address, string email, string phone)
        {
            Id = clientId;
            FullName = fullName;
            Birthday = birthday;
            Passport = passport;
            Address = address;
            Email = email;
            Phone = phone;
        }
    }
}
