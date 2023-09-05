CREATE PROCEDURE [dbo].[Sp_Authenticate]
	@Option int = 0,
	@UserName nvarchar(50),
	@Password nvarchar(50)
AS

--Option = 1:Crear Usuario
if @Option = 1
Begin
	insert into Usuarios
	(UserName,Password)
	Values(@UserName,PWDENCRYPT(@Password))
End

--Option =2:Login
IF @Option = 2
Begin
	Select Count(*) From
	Usuarios
	Where UserName = @UserName
	and PWDCOMPARE(@Password,Password) = 1
End