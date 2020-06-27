CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] NCHAR(100) NULL,
	[FirstName] NCHAR(100) NULL, 
    [DateBorn] DATE NULL, 
    [Gender] NCHAR(1) NULL
)
CREATE TABLE [dbo].[Position]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(200) NULL
)
CREATE TABLE [dbo].[Department]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(200) NULL, 
    [Parent_id] INT NULL, 
    CONSTRAINT [FK_Department_Department] FOREIGN KEY ([Parent_id]) REFERENCES [Department]([Id])
)
CREATE TABLE [dbo].[Salary]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(100) NULL, 
    [Position_id] INT NULL, 
    [Department_id] INT NULL, 
    [Value] DECIMAL(18, 2) NULL, 
    CONSTRAINT [FK_Salary_Position] FOREIGN KEY ([Position_id]) REFERENCES [Position]([id]),
	CONSTRAINT [FK_Salary_Department] FOREIGN KEY ([Department_id]) REFERENCES [Department]([id])
)
CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Person_id] INT NULL, 
    [Position_id] INT NULL, 
    [Department_id] INT NULL, 
    [Salary_id] INT NULL, 
    CONSTRAINT [FK_Employee_Person] FOREIGN KEY ([Person_id]) REFERENCES [Person]([id]),
	CONSTRAINT [FK_Employee_Position] FOREIGN KEY ([Position_id]) REFERENCES [Position]([id]),
	CONSTRAINT [FK_Employee_Department] FOREIGN KEY ([Department_id]) REFERENCES [Department]([id]),
	CONSTRAINT [FK_Employee_Salary] FOREIGN KEY ([Salary_id]) REFERENCES [Salary]([id])
)

INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������1', N'���1', N'1978-06-12', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������2', N'���2', N'1972-04-08', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������3', N'���3', N'2000-12-27', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������4', N'���4', N'1968-03-06', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������5', N'���5', N'1994-11-23', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������6', N'���6', N'1974-05-10', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������7', N'���7', N'1989-09-20', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������8', N'���8', N'1991-10-21', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������9', N'���9', N'1973-04-09', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������10', N'���10', N'1975-05-11', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������11', N'���11', N'1997-12-25', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������12', N'���12', N'1963-01-03', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������13', N'���13', N'1962-01-02', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������14', N'���14', N'1991-10-22', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������15', N'���15', N'1969-03-07', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������16', N'���16', N'1973-05-10', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������17', N'���17', N'1997-11-25', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������18', N'���18', N'1976-05-11', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������19', N'���19', N'1972-04-09', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������20', N'���20', N'1989-09-20', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������21', N'���21', N'1990-09-21', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������22', N'���22', N'1997-11-25', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������23', N'���23', N'1962-01-02', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������24', N'���24', N'1967-03-06', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������25', N'���25', N'1969-03-07', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������26', N'���26', N'1980-07-14', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������27', N'���27', N'1981-07-14', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������28', N'���28', N'1973-04-09', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������29', N'���29', N'1991-10-22', N'�')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'�������30', N'���30', N'2000-03-02', N'�')

INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������1')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������2')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������3')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������4')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������5')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������6')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������7')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������8')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������9')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������10')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������11')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'��������12')

INSERT INTO [dbo].[Department] ([Name],[Parent]) VALUES (N'�������������1',null)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'�������������2',1)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'�������������3',1)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'�������������4',2)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'�������������5',3)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'�������������6',4)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'�������������7',5)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'�������������8',5)

INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���1', 1, NULL, CAST(350000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���2', 2, NULL, CAST(157000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���3', 3, NULL, CAST(116000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���4', 4, NULL, CAST(162000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���5', 5, NULL, CAST(136000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���6', 6, NULL, CAST(62000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���7', 7, NULL, CAST(169000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���8', 8, NULL, CAST(143000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���9', 9, NULL, CAST(81000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���10', 10, NULL, CAST(60000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���11', 11, NULL, CAST(236000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'���12', 12, NULL, CAST(183000 AS Decimal(18, 2)))

INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (1, 1, 1, 1)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (2, 11, 8, 11)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (3, 8, 5, 8)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (4, 10, 7, 10)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (5, 5, 4, 5)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (6, 7, 5, 7)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (7, 8, 5, 8)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (8, 7, 5, 7)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (9, 3, 1, 3)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (10, 10, 7, 10)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (11, 12, 8, 12)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (12, 11, 7, 11)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (13, 5, 1, 5)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (14, 5, 3, 5)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (15, 9, 6, 9)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (16, 11, 7, 11)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (17, 10, 7, 10)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (18, 6, 4, 6)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (19, 9, 6, 9)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (20, 4, 3, 4)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (21, 5, 4, 5)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (22, 10, 1, 10)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (23, 5, 3, 5)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (24, 11, 7, 11)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (25, 10, 7, 10)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (26, 4, 3, 4)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (27, 6, 4, 6)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (28, 5, 3, 5)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (29, 2, 2, 2)
INSERT INTO [dbo].[Employee] ([Person_id], [Position_id], [Department_id], [Salary_id]) VALUES (30, 9, 6, 9)