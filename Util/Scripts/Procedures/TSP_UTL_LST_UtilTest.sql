USE Reminder_Dev
GO

CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_LST_UtilTest]
(
	@Offset BIGINT,
	@Count BIGINT,
	@UserId BIGINT
)
AS
BEGIN
	SELECT
		UtilTests.UtilTestId
	FROM
		UtilTests
	ORDER BY
		UtilTests.UtilTestId
	OFFSET 
		@Offset ROWS
	FETCH NEXT 
		@Count ROWS ONLY;
END
GO