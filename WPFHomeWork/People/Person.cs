using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork 
{
    public class Person : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBorn { get; set; }
        public char Gender { get; set; }

        public int Id { get; set; }
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
