using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Library;
using WPFHomeWork.Data;

namespace WPFHomeWork.EmployeeWindowNS
{
    public class VMEmployeeWindow : INotifyPropertyChanged
    {
        EmployeeWindow EmployeeWindow { get; set; }
        public ObservableCollection<Position> Positions { get; set; }
        private Position selectedPosition;
        public Position SelectedPosition
        {
            get { return selectedPosition; }
            set
            {
                selectedPosition = value;
                OnPropertyChanged("SelectedPosition");
            }
        }
        public ObservableCollection<Department> Departments { get; set; }
        public Department SelectedDepartment { get; set; }
        Action UpdateInfo { get; set; }
        private Employee oldEmployee;
        private Employee newEmployee;
        public Employee NewEmployee
        {
            get { return newEmployee; }
            set
            {
                newEmployee = value;
                OnPropertyChanged("Employee");
            }
        }
        public VMEmployeeWindow(Employee employee, Action action, EmployeeWindow employeeWindow)
        {
            Positions = DataQueries.SelectPositions();
            Departments = DataQueries.ObservableCollectionDepartments();
            UpdateInfo = action;
            oldEmployee = employee;
            NewEmployee = new Employee();
            HandlingObjects.CopyValueProperties(NewEmployee, employee);
            SelectedPosition = Positions.Where(c => c.Id == employee.Position.Id).First();
            SelectedDepartment= Departments.Where(c => c.Id == employee.Department.Id).First();
            EmployeeWindow = employeeWindow;
        }

        #region Commands
        #region saveEmployee

        private MyCommands saveEmployee;
        public MyCommands SaveEmployee
        {
            get
            {
                return saveEmployee ?? (saveEmployee = new MyCommands(SaveEmployeeMethod));
            }
        }
        private void SaveEmployeeMethod(Object obj)
        {
            if (obj is DataRowView)
            {
                //HandlingObjects.CopyValueProperties<Employee>(oldEmployee, NewEmployee);
                UpdateInfo?.Invoke();
            }
        }
        #endregion
        #region SelectionChanged
        private MyCommands selectionChanged;
        public MyCommands SelectionChanged
        {
            get
            {
                return selectionChanged ?? (selectionChanged = new MyCommands(SelectionChangedMethod));
            }
        }
        private void SelectionChangedMethod(Object obj)
        {
            //if (obj is DataRowView)
            //{
            //    Employee.Position = (Position)obj;
            //}
            //if (obj is Department)
            //{
            //    Employee.Department = (Department)obj;
            //}
        }
        #endregion
        #region IsEdit
        private MyCommands isEdit;
        public MyCommands IsEdit
        {
            get
            {
                return isEdit ?? (isEdit = new MyCommands(IsEditMethod));
            }
        }
        private void IsEditMethod(Object obj)
        {
            //NewEmployee.BeginEdit();
            EmployeeWindow.EmployeeWindow1.Title += '*';
        }
        #endregion
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}