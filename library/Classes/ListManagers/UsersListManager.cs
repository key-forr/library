using library.Classes.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.ListManagers
{
    internal class UsersListManager
    {
        private List<UserConfig> users;

        public UsersListManager()
        {
            LoadUsers();
        }

        public List<UserConfig> Users
        {
            get { return users; }
            private set { users = value; }
        }

        public void LoadUsers()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                users = dataBaseHelper.LoadUsers();
            }
        }
    }
}
