using System.Collections.Generic;
using Util.Models;

namespace Util.Data
{
    interface IDbConnector
    {
        T ExecuteAddProcedure<T>(string procedureName, DataRequestModel procedureParameter = null);
        long ExecuteUpdateProcedure(string procedureName, DataRequestModel procedureParameter = null);
        T ExecuteGetProcedure<T>(string procedureName, DataRequestModel procedureParameter = null);
        List<T> ExecuteListProcedure<T>(string procedureName, DataRequestModel procedureParameter = null);
        long ExecuteDeleteProcedure(string procedureName, DataRequestModel procedureParameter = null);
    }
}
