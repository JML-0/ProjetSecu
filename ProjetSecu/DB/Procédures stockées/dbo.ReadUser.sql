CREATE PROCEDURE [dbo].[ReadUser]
	@username nvarchar(44),
	@id int output,
	@email nvarchar(320) output,
	@address nvarchar(120) output,
	@age nvarchar(24) output,
	@sex nvarchar(24) output
AS
BEGIN
	SELECT @id = Id, @email = Email, @address = Address, @age = Age, @sex = Sex FROM Users where Username = @username
END