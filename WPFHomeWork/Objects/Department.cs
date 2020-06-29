using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork
{
    [Table("Department")]
    public class Department : IObjectDB
    {
        public Department()
        {
            this.Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Parent_id { get; set; }
        [ForeignKey("Parent_id")]
        public virtual Department Parent { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public Department(string name)
        {
            Name = name;
        }
        public Department(int id, string name, Department parent) : this(name)
        {
            Id = id;
            Parent = parent;            
        }
    }
}
