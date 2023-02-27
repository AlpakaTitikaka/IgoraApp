using System;

namespace IgoraApp.Data.DataBase.Models
{
    internal class Product
    {
        public int Id {get;}
        public string Title { get; }
        public double Price { get; }
        public int Count { get; }

        public Product(int id, string title, double price, int count)
        {
            Id = id;
            Title = title;
            Price = price;
            Count = count;
        }
    }
}
