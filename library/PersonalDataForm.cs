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
        private HomeForm parentForm;
        private Panel targetPanel;
        private readonly PersonalDataPresenter presenter;

        public PersonalDataForm(HomeForm parentForm, Panel targetPanel)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.targetPanel = targetPanel;
            LoadUser();

        }

        public void LoadUser()
        {
            guna2TextBox4.Text = UserSession.CurrentUserLogin;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parentForm.RestorePreviousPanel(this.targetPanel);
        }

        private void check_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show_pass.Checked) guna2TextBox5.PasswordChar = '\0';
            else guna2TextBox5.PasswordChar = '*';
        }
    }
}
