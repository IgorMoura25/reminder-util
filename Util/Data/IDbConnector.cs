using IgorMoura.Util.Models;
using System.Collections.Generic;

namespace IgorMoura.Util.Data
{
    public interface IDbConnector
    {
        T ExecuteAddProcedure<T>(string procedureName, DataRequestModel procedureParameter = null);
        long ExecuteUpdateProcedure(string procedureName, DataRequestModel procedureParameter = null);
        T ExecuteGetProcedure<T>(string procedureName, DataRequestModel procedureParameter = null);
        List<T> ExecuteListProcedure<T>(string procedureName, DataRequestModel procedureParameter = null);
        long ExecuteDeleteProcedure(string procedureName, DataRequestModel procedureParameter = null);
    }
}
