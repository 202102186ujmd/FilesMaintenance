CREATE TABLE [dbo].[Process]
(
	[IdProcess] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProcessName] NVARCHAR(50) NOT NULL,
    [Path] NVARCHAR(MAX) NOT NULL, 
    [Date] DATETIME NULL, 
    [FileCount] BIGINT NULL
    
)
