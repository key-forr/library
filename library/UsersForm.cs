using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class UsersForm : Form
    {
        private UsersListForm userListForm;
        private UserAddForm userAddForm;
        private UserEditForm userEditForm;

        public UsersForm()
        {
            InitializeComponent();

            userListForm = new UsersListForm(this);
            PanelAndFormManager.EmbedFormInPanel(userListForm, panel_users_list);

            userAddForm = new UserAddForm(this);
            PanelAndFormManager.EmbedFormInPanel(userAddForm, panel_user_interaction);
        }

        public void OpenUserDetails(UserConfig userConfig)
        {
            userEditForm = new UserEditForm(userConfig, this);
            PanelAndFormManager.EmbedFormInPanel(userEditForm, panel_user_interaction);
        }

        public void UpdateUserListForm()
        {
            panel_users_list.Controls.Clear();

            userListForm = new UsersListForm(this);
            PanelAndFormManager.EmbedFormInPanel(userListForm, panel_users_list);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_user_navigation_Click(object sender, EventArgs e)
        {
            userAddForm = new UserAddForm(this);
            PanelAndFormManager.EmbedFormInPanel(userAddForm, panel_user_interaction);
        }

        private void button_add_user_navigation_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add_user_navigation, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_add_user_navigation_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add_user_navigation, false, Color.FromArgb(36, 42, 78), 5);
        }
    }
}
