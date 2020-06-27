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

INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия1', N'Имя1', N'1978-06-12', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия2', N'Имя2', N'1972-04-08', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия3', N'Имя3', N'2000-12-27', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия4', N'Имя4', N'1968-03-06', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия5', N'Имя5', N'1994-11-23', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия6', N'Имя6', N'1974-05-10', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия7', N'Имя7', N'1989-09-20', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия8', N'Имя8', N'1991-10-21', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия9', N'Имя9', N'1973-04-09', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия10', N'Имя10', N'1975-05-11', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия11', N'Имя11', N'1997-12-25', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия12', N'Имя12', N'1963-01-03', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия13', N'Имя13', N'1962-01-02', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия14', N'Имя14', N'1991-10-22', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия15', N'Имя15', N'1969-03-07', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия16', N'Имя16', N'1973-05-10', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия17', N'Имя17', N'1997-11-25', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия18', N'Имя18', N'1976-05-11', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия19', N'Имя19', N'1972-04-09', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия20', N'Имя20', N'1989-09-20', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия21', N'Имя21', N'1990-09-21', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия22', N'Имя22', N'1997-11-25', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия23', N'Имя23', N'1962-01-02', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия24', N'Имя24', N'1967-03-06', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия25', N'Имя25', N'1969-03-07', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия26', N'Имя26', N'1980-07-14', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия27', N'Имя27', N'1981-07-14', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия28', N'Имя28', N'1973-04-09', N'М')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия29', N'Имя29', N'1991-10-22', N'Ж')
INSERT INTO [dbo].[Person] ([LastName], [FirstName], [DateBorn], [Gender]) VALUES (N'Фамилия30', N'Имя30', N'2000-03-02', N'Ж')

INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость1')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость2')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость3')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость4')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость5')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость6')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость7')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость8')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость9')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость10')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость11')
INSERT INTO [dbo].[Position] ([Name] ) VALUES (N'Должость12')

INSERT INTO [dbo].[Department] ([Name],[Parent]) VALUES (N'Подразделение1',null)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'Подразделение2',1)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'Подразделение3',1)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'Подразделение4',2)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'Подразделение5',3)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'Подразделение6',4)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'Подразделение7',5)
INSERT INTO [dbo].[Department] ([Name],[Parent] ) VALUES (N'Подразделение8',5)

INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ1', 1, NULL, CAST(350000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ2', 2, NULL, CAST(157000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ3', 3, NULL, CAST(116000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ4', 4, NULL, CAST(162000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ5', 5, NULL, CAST(136000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ6', 6, NULL, CAST(62000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ7', 7, NULL, CAST(169000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ8', 8, NULL, CAST(143000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ9', 9, NULL, CAST(81000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ10', 10, NULL, CAST(60000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ11', 11, NULL, CAST(236000 AS Decimal(18, 2)))
INSERT INTO [dbo].[Salary] ([Name], [Position_id], [Department_id], [Value]) VALUES (N'ФОТ12', 12, NULL, CAST(183000 AS Decimal(18, 2)))

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