using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork 
{
    [Table("Person")]
    public class Person : ICloneable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBorn { get; set; }
        public char Gender { get; set; }        

        ICollection<Employee> Employees { get; set; }
        public Person(int id, string firstName, string lastName, DateTime dateBorn, char gender)
        {
            FirstName = firstName;
            LastName = lastName;
            DateBorn = dateBorn;
            Gender = gender;
            Id = id;
        }
        public Person()
        {

        }
        public virtual object Clone()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}
