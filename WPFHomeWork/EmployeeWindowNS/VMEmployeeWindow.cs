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
        public DataTable Positions { get; set; }
        private DataRowView selectedPosition;
        public DataRowView SelectedPosition { get { return selectedPosition; }
            set { selectedPosition = value;
                OnPropertyChanged("SelectedPosition");
            } }
        public DataTable Departments { get; set; }
        public DataRowView SelectedDepartment { get; set; }
        Action UpdateInfo { get; set; }
        private DataRowView employee;
        public DataRowView Employee { get { return employee; }
            set 
            { 
                employee = value;
                OnPropertyChanged("Employee");
            } }        
        public VMEmployeeWindow(DataRowView employee, Action action, EmployeeWindow employeeWindow)
        {
            Positions = DataQueries.SelectPositions();
            Departments = DataQueries.ObservableCollectionDepartments();
            UpdateInfo = action;
            this.Employee = employee;
            DataRow dataRow = Positions.Rows.Find(employee.Row.Field<int>("Position_Id"));
            SelectedPosition = Positions.DefaultView[Positions.Rows.IndexOf(dataRow)];
            dataRow = Departments.Rows.Find(employee.Row.Field<int>("Department_Id"));
            SelectedDepartment = Departments.DefaultView[Departments.Rows.IndexOf(dataRow)];
            EmployeeWindow = employeeWindow;
            if (Employee.IsEdit)
            {
                
            }            
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
            Employee.BeginEdit();
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
