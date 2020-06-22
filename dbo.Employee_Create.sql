CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Person_id] INT NULL, 
    [Position_id] INT NULL, 
    [Department_id] INT NULL, 
    [Salary_id] INT NULL, 
    CONSTRAINT [FK_Employee_Person] FOREIGN KEY ([Person_id]) REFERENCES [Person]([id]),
	CONSTRAINT [FK_Employee_Position] FOREIGN KEY ([Position_id]) REFERENCES [Position]([id]),
	CONSTRAINT [FK_Employee_Department] FOREIGN KEY ([Department_id]) REFERENCES [Department]([id]),
	CONSTRAINT [FK_Employee_Salary] FOREIGN KEY ([Salary_id]) REFERENCES [Salary]([id])
)
