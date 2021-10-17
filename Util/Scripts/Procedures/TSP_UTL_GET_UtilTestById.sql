USE Reminder_Dev
GO

CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_GET_UtilTestById]
(
	@UtilTestId BIGINT,
	@UserId BIGINT
)
AS
BEGIN
	
	SELECT
		UtilTests.UtilTestId
	FROM
		UtilTests
	WHERE
		UtilTests.UtilTestId = @UtilTestId
END
GO