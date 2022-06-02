CREATE PROCEDURE [dbo].[EditUser]
	@id int,
	@username nvarchar(44),
	@password nvarchar(192),
	@email nvarchar(320),
	@address nvarchar(120),
	@age nvarchar(24),
	@sex nvarchar(24),
	@typeEdit nvarchar(20)
AS
BEGIN
	IF @typeEdit = 'Insert'
		BEGIN TRY
			INSERT INTO Users	(Username, Password, Email, Address, Age, Sex)
			VALUES				(@username, @password, @email, @address, @age, @sex)
			RETURN 1
		END TRY
		BEGIN CATCH
			RETURN 0
		END CATCH
	IF @typeEdit = 'Exist'
		BEGIN TRY
			IF EXISTS(SELECT * FROM Users WHERE Username = @username)
				RETURN 1
			ELSE
				RETURN 0
		END TRY
		BEGIN CATCH
			RETURN 0
		END CATCH
	IF @typeEdit = 'Update'
		BEGIN TRY
            UPDATE	Users
            SET		Username = @username,
					Password = @password,
					Email = @email,
					Address = @address,
					Age = @age,
					Sex = @sex
            WHERE	Id = @id
			RETURN 1
        END TRY
		BEGIN CATCH
			RETURN 0
		END CATCH
	ELSE IF @typeEdit = 'Delete'
		BEGIN TRY
            DELETE FROM Users
            WHERE		Id = @id
			RETURN 1
        END TRY
		BEGIN CATCH
			RETURN 0
		END CATCH
END