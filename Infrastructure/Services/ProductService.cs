using Domain.Dto;
using Dapper;
using Npgsql;

namespace Infrastructure.Services;

    public class ProductsService
    {
        private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Dapper_Demo;User Id=postgres;Password=Hakimov9111m;";

       
         public List<Products> GetProducts()
        {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Products ";
            var result = connection.Query<Products>(sql).ToList();
            return result;
        }
        }
        public int InsertProducts(Products products)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into Products ( ProductName, Company, ProductCount, Price) VALUES " +
                    $"'{products.ProductName}',"
                    +$"'{products.Company}',"
                    +$"'{products.ProductCount}',"
                    +$"'{products.Price}')";
                var result = conn.Execute(sql);
                return result;
            }
        }
        public int UpdateProducts(Products products)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"UPDATE Orders SET" +
                    $"'{products.ProductName}',"
                    +$"'{products.Company}',"
                    +$"'{products.ProductCount}',"
                    +$"'{products.Price}')";
                var result = conn.Execute(sql);
                return result;
            }
        }
        public int DeleteProducts(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM Products WHERE id = {id}";

                var result = conn.Execute(sql);

                return result;
            }
        }
          public int CountProducts()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"Select count(*) FROM Products";

                var result = conn.Execute(sql);

                return  result;
            }
        }   
        public int ByIdOrders(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"select * from Products where id = {id}";
                var result = conn.Execute(sql);
                return result;
            }
        }
    }