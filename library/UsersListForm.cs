using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static library.BookCardFactory;

namespace library
{
    public partial class UsersListForm : Form
    {
        private UsersListManager usersListManager;
        private UsersForm usersForm;

        public UsersListForm(UsersForm usersForm)
        {
            InitializeComponent();
            usersListManager = new UsersListManager();
            this.usersForm = usersForm;

            DisplayUsers();
        }

        public void DisplayUsers()
        {
            this.Controls.Clear();

            int x = 15;
            int y = 15;

            foreach (var users in usersListManager.Users)
            {
                UserCardFactory userCardFactory = new UserCardFactory(usersForm);
                var userCard = userCardFactory.CreateUserCard(users, x, y);

                this.Controls.Add(userCard);

                y += userCard.Height + 10;
            }
        }
    }
}
