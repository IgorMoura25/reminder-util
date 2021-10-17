USE Reminder_Dev
GO

CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_ADD_NullUtilTest]
(
	@IsActive BIT,
	@CreatedAt DATETIME,
	@UserId BIGINT
)
AS
BEGIN
	INSERT INTO
		UtilTests
	(
		Description
	)
	VALUES
	(
		'ExecuteAddProcedure_NullAddDataRequestModel_IdGreaterThanZero'
	)

	SELECT CONVERT(BIGINT, SCOPE_IDENTITY())
END
GO