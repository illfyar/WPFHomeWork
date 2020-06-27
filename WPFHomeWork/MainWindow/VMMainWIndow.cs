﻿using Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows;

using WPFHomeWork.Data;
using WPFHomeWork.EmployeeWindowNS;

namespace WPFHomeWork
{
    public class VMMainWIndow : INotifyPropertyChanged
    {
        public ObservableCollection<Employee> Employees { get; set; }      
        public ObservableCollection<Department> Departments { get; set; }

        private MainWindow MainWindow { get; set; }
        private Employee selectEmployee;
        public Employee SelectEmployee
        {
            get { return selectEmployee; }
            set
            {
                selectEmployee = value;
                OnPropertyChanged("SelectEmployee");
            }
        }
        public VMMainWIndow(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            this.Employees = DataQueries.SelectEmployes();
        }
        #region Commands
        #region AddEmployee
        private MyCommands addEmployee;
        public MyCommands AddEmployee
        {
            get
            {
                return addEmployee ?? (addEmployee = new MyCommands(AddEmployeeHandler));
            }
        }
        private void AddEmployeeHandler(Object obj)
        {
            //Employee employee = new Employee();
            //Employees.Add(employee);
            //UpdateEmployee(employee);
        }
        #endregion
        #region RemoveEmployee
        private MyCommands removeEmployee;
        public MyCommands RemoveEmployee
        {
            get
            {
                return removeEmployee ?? (removeEmployee = new MyCommands(RemoveEmployeeHandler));
            }
        }
        private void RemoveEmployeeHandler(Object obj)
        {
            //Employees.Remove(SelectEmployee);            
        }
        #endregion
        #region MouseDoubleClick
        private MyCommands mouseDoubleClick;
        public MyCommands MouseDoubleClick { 
            get {
                return mouseDoubleClick ?? (mouseDoubleClick = new MyCommands(UpdateEmployee));
            } }
        private void UpdateEmployee(Object obj)
        {
            if (obj is Employee)
            {
                EmployeeWindow employeeWindow = new EmployeeWindow();
                VMEmployeeWindow vMEmployeeWindow =
                    new VMEmployeeWindow((Employee)obj, new Action(UpdateInfo), employeeWindow);
                employeeWindow.DataContext = vMEmployeeWindow;
                employeeWindow.Show();
            }
            else
            {
                MessageBox.Show("Значение неопределено");
            }

        }
        #endregion
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public void UpdateInfo()
        {
            MainWindow.EmployesTable.Items.Refresh();
        }
    }
}
