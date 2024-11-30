using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
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
            System.Windows.Forms.MessageBox.Show(message);
        }

        public void NavigateToHome()
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void button_collapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_window_state_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            presenter.HandleLogin(text_box_login.Text, text_box_password.Text);
        }

        private void button_submit_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_submit, true, Color.FromArgb(154, 73, 229), 10);
        }

        private void button_submit_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_submit, false, Color.FromArgb(154, 73, 229), 10);
        }

        private void checked_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checked_show_password.Checked) text_box_password.PasswordChar = '\0';
            else text_box_password.PasswordChar = '●';
        }
    }
}
