CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_LST_UtilTest]
(
	@UserId VARCHAR(68)
)
AS
BEGIN
	SELECT
		UtilTests.UtilTestId
	FROM
		UtilTests
	ORDER BY
		UtilTests.UtilTestId
END