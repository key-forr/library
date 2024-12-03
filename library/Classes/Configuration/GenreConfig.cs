using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.Configuration
{
    internal class GenreConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public GenreConfig(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
