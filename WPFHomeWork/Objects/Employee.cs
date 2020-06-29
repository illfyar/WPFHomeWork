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
    public class Employee : Person,IObjectDB
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public new int Id { get; set; }
        public Nullable<int> Person_id { get; set; }
        public Nullable<int> Position_id { get; set; }
        public Nullable<int> Department_id { get; set; }
        public Nullable<int> Salary_id { get; set; }
        [ForeignKey("Department_id")]
        public virtual Department Department { get; set; }
        [ForeignKey("Person_id")]
        public virtual Person Person { get; set; }
        [ForeignKey("Position_id")]
        public virtual Position Position { get; set; }
        [ForeignKey("Salary_id")]
        public virtual Salary Salary { get; set; }
        public Employee(int id, string firstName, string lastName, DateTime dateBorn, string gender,
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
        public void FillPerson(Person person)
        {
            Person_id = person.Id;
            Person = person;
        }
        public void FillPosition(Position position)
        {
            Position_id = position.Id;
            Position = position;
        }
        public void FillDepartment(Department department)
        {
            Department_id = department.Id;
            Department = department;
        }
        public void FillSalary(Salary salary)
        {
            Salary_id = salary.Id;
            Salary = salary;
        }
    }
}

