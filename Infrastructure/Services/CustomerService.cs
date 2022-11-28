using Domain.Dto;
using Dapper;
using Npgsql;

namespace Infrastructure.Services;

    public class CustomerService
    {
        private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Dapper_Demo;User Id=postgres;Password=Hakimov9111m;";

       
         public List<Customers> GetCustomers()
        {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Customer ";
            var result = connection.Query<Customers>(sql).ToList();
            return result;
        }
        }
        public int InsertCustomers(Customers customers)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into Customer ( FirstName ) VALUES " +
                    $"'{customers.FirstName}')";
                var result = conn.Execute(sql);
                return (int)result;
            }
        }
        public int UpdateCustomers(Customers customers)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = 
                    $"UPDATE Customer SET " +
                   $"'{customers.FirstName}')";
                var result = conn.Execute(sql);

                return (int)result;
            }
        }
        public int DeleteCustomers(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM Customer WHERE id = {id}";

                var result = conn.Execute(sql);

                return (int)result;
            }
        }
          public int CountCustomers()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"Select count(*) FROM Customer";

                var result = conn.Execute(sql);

                return (int) result;
            }
        }   
        public int ByIdCustomers(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"select * from Customer where id = {id}";

                var result = conn.Execute(sql);

                return (int)result;
            }
        }
    }