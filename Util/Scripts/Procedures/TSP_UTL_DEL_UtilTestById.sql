CREATE OR ALTER PROCEDURE [dbo].[TSP_UTL_DEL_UtilTestById]
(
	@UtilTestId BIGINT,
	@UserId VARCHAR(68)
)
AS
BEGIN
	
	DELETE FROM
		UtilTests
	WHERE
		UtilTests.UtilTestId = @UtilTestId

END
GO