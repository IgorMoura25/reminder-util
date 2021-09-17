using Dapper;
using IgorMoura.Util.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IgorMoura.Util.Data.DbConnectors
{
    public class SqlServerConnector : IDbConnector
    {
        private const int COMMAND_TIMEOUT = 300;
        private string ConnectionString { get; set; } = "Server= localhost; Database=Reminder_Dev; Integrated Security=True;";
        private SqlConnection OpenNewConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }

        public T ExecuteAddProcedure<T>(string procedureName, DataRequestModel procedureParameter = null)
        {
            using(var connection = OpenNewConnection())
            {
                var procedureResult = connection.QuerySingle<T>(
                    procedureName, 
                    param: procedureParameter != null ? procedureParameter.ShallowCopy() : null,
                    commandType: System.Data.CommandType.StoredProcedure, 
                    commandTimeout: COMMAND_TIMEOUT);

                return procedureResult;
            }
        }

        public async Task<T> ExecuteAddProcedureAsync<T>(string procedureName, DataRequestModel procedureParameter = null)
        {
            using (var connection = OpenNewConnection())
            {
                var procedureResult = await connection.QuerySingleAsync<T>(
                    procedureName,
                    param: procedureParameter != null ? procedureParameter.ShallowCopy() : null,
                    commandType: System.Data.CommandType.StoredProcedure,
                    commandTimeout: COMMAND_TIMEOUT);

                return procedureResult;
            }
        }

        public long ExecuteUpdateProcedure(string procedureName, DataRequestModel procedureParameter = null)
        {
            using (var connection = OpenNewConnection())
            {
                var procedureResult = connection.Execute(
                    procedureName,
                    param: procedureParameter != null ? procedureParameter.ShallowCopy() : null,
                    commandType: System.Data.CommandType.StoredProcedure,
                    commandTimeout: COMMAND_TIMEOUT);

                return procedureResult;
            }
        }

        public T ExecuteGetProcedure<T>(string procedureName, DataRequestModel procedureParameter = null)
        {
            using (var connection = OpenNewConnection())
            {
                var procedureResult = connection.QuerySingleOrDefault<T>(
                    procedureName,
                    param: procedureParameter != null ? procedureParameter.ShallowCopy() : null,
                    commandType: System.Data.CommandType.StoredProcedure,
                    commandTimeout: COMMAND_TIMEOUT);

                return procedureResult;
            }
        }

        public List<T> ExecuteListProcedure<T>(string procedureName, DataRequestModel procedureParameter = null)
        {
            using (var connection = OpenNewConnection())
            {
                var procedureResult = connection.Query<T>(
                    procedureName,
                    param: procedureParameter != null ? procedureParameter.ShallowCopy() : null,
                    commandType: System.Data.CommandType.StoredProcedure,
                    commandTimeout: COMMAND_TIMEOUT);

                return procedureResult?.ToList();
            }
        }

        public long ExecuteDeleteProcedure(string procedureName, DataRequestModel procedureParameter = null)
        {
            using (var connection = OpenNewConnection())
            {
                var procedureResult = connection.Execute(
                    procedureName,
                    param: procedureParameter != null ? procedureParameter.ShallowCopy() : null,
                    commandType: System.Data.CommandType.StoredProcedure,
                    commandTimeout: COMMAND_TIMEOUT);

                return procedureResult;
            }
        }
    }
}
