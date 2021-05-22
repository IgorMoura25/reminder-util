using Util.Models;

namespace Util.Data
{
    interface IDbConnector
    {
        T ExecuteAddProcedure<T>(string procedureName, DataRequestModel procedureParameter = null);
    }
}
