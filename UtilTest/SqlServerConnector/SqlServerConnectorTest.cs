using Xunit;
using IgorMoura.UtilTest.Models;
using IgorMoura.Util.Data.DbConnectors;
using System.Threading.Tasks;

namespace IgorMoura.UtilTest.SqlServerConnectorTest
{
    public class SqlServerConnectorTest
    {
        public SqlServerConnector _sqlServerConnector { get; set; } = new SqlServerConnector();

        [Fact]
        public void ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                UserId = string.Empty
            };

            //Act
            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            //Assert
            Assert.True(utilTestId > 0, "The UtilTestId was greater than zero");
        }

        [Fact]
        public void ExecuteAddProcedure_NullAddDataRequestModel_IdGreaterThanZero()
        {
            //Arrange
            //Act
            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_NullUtilTest", null);

            //Assert
            Assert.True(utilTestId > 0, "The UtilTestId was not greater than zero");
        }

        [Fact]
        public void ExecuteUpdateProcedure_ValidUpdateDataRequestModel_NumberOfUpdatedRowsGreaterThanZero()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                UserId = string.Empty
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            var updateRequestModel = new UpdateUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                NewDescription = "ExecuteUpdateProcedure_ValidUpdateDataRequestModel_NumberOfUpdatedRowsGreaterThanZero()",
                UserId = string.Empty
            };

            //Act
            var rowsAffected = _sqlServerConnector.ExecuteUpdateProcedure("SP_RMD_UPD_UtilTestById", updateRequestModel);

            //Assert
            Assert.True(rowsAffected > 0, "The Rows Affected was not greater than zero");
        }

        [Fact]
        public void ExecuteUpdateProcedure_InvalidUpdateDataRequestModel_NumberOfUpdatedRowsEqualsZero()
        {
            //Arrange
            var updateRequestModel = new UpdateUtilTestByIdRequestModel()
            {
                UtilTestId = -1,
                NewDescription = "ExecuteUpdateProcedure_InvalidUpdateDataRequestModel_NumberOfUpdatedRowsGreaterThanZero()",
                UserId = string.Empty
            };

            //Act
            var rowsAffected = _sqlServerConnector.ExecuteUpdateProcedure("SP_RMD_UPD_UtilTestById", updateRequestModel);

            //Assert
            Assert.True(rowsAffected == 0, "No rows were affected");
        }

        [Fact]
        public void ExecuteGetProcedure_ValidGetDataRequestModel_ResponseModelNotNull()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                UserId = string.Empty
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            var getRequestModel = new GetUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                UserId = string.Empty
            };

            //Act
            var responseModel = _sqlServerConnector.ExecuteGetProcedure<GetUtilTestByIdResponseModel>("SP_RMD_GET_UtilTestById", getRequestModel);

            //Assert
            Assert.True(responseModel != null, "Response model was null");
        }

        [Fact]
        public void ExecuteGetProcedure_ValidGetDataRequestModel_IdGreaterThanZero()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                UserId = string.Empty
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            var getRequestModel = new GetUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                UserId = string.Empty
            };

            //Act
            var responseModel = _sqlServerConnector.ExecuteGetProcedure<GetUtilTestByIdResponseModel>("SP_RMD_GET_UtilTestById", getRequestModel);

            //Assert
            Assert.True(responseModel.UtilTestId > 0, "Id was not greater than zero");
        }

        [Fact]
        public void ExecuteDeleteProcedure_ValidDeleteDataRequestModel_NumberOfDeletedRowsGreaterThanZero()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                UserId = string.Empty
            };
        
            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);
        
            var deleteRequestModel = new DeleteUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                UserId = string.Empty
            };
        
            //Act
            var rowsAffected = _sqlServerConnector.ExecuteDeleteProcedure("SP_RMD_DEL_UtilTestById", deleteRequestModel);
        
            //Assert
            Assert.True(rowsAffected > 0, "No rows were affected");
        }

        [Fact]
        public void ExecuteListProcedure_ValidListDataRequestModel_CountListGreaterThanZero()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                UserId = string.Empty
            };

            _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            var listRequestModel = new ListUtilTestRequestModel()
            {
                UserId = string.Empty
            };

            //Act
            var listResult = _sqlServerConnector.ExecuteListProcedure<ListUtilTestResponseModel>("SP_RMD_LST_UtilTest", listRequestModel);

            //Assert
            Assert.True(listResult.Count > 0, "Count list was not greater than zero");
        }
    }
}
