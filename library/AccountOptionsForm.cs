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
    public partial class AccountOptionsForm : Form
    {
        private readonly HomeForm viewHome;
        public AccountOptionsForm(HomeForm homeForm)
        {
            InitializeComponent();
            label_phone.Text = UserSession.Phone;
            label_name_surname.Text = (UserSession.Name ?? "") + " " + (UserSession.Surname ?? "");
            this.viewHome = homeForm;
        }

        private void button_personal_data_Click(object sender, EventArgs e)
        {
            this.Close();
            var childForm = new PersonalDataForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, viewHome.MainPanel);
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

       

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
