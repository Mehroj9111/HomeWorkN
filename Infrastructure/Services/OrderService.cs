using Domain.Dto;
using Dapper;
using Npgsql;

namespace Infrastructure.Services;

    public class OrdersService
    {
        private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Dapper_Demo;User Id=postgres;Password=Hakimov9111m;";

       
         public List<Orders> GetOrderss()
        {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Orders ";
            var result = connection.Query<Orders>(sql).ToList();
            return result;
        }
        }
        public int InsertOrderss(Orders orders)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into Orders ( ProductName, CustamerId, CreateAt, ProductCount, Price) VALUES " +
                    $"'{orders.ProductName}',"
                    +$"'{orders.CustomerId}',"
                    +$"'{orders.CreateAt}',"
                    +$"'{orders.ProductCount}',"
                    +$"'{orders.Price}')";
                var result = conn.Execute(sql);
                return (int)result;
            }
        }
        public int UpdateOrders(Orders orders)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"UPDATE Orders SET" +
                    $"'{orders.ProductName}',"
                    +$"'{orders.CustomerId}',"
                    +$"'{orders.CreateAt}',"
                    +$"'{orders.ProductCount}',"
                    +$"'{orders.Price}')";
                var result = conn.Execute(sql);
                return (int)result;
            }
        }
        public int DeleteOrders(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM Orders WHERE id = {id}";

                var result = conn.Execute(sql);

                return (int)result;
            }
        }
          public int CountOrders()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"Select count(*) FROM Orders";

                var result = conn.Execute(sql);

                return (int) result;
            }
        }   
        public int ByIdOrders(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"select * from Orders where id = {id}";
                var result = conn.Execute(sql);
                return (int)result;
            }
        }
    }