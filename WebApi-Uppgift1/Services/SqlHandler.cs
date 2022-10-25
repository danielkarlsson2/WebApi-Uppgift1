using Dapper;
using Microsoft.Data.SqlClient;

namespace WebApi_Uppgift1.Services
{
    public class SqlHandler<T> where T : class
    {
        private readonly string connectionString = "Server=tcp:azure-db-feu21-daniel.database.windows.net,1433;Initial Catalog=azure-db-feu21-daniel;Persist Security Info=False;User ID=SqlAdmin;Password=Bytmig123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Create to db
        public async Task CreateAsync(string query, T entity)
        {
            using var conn = new SqlConnection(connectionString);
            await conn.ExecuteAsync(query, entity);
        }

        // Get from db
        public async Task<IEnumerable<object>> GetAsync(string query)
        {
            using var conn = new SqlConnection(connectionString);
            return await conn.QueryAsync<object>(query);
        }

    }
}
