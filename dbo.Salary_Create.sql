CREATE TABLE [dbo].[Salary]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(100) NULL, 
    [Position_id] INT NULL, 
    [Department_id] INT NULL, 
    [Value] DECIMAL(18, 2) NULL, 
    CONSTRAINT [FK_Salary_Position] FOREIGN KEY ([Position_id]) REFERENCES [Position]([id]),
	CONSTRAINT [FK_Salary_Department] FOREIGN KEY ([Department_id]) REFERENCES [Department]([id])
)
