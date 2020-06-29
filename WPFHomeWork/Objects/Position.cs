using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork
{
    [Table("Position")]
    public class Position : IObjectDB
    {
        public Position()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }

        
        public Position(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
