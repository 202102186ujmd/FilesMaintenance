CREATE TABLE [dbo].[ProcessDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdProcess] INT NULL, 
    [Weight_File] INT NULL, 
    [Extension] NCHAR(4) NULL, 
    [DeleteDate] DATETIME NULL
)
