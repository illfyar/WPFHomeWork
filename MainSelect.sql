Select 
Employee.Id AS N'Табельный Номер',
Person.LastName AS N'Фамилия',
Person.FirstName AS N'Имя',
Person.DateBorn AS N'Дата рождения',
Position.Name AS N'Должность',
Department.Name AS N'Подразделение',
Salary.Value AS N'ФОТ' 
From Employee 
Left join Person on Person_id = Person.Id 
Left join Position on Employee.Position_id = Position.Id 
Left join Department on Department_id = Department.Id 
Left Join Salary on Salary_id = Salary.Id