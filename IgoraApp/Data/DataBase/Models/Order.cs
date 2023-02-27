using System;
using System.Collections.Generic;
using System.Linq;

namespace IgoraApp.Data.DataBase.Models
{
    internal class Order
    {
        public int Id { get; }
        public int ClientId { get; }
        public int UserId { get; }
        public string Date { get; }
        public double Sum { get; }
        public User Staff { get; set; }
        public Client Client { get; set; }
        public List<Tuple<int, string, int, Int32>> Products = new List<Tuple<int, string, int, Int32>>();

    public Order(int id, string date, int cltid, int usrid, double sum)
        {
            Id = id;
            ClientId = cltid;
            UserId = usrid;
            Date = date;
            Sum = sum;
        }

        public void Find()
        {
            Staff = DataBase.GetDataBase().GetUsers().Single(user => user.Id == UserId);
            Client = DataBase.GetDataBase().GetClients().Single(client => client.Id == ClientId);
        }

        public void AddProducts(int id, string title, int leaseTime, int count) => Products.Add(new Tuple<int, string, int, int>(id, title, leaseTime, count));
    }
}
