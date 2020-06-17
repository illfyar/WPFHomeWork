using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork.EmployeeWindowNS
{
    public class VMEmployeeWindow : INotifyPropertyChanged
    {
        private Employee employee;
        public Employee Employee { get; set; }

        public VMEmployeeWindow(Employee employee)
        {
            Employee = employee;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
