USE Reminder_Dev
GO

CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_ADD_UtilTest]
(
	@Description VARCHAR(100),
	@UserId VARCHAR(68)
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