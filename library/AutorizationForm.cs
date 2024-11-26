using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace library
{
    public partial class AutorizationForm : Form
    {
        private readonly AuthorizationPresenter presenter;

        public AutorizationForm()
        {
            InitializeComponent();
            presenter = new AuthorizationPresenter(this);

            CenterContent();
            this.Resize += (s, e) => CenterContent();
        }

        private void CenterContent()
        {
            panel_signIn.Left = (this.ClientSize.Width - panel_signIn.Width) / 2;
            panel_signIn.Top = (this.ClientSize.Height - panel_signIn.Height) / 2;
            label_signIn.Left = (this.ClientSize.Width - label_signIn.Width) / 2;
            label_signIn.Top = (this.ClientSize.Height - panel_signIn.Height) / 4;
        }

        private void button_autorization(object sender, EventArgs e)
        {
            presenter.HandleLogin(text_box_login.Text, text_box_password.Text);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToHome()
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void check_box_checked_changed(object sender, EventArgs e)
        {
            if (check_show_pass.Checked) text_box_password.PasswordChar = '\0';
            else text_box_password.PasswordChar = '*';
        }

        private void button_submit_mouse_leave(object sender, EventArgs e)
        {
            button_submit.FlatAppearance.BorderSize = 0;
            button_submit.BackColor = Color.FromArgb(154, 73, 229);
        }

        private void button_submit_mouse_enter(object sender, EventArgs e)
        {
            button_submit.FlatStyle = FlatStyle.Flat;
            button_submit.BackColor = Color.FromArgb(22, 26, 50);
            button_submit.FlatAppearance.BorderColor = Color.FromArgb(154, 73, 229);
            button_submit.FlatAppearance.BorderSize = 2;
        }

        public string GetUserLogin()
        {
            return label_login.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else  this.WindowState = FormWindowState.Maximized; 
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
