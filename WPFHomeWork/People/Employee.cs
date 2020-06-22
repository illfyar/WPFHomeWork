using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork
{
    public class Employee : Person
    {
        public Position Position { get; set; }
        public Department Department { get; set; }
        public Employee(string firstName, string lastName, DateTime dateBorn, char gender) : base(firstName, lastName, dateBorn, gender)
        {
        }
        public Employee()
        {
        }
        public override object Clone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
}

