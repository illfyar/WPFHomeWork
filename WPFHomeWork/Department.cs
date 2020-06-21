using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork
{
    public class Department
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public Department Parent { get; set; }
        public List<Department> Subsidiary { get; set; } = new List<Department>();

        public Department(string name)
        {
            Name = name;
        }

        public Department(string name, Department parent, List<Department> subsidiary) : this(name)
        {
            Parent = parent;
            Subsidiary = subsidiary;
        }
    }
}
