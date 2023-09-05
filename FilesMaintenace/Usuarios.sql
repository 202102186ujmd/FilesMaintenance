CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] VARBINARY(MAX) NOT NULL, 
    [IsActive] BIT NULL DEFAULT 1
)

GO

CREATE UNIQUE INDEX [IX_Usuarios_Column] ON [dbo].[Usuarios] ([UserName]) 
