using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork.data
{
    static class Data
    {
        public static ObservableCollection<Employee> ObservableCollectionEmployes()
        {

            return new ObservableCollection<Employee> {new Employee("Иван","Иванов", new DateTime(1990,01,01)),
            new Employee("Петр", "Петров", new DateTime(1990, 01, 02)),
            new Employee("Сидр","Сидоров", new DateTime(1990,01,03))};            
        }
        public static ObservableCollection<Position> ObservableCollectionPositions()
        {

            return new ObservableCollection<Position> {new Position("Руководитель"),new Position("Старший программист"), new Position("Программист")};
        }
        public static ObservableCollection<Department> ObservableCollectionDepartments()
        {
            ObservableCollection<Department> departments = new ObservableCollection<Department>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Department department = new Department("Подразледение " + i);
                departments.Add(department);
            }
            //departments = departments.Select(x => x.Level += random.Next(1, 3)).ToList();
            foreach (Department department in departments)
            {
                department.Level = random.Next(1, 4);
            }
            departments[0].Level = 0;
            var departmentsLvl1 = departments.Where(x => x.Level == 1).ToList();
            var departmentsLvl2 = departments.Where(x => x.Level == 2).ToList();
            var departmentsLvl3 = departments.Where(x => x.Level == 3).ToList();
            departments[0].Subsidiary = departmentsLvl1.ToList();
            foreach (Department department in departmentsLvl1)
            {
                department.Parent = departments[0];
            }
            foreach (Department department in departmentsLvl2)
            {
                Department parent = departmentsLvl1[random.Next(0, departmentsLvl1.Count)];
                department.Parent = parent;
                parent.Subsidiary.Add(department);
            }
            foreach (Department department in departmentsLvl3)
            {
                Department parent = departmentsLvl2[random.Next(0, departmentsLvl2.Count)];
                department.Parent = parent;
                parent.Subsidiary.Add(department);
            }
            return departments;
        }
    }
}
