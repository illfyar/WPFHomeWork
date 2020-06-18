using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork.EmployeeWindowNS
{
    public class VMEmployeeWindow : INotifyPropertyChanged
    {
        private Employee employee;
        public Employee Employee { get; set; }

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
                employee = (Employee)obj;
            }             
        }

        public VMEmployeeWindow(Employee employee)
        {
            Employee = employee;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
