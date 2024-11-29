using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class RoleListManager
    {
        private List<RolesConfig> roles;

        public RoleListManager()
        {
            LoadRoles();
        }

        public List<RolesConfig> Roles
        {
            get { return roles; }
            private set { roles = value; }
        }

        public void LoadRoles()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                roles = dataBaseHelper.LoadRoles();
            }
        }
    }
}
