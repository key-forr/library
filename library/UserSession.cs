using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public static class UserSession
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string Phone { get; set; }
        public static string Password { get; set; }
        public static string Login { get; set; }
        public static int RoleId { get; set; }
    }
}
