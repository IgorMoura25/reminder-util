USE Reminder_Dev
GO

CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_UPD_UtilTestById]
(
	@UtilTestId BIGINT,
	@NewDescription VARCHAR(100),
	@UserId BIGINT
)
AS
BEGIN
	
	UPDATE
		UtilTests
	SET
		Description = @NewDescription
	WHERE
		UtilTests.UtilTestId = @UtilTestId

END
GO