using UtilTest.Models;
using Util.Data.DbConnectors;
using Xunit;

namespace UtilTest.SqlServerConnectorTest
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
                UserId = 1
            };

            //Act
            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            //Assert
            Assert.True(utilTestId > 0, "The UtilTestId was not greater than zero");
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
                UserId = 1
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            var updateRequestModel = new UpdateUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                NewDescription = "ExecuteUpdateProcedure_ValidUpdateDataRequestModel_NumberOfUpdatedRowsGreaterThanZero()",
                UserId = 1
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
                UserId = 1
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
                UserId = 1
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            var getRequestModel = new GetUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                UserId = 1
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
                UserId = 1
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);

            var getRequestModel = new GetUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                UserId = 1
            };

            //Act
            var responseModel = _sqlServerConnector.ExecuteGetProcedure<GetUtilTestByIdResponseModel>("SP_RMD_GET_UtilTestById", getRequestModel);

            //Assert
            Assert.True(responseModel.UtilTestId > 0, "GetUtilTestByIdResponseModel.UtilTestId was not greater than zero");
        }

        //TODO Criar os testes para DELETE
        //[Fact]
        //public void ExecuteDeleteProcedure_ValidDeleteDataRequestModel_NumberOfDeletedRowsGreaterThanZero()
        //{
        //    //Arrange
        //    var addRequestModel = new AddUtilTestRequestModel()
        //    {
        //        Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
        //        UserId = 1
        //    };
        //
        //    var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("SP_RMD_ADD_UtilTest", addRequestModel);
        //
        //    var getRequestModel = new GetUtilTestByIdRequestModel()
        //    {
        //        UtilTestId = utilTestId,
        //        UserId = 1
        //    };
        //
        //    //Act
        //    var responseModel = _sqlServerConnector.ExecuteGetProcedure<GetUtilTestByIdResponseModel>("SP_RMD_GET_UtilTestById", getRequestModel);
        //
        //    //Assert
        //    Assert.True(responseModel.UtilTestId > 0, "GetUtilTestByIdResponseModel.UtilTestId was not greater than zero");
        //}
    }
}
