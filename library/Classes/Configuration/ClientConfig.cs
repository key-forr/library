using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.Configuration
{
    public class ClientConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }

        public ClientConfig(int id, string name, string surname, string patronymic, string phone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Phone = phone;
        }
    }
}
