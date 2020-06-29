using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace WPFHomeWork.Data
{
    static class DataQueries
    {
        #region Select
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
        public static ObservableCollection<Department> SelectDepartments()
        {
            using (MyDBContext context = new MyDBContext())
            {
                return new ObservableCollection<Department>(context.Department.ToList<Department>());
            }
        }

        public static ObservableCollection<Salary> SelectSalaries()
        {
            using (MyDBContext context = new MyDBContext())
            {
                return new ObservableCollection<Salary>(context.Salary.ToList<Salary>());
            }
        }
        #endregion
        public static void UpdateData<T>(T obj) 
            where T : class, IObjectDB             
        {
            using (MyDBContext context = new MyDBContext())
            {
                T objDb = context.Set<T>().Where(c => c.Id == obj.Id).First<T>();
                HandlingObjects.CopyValueProperties<T>(objDb, obj);
                context.SaveChanges();
            }
        }

        public static void AddData<T>(T obj)
            where T : class
        {
            using (MyDBContext context = new MyDBContext())
            {
                context.Set<T>().Add(obj);
                context.SaveChanges();
            }
        }

        public static void RemoveData<T>(T obj)
            where T : class
        {
            using (MyDBContext context = new MyDBContext())
            {
                context.Set<T>().Remove(obj);
                context.SaveChanges();
            }
        }
        
    }
}
