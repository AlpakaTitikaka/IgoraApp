using IgoraApp.Data.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;

namespace IgoraApp.Data.DataBase
{
    internal class DataBase
    {
        private static DataBase db;
        private static SqlConnection connection;

        private DataBase()
        {
            connection = new SqlConnection($"server=localhost;attachdbfilename={Directory.GetCurrentDirectory()}\\database\\igora.mdf;trusted_connection=true");
            connection.Open();
        }

        public static DataBase GetDataBase()
        {
            if (db == null)
                db = new DataBase();
            return db;
        }

        public void CloseConnection() => connection.Close();

        private static string ConvertToSqlDate(string date) => string.Concat(date.Split('.').Reverse());

        public void AddClientData(int id, string fullName, string birthday, string passSeria, string passNumber, string address, string email, string phone) =>
            new SqlCommand($"insert into client values ({id}, '{fullName}', '{ConvertToSqlDate(birthday)}', '{passSeria}', " +
            $"'{passNumber}', '{address}' ,'{email}' ,'{phone}')", connection).ExecuteNonQuery();

        public void AddLog(string login, int authorized)
            => new SqlCommand($"insert into authorisation values ('{login}', getdate(), {authorized})", connection).ExecuteNonQuery();

        public void AddProduct(int id, string title, double price, int count)
            => new SqlCommand($"insert into product values ({id}, '{title}', {price}, {count})", connection).ExecuteNonQuery();

        public void AddProduct(int id, int count)
            => new SqlCommand($"update product set prod_count = prod_count + {count} where product_id={id}", connection).ExecuteNonQuery();

        public void AddOrder(int id, string date, int clientId, int staffId, int productId, int leaseTime, int productCount, double orderSum)
        {
            new SqlCommand($"insert into orders values ({id}, '{ConvertToSqlDate(date)}', " +
                $"{clientId}, {staffId}, {productId}, {leaseTime}, {productCount}, {orderSum})", connection).ExecuteNonQuery();
            ChangeProductCount(id, productCount);
        }

        private void ChangeProductCount(int id, int extractedCount)
            => new SqlCommand($"update product set prod_count=prod_count-{extractedCount} where product_id={id}", connection).ExecuteNonQuery();

        public Bitmap ImportUserPhotoById(int id)
        {
            string fileName = @"Local\";
            SqlDataReader reader = new SqlCommand($"select filepath, photo_data from photos where staff_id={id}", connection).ExecuteReader();
            while (reader.Read())
            {
                fileName += reader.GetString(0);
                byte[] data = (byte[])reader.GetValue(1);
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    fs.Write(data, 0, data.Length);
                    fs.Dispose();
                }
            }
            reader.Close();
            return new Bitmap(fileName);
        }

        public Order GetProductsForOrder(Order order)
        {
            if (order.Products.Count == 0)
            {
                SqlDataReader reader = new SqlCommand($"select orders.product_id, product.title, product_count, lease_time from orders,product where order_id={order.Id} and orders.product_id=product.product_id", connection).ExecuteReader();
                while (reader.Read())
                    order.AddProducts(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                reader.Close();
            }
            return order;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            SqlDataReader reader = new SqlCommand("select distinct order_id, convert(varchar(10),order_date,104), client_id, staff_id, order_sum from orders", connection).ExecuteReader();
            while (reader.Read())
                orders.Add(new Order(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    (double)reader.GetSqlMoney(4).Value));
            reader.Close();
            return orders;
        }

        public List<Log> GetLogs()
        {
            List<Log> logs = new List<Log>();
            SqlDataReader reader = new SqlCommand("select auth_id, user_login, convert(nvarchar,attempt_time,104), convert(nvarchar,attempt_time,108), authorized from authorisation", connection).ExecuteReader();
            while (reader.Read())
                logs.Add(new Log(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2) + " " + reader.GetString(3),
                    reader.GetBoolean(4)));
            reader.Close();
            return logs;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            SqlDataReader reader = new SqlCommand("select * from staff", connection).ExecuteReader();
            while (reader.Read())
                users.Add(new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetInt32(5)));
            reader.Close();
            return users;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            SqlDataReader reader = new SqlCommand("select * from product", connection).ExecuteReader();
            while (reader.Read())
                products.Add(new Product(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    Convert.ToDouble(reader.GetSqlMoney(2).Value.ToString()),
                    reader.GetInt32(3)));
            reader.Close();
            return products;
        }

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            SqlDataReader reader = new SqlCommand("select client_id, full_name, convert(varchar(10),birthday,104), passport_seria, passport_number, home_address, e_mail, phone from client", connection).ExecuteReader();
            while (reader.Read())
                clients.Add(new Client(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3) + reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7)));
            reader.Close();
            return clients;
        }

        public int GetNewOrderId()
        {
            SqlDataReader reader = new SqlCommand("select max(order_id) from orders", connection).ExecuteReader();
            int lastOrderId = 0;
            try
            {
                while (reader.Read())
                    lastOrderId = reader.GetInt32(0);
            }
            catch { }
            reader.Close();
            return lastOrderId + 1;
        }
    }
}
