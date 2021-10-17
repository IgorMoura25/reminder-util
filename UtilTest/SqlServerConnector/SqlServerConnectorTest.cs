using System;
using System.Data.SqlClient;
using Xunit;
using IgorMoura.UtilTest.Models;
using IgorMoura.Util.Data.DbConnectors;
using IgorMoura.Reminder.UtilTest;

namespace IgorMoura.UtilTest.SqlServerConnectorTest
{
    public class SqlServerConnectorTest
    {
        public SqlServerConnector _sqlServerConnector { get; set; } = new SqlServerConnector(TestConfiguration.ConnectionString);

        [Fact]
        public void ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                IsActive = true,
                CreatedAt = DateTime.Now,
                UserId = 1
            };

            //Act
            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("TSP_UTL_ADD_UtilTest", addRequestModel);

            //Assert
            Assert.True(utilTestId > 0, "The UtilTestId was not greater than zero");
        }

        [Fact]
        public void ExecuteAddProcedure_NullAddDataRequestModel_ThrowsSqlException()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<SqlException>(() => _sqlServerConnector.ExecuteAddProcedure<long>("TSP_UTL_ADD_NullUtilTest", null));
        }

        [Fact]
        public void ExecuteUpdateProcedure_ValidUpdateDataRequestModel_NumberOfUpdatedRowsGreaterThanZero()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                IsActive = true,
                CreatedAt = DateTime.Now,
                UserId = 1
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("TSP_UTL_ADD_UtilTest", addRequestModel);

            var updateRequestModel = new UpdateUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                NewDescription = "ExecuteUpdateProcedure_ValidUpdateDataRequestModel_NumberOfUpdatedRowsGreaterThanZero()",
                UserId = 1
            };

            //Act
            var rowsAffected = _sqlServerConnector.ExecuteUpdateProcedure("TSP_UTL_UPD_UtilTestById", updateRequestModel);

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
            var rowsAffected = _sqlServerConnector.ExecuteUpdateProcedure("TSP_UTL_UPD_UtilTestById", updateRequestModel);

            //Assert
            Assert.True(rowsAffected == 0, "The Rows Affected was greater than zero");
        }

        [Fact]
        public void ExecuteGetProcedure_ValidGetDataRequestModel_ResponseModelNotNull()
        {
            //Arrange
            var addRequestModel = new AddUtilTestRequestModel()
            {
                Description = "ExecuteAddProcedure_ValidAddDataRequestModel_IdGreaterThanZero()",
                IsActive = true,
                CreatedAt = DateTime.Now,
                UserId = 1
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("TSP_UTL_ADD_UtilTest", addRequestModel);

            var getRequestModel = new GetUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                UserId = 1
            };

            //Act
            var responseModel = _sqlServerConnector.ExecuteGetProcedure<GetUtilTestByIdResponseModel>("TSP_UTL_GET_UtilTestById", getRequestModel);

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
                IsActive = true,
                CreatedAt = DateTime.Now,
                UserId = 1
            };

            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("TSP_UTL_ADD_UtilTest", addRequestModel);

            var getRequestModel = new GetUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                UserId = 1
            };

            //Act
            var responseModel = _sqlServerConnector.ExecuteGetProcedure<GetUtilTestByIdResponseModel>("TSP_UTL_GET_UtilTestById", getRequestModel);

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
                IsActive = true,
                CreatedAt = DateTime.Now,
                UserId = 1
            };
        
            var utilTestId = _sqlServerConnector.ExecuteAddProcedure<long>("TSP_UTL_ADD_UtilTest", addRequestModel);
        
            var deleteRequestModel = new DeleteUtilTestByIdRequestModel()
            {
                UtilTestId = utilTestId,
                UserId = 1
            };
        
            //Act
            var rowsAffected = _sqlServerConnector.ExecuteDeleteProcedure("TSP_UTL_DEL_UtilTestById", deleteRequestModel);
        
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
                IsActive = true,
                CreatedAt = DateTime.Now,
                UserId = 1
            };

            _sqlServerConnector.ExecuteAddProcedure<long>("TSP_UTL_ADD_UtilTest", addRequestModel);

            _sqlServerConnector.ExecuteAddProcedure<long>("TSP_UTL_ADD_UtilTest", addRequestModel);

            var listRequestModel = new ListUtilTestRequestModel()
            {
                Count = 1000,
                Offset = 0,
                UserId = 1
            };

            //Act
            var listResult = _sqlServerConnector.ExecuteListProcedure<ListUtilTestResponseModel>("TSP_UTL_LST_UtilTest", listRequestModel);

            //Assert
            Assert.True(listResult.Count > 0, "Count list was not greater than zero");
        }
    }
}
