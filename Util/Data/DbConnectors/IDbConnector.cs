using Util.Models;

namespace Util.Data.DbConnectors
{
    public interface IDbConnector
    {
        T ExecuteAddProcedure<T>(string procedureName, DataRequestModel procedureParameter = null);
    }
}
