using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.Configuration
{
    internal class RoleConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RoleConfig(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
