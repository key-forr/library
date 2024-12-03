using library.Classes.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.ListManagers
{
    internal class RolesListManager
    {
        private List<RoleConfig> roles;

        public List<RoleConfig> Roles
        {
            get { return roles; }
            private set { roles = value; }
        }

        public RolesListManager()
        {
            LoadRoles();
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
