using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DapperORM
{
    public interface IDapperRepository
    {
        Task QueryStoreProcedureAsync(string storeProcedureName, Action<SqlMapper.GridReader> callbackReader, object? parameters = null);
        void QueryStoreProcedure(string storeProcedureName, Action<SqlMapper.GridReader> callbackReader, object? parameters = null);
    }
    public class DapperRepository : IDapperRepository
    {
        private readonly IConfiguration _configuration;

        public DapperRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task QueryStoreProcedureAsync(string storeProcedureName, Action<SqlMapper.GridReader> callbackReader,
            object? parameters = null)
        {
            using (var connection = await OpenAsync())
            {
                var procedure = await connection.QueryMultipleAsync(storeProcedureName, param: parameters, 
                                                 commandTimeout : 60, commandType: System.Data.CommandType.StoredProcedure);
                callbackReader(procedure);
            }
        }
        public void QueryStoreProcedure(string storeProcedureName, Action<SqlMapper.GridReader> callbackReader,
            object? parameters = null)
        {
            using (var connection =  Open())
            {
                var procedure =  connection.QueryMultiple(storeProcedureName, param: parameters,
                                                 commandTimeout: 60, commandType: System.Data.CommandType.StoredProcedure);
                callbackReader(procedure);
            }
        }
        private SqlConnection Open()
        {
            var sqlConnection = new SqlConnection(_configuration.GetConnectionString("DbConnection"));

            sqlConnection.Open();

            return sqlConnection;
        }
        private async Task<SqlConnection> OpenAsync()
        {
            var sqlConnection = new SqlConnection(_configuration.GetConnectionString("DbConnection"));

            await sqlConnection.OpenAsync();

            return sqlConnection;
        }

    }
}
