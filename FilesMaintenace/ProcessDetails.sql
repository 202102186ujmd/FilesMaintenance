CREATE TABLE [dbo].[ProcessDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdProcess] INT NULL, 
    [FileName] NVARCHAR(MAX) ,
    [Weight_File] BIGINT NULL, 
    [Extension] NCHAR(5) NULL, 
    [DeleteDate] DATETIME NULL
)
