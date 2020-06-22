CREATE TABLE [dbo].[Department]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(200) NULL, 
    [Parent] INT NULL, 
    CONSTRAINT [FK_Department_Department] FOREIGN KEY ([Parent]) REFERENCES [Department]([Id])
)
