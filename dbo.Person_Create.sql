CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [LastName] NCHAR(100) NULL,
	[FirstName] NCHAR(100) NULL, 
    [DateBorn] DATE NULL, 
    [Gender] NCHAR(1) NULL
)
