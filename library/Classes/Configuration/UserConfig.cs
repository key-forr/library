using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.Configuration
{
    public class UserConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public UserConfig(int id, string name, string surname, string phone, string login, string password, int roleId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Login = login;
            Password = password;
            RoleId = roleId;
        }
    }
}
