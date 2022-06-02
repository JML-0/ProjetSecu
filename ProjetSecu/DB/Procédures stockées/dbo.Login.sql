CREATE PROCEDURE [dbo].[Login]
	@username nvarchar(44),
	@password nvarchar(192)
AS
BEGIN
	IF EXISTS(SELECT * FROM Users WHERE Username = @username AND Password = @password)
		RETURN 1
	ELSE
		RETURN 0
END