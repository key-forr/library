using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public static class UserSession
    {
        public static string CurrentUserLogin { get; set; }
        public static int UserId { get; set; }
    }
}
