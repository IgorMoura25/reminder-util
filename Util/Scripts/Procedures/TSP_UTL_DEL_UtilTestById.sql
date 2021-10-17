USE Reminder_Dev
GO

CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_DEL_UtilTestById]
(
	@UtilTestId BIGINT,
	@UserId BIGINT
)
AS
BEGIN
	
	DELETE FROM
		UtilTests
	WHERE
		UtilTests.UtilTestId = @UtilTestId

END
GO