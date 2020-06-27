using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork
{
    [Table("Employee")]
    public class Employee : Person
    {
        public int Id { get; set; }
        public Nullable<int> Person_id { get; set; }
        public Nullable<int> Position_id { get; set; }
        public Nullable<int> Department_id { get; set; }
        public Nullable<int> Salary_id { get; set; }

        public virtual Department Department { get; set; }
        public virtual Person Person { get; set; }
        public virtual Position Position { get; set; }
        public virtual Salary Salary { get; set; }
        public Employee(int id, string firstName, string lastName, DateTime dateBorn, char gender,
            Position position, Department department, Salary salary) : base(id, firstName, lastName, dateBorn, gender)
        {
            Position = position;
            Department = department;
            Salary = salary;
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

