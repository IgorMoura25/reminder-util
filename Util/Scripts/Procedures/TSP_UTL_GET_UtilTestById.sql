USE Reminder_Dev
GO

CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_GET_UtilTestById]
(
	@UtilTestId BIGINT,
	@UserId VARCHAR(68)
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