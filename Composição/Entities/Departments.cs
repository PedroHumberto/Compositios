using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composição.Entities
{
    class Departments
    {
        public string Name { get; set; }
        public Departments() 
        { 
        }

        public Departments(string name)
        {
            Name = name;
        }
    }
}
