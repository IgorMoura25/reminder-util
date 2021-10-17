USE Reminder_Dev
GO

CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_ADD_UtilTest]
(
	@Description VARCHAR(100),
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
		@Description
	)

	SELECT CONVERT(BIGINT, SCOPE_IDENTITY())
END
GO