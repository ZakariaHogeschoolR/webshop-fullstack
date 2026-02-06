using Npgsql;
using Webshop.Models;

namespace Webshop.DatabaseService
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") 
                                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }

        public Task<List<User>> Users { get; internal set; }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public async Task TestConnectionAsync()
        {
            using var connection = GetConnection();
            await connection.OpenAsync();
            await connection.CloseAsync();
        }
    }
}