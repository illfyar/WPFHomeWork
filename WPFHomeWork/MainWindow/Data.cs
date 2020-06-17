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
        public static List<Employee> ListEmployes()
        {
            return new List<Employee> {new Employee("Иван","Иванов", new DateTime(1990,01,01)),
            new Employee("Петр", "Петров", new DateTime(1990, 01, 02)),
            new Employee("Сидр","Сидоров", new DateTime(1990,01,03))};            
        }
    }
}
