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
    public partial class UserAddForm : Form
    {
        private UsersForm usersForm;

        public UserAddForm(UsersForm usersForm)
        {
            InitializeComponent();
            this.usersForm = usersForm;

            LoadRoles();
        }

        private void LoadRoles()
        {
            RolesListManager rolesListManager = new RolesListManager();
            foreach (var role in rolesListManager.Roles)
            {
                combo_box_roles.Items.Add(role.Name);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_box_name.Text)
               || string.IsNullOrWhiteSpace(text_box_surname.Text)
               || string.IsNullOrWhiteSpace(text_box_phone.Text)
               || string.IsNullOrWhiteSpace(text_box_login.Text)
               || string.IsNullOrWhiteSpace(text_box_password.Text)
               || string.IsNullOrWhiteSpace(combo_box_roles.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string name = text_box_name.Text;
                string surname = text_box_surname.Text;
                string phone = text_box_phone.Text;
                string login = text_box_login.Text;
                string password = text_box_password.Text;
                int roleId = combo_box_roles.SelectedIndex + 1;

                using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
                {
                    dataBaseHelper.AddUser(name, surname, phone, login,
                                            password, roleId);
                }

                usersForm.UpdateUserListForm();

                text_box_name.Text = "";
                text_box_surname.Text = "";
                text_box_phone.Text = "";
                text_box_login.Text = "";
                text_box_password.Text = "";
                combo_box_roles.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні користувача: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_add_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add, false, Color.FromArgb(36, 42, 78), 5);
        }

        private void checked_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checked_show_password.Checked) text_box_password.PasswordChar = '\0';
            else text_box_password.PasswordChar = '●';
        }
    }
}
