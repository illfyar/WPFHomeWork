CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [LastName] NCHAR(100) NULL,
	[FirstName] NCHAR(100) NULL, 
    [DateBorn] DATE NULL, 
    [Gender] NCHAR(1) NULL
)
CREATE TABLE [dbo].[Position]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(200) NULL
)
CREATE TABLE [dbo].[Department]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(200) NULL, 
    [Parent] INT NULL, 
    CONSTRAINT [FK_Department_Department] FOREIGN KEY ([Parent]) REFERENCES [Department]([Id])
)
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

