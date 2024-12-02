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
    public partial class UserEditForm : Form
    {
        private UsersForm userForm;
        public UserConfig userConfig { get; set; }

        public UserEditForm(UserConfig userConfig, UsersForm userForm)
        {
            InitializeComponent();
            this.userConfig = userConfig;
            this.userForm = userForm;

            LoadUserRoles();
            LoadComponents();
        }

        private void LoadUserRoles()
        {
            RolesListManager roleListManager = new RolesListManager();
            foreach (var genre in roleListManager.Roles)
            {
                combo_box_roles.Items.Add(genre.Name);
            }
        }

        private void LoadComponents()
        {
            text_box_name.Text = userConfig.Name;
            text_box_surname.Text = userConfig.Surname;
            text_box_phone.Text = userConfig.Phone;
            text_box_login.Text = userConfig.Login;
            text_box_password.Text = userConfig.Password;
            combo_box_roles.Text = new RolesListManager().Roles.FirstOrDefault(g => g.Id == userConfig.RoleId)?.Name ?? "Роль не знайдено";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                userConfig.Name = text_box_name.Text;
                userConfig.Surname = text_box_surname.Text;
                userConfig.Phone = text_box_phone.Text;
                userConfig.Login = text_box_login.Text;
                userConfig.Password = text_box_password.Text;
                userConfig.RoleId = new RolesListManager()
                     .Roles.FirstOrDefault(g => g.Name.Equals(combo_box_roles.Text,
                     StringComparison.OrdinalIgnoreCase))?.Id ?? 0;

                dbHelper.UpdateUser(userConfig);
            }

            userForm.UpdateUserListForm();
        }

        private void button_save_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_save, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_save_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_save, false, Color.FromArgb(36, 42, 78), 5);
        }

        private void checked_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checked_show_password.Checked) text_box_password.PasswordChar = '\0';
            else text_box_password.PasswordChar = '●';
        }
    }
}
