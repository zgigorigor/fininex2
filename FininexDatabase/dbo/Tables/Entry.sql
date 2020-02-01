CREATE TABLE [dbo].[Entry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Amount] INT NOT NULL, 
    [Currency] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL
)
