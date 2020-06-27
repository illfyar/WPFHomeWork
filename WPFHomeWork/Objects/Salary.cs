using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork
{
    [Table("Salary")]
    public class Salary
    {
        public Salary()
        {
            this.Employee = new HashSet<Employee>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Position_id { get; set; }
        public Nullable<int> Department_id { get; set; }
        public Nullable<decimal> Value { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
