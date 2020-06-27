using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork.Data
{
    static class DataQueries
    {
        public static ObservableCollection<Employee> SelectEmployes()
        {
            using(MyDBContext context = new MyDBContext())
            {
                var employees = context.Employee.Include("Position").
                    Include("Department").Include("Salary").ToList<Employee>();

                return new ObservableCollection<Employee>(employees);
            }
        }

        public static ObservableCollection<Position> SelectPositions()
        {
            using (MyDBContext context = new MyDBContext())
            {
                return new ObservableCollection<Position>(context.Position.ToList<Position>());
            }
        }
        public static ObservableCollection<Department> ObservableCollectionDepartments()
        {
            using (MyDBContext context = new MyDBContext())
            {
                return new ObservableCollection<Department>(context.Department.ToList<Department>());
            }
        }        
    }
}
