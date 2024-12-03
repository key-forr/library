using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Classes;
using library.Classes.ListManagers;

namespace library.Forms.User
{
    public partial class PersonalDataForm : Form
    {
        public PersonalDataForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            text_box_name.Text = UserSession.Name;
            text_box_surname.Text = UserSession.Surname;
            text_box_phone.Text = UserSession.Phone;
            text_box_login.Text = UserSession.Login;
            text_box_password.Text = UserSession.Password;
            text_box_role_name.Text = new RolesListManager().Roles.FirstOrDefault(g => g.Id == UserSession.RoleId)?.Name ?? "Роль не знайдено";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checked_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checked_show_password.Checked) text_box_password.PasswordChar = '\0';
            else text_box_password.PasswordChar = '●';
        }
    }
}
