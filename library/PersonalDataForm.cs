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
    public partial class PersonalDataForm : Form
    {
        public PersonalDataForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            text_box_login.Text = UserSession.Login;
            text_box_name.Text = UserSession.Name;
            text_box_surname.Text = UserSession.Surname;
            text_box_phone.Text = UserSession.Phone;
            text_box_role_name.Text = UserSession.RoleName;
            text_box_password.Text = UserSession.Password;
        }

        private void check_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show_pass.Checked) text_box_password.PasswordChar = '\0';
            else text_box_password.PasswordChar = '●';
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_box_phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
