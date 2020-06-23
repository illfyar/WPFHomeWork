using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Library;
using WPFHomeWork.data;

namespace WPFHomeWork.EmployeeWindowNS
{
    public class VMEmployeeWindow : INotifyPropertyChanged
    {
<<<<<<< Updated upstream
        EmployeeWindow EmployeeWindow { get; set; }
        public ObservableCollection<Position> Positions { get; set; }
        private Position selectedPosition;
        public Position SelectedPosition { get { return selectedPosition; }
            set { selectedPosition = value;
                OnPropertyChanged("SelectedPosition");
            } }
        public ObservableCollection<Department> Departments { get; set; }
        public Department SelectedDepartment { get; set; }
        Action UpdateInfo { get; set; }
        private Employee oldEmployee;
        private Employee newEmployee;
        public Employee NewEmployee { get { return newEmployee; }
            set 
            { 
                newEmployee = value;
                OnPropertyChanged("NewEmployee");
            } }
        #region Commands
        #region saveEmployee
=======
        private Employee newEmployee;
        public Employee NewEmployee { 
            get { return newEmployee; } 
            set { newEmployee = value; OnPropertyChanged("Employee"); } }
        private Employee oldEmployee;

>>>>>>> Stashed changes
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
            if (obj is Employee)
            {
<<<<<<< Updated upstream
                HandlingObjects.CopyValueProperties<Employee>(oldEmployee, NewEmployee);
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
            if (obj is Position)
            {
                NewEmployee.Position = (Position)obj;
            }
            if (obj is Department)
            {
                NewEmployee.Department = (Department)obj;
            }
        }        
        #endregion
        #endregion

        public VMEmployeeWindow(Employee employee, Action action, EmployeeWindow employeeWindow)
        {
            Positions = DataQueries.ObservableCollectionPositions();
            Departments = DataQueries.ObservableCollectionDepartments();
            UpdateInfo = action;
            oldEmployee = employee;
            NewEmployee = (Employee) employee.Clone();
            SelectedPosition = employee.Position;
            SelectedDepartment = employee.Department;
            EmployeeWindow = employeeWindow;
=======
                oldEmployee = (Employee)obj;
            }             
        }
        public VMEmployeeWindow(Employee employee)
        {
            //oldEmployee = employee;
            NewEmployee = employee;
                //(Employee)employee.Clone();
>>>>>>> Stashed changes
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
