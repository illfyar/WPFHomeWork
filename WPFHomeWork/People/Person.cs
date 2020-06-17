using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBorn { get; set; }
        public Person(string firstName, string lastName, DateTime dateBorn)
        {
            FirstName = firstName;
            LastName = lastName;
            DateBorn = dateBorn;
        }
    }
}
