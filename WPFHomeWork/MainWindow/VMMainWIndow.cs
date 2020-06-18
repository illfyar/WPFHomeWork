using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPFHomeWork.data;
using WPFHomeWork.EmployeeWindowNS;

namespace WPFHomeWork
{
    public class VMMainWIndow : INotifyPropertyChanged
    {
        public List<Employee> Employees { get; set; }       

        private Employee selectEmploee;
        public Employee SelectEmploee
        {
            get { return selectEmploee; }
            set
            {
                selectEmploee = value;
                OnPropertyChanged("SelectEmploee");
            }
        }
        private MyCommands mouseDoubleClick;
        public MyCommands MouseDoubleClick { 
            get {
                return mouseDoubleClick ?? (mouseDoubleClick = new MyCommands(DoubleClick));
            } }
        public VMMainWIndow()
        {
            this.Employees = Data.ListEmployes();            
        }
        private void DoubleClick(Object obj)//obj null, поэтому приходится использовать SelectEmploee
        {
            EmployeeWindow employeeWindow = new EmployeeWindow();
            VMEmployeeWindow vMEmployeeWindow = new VMEmployeeWindow(SelectEmploee);
            vMEmployeeWindow.Employee = SelectEmploee;
            employeeWindow.DataContext = vMEmployeeWindow;
            employeeWindow.Show();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
