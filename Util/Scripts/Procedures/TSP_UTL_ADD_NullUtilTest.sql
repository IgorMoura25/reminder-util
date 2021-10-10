CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_ADD_NullUtilTest]
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