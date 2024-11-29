using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace library
{
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();
            PanelAndFormManager.EmbedFormInPanel(new ReminderListForm(), panel_reminder_list);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
        }

        private void button_personal_office_nav_Click(object sender, EventArgs e)
        {
            AccountOptionsForm windowUser = new AccountOptionsForm(this);

            windowUser.Location = new Point(
                this.Location.X + this.Width - windowUser.Width, 
                this.Location.Y + 130
            );

            windowUser.ShowDialog();
        }

        public Panel MainPanel
        {
            get { return panel_main; }
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
            Application.Exit();
        }

        private void button_add_reminder_Click(object sender, EventArgs e)
        {
            var childForm = new ReminderAddForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_reminder);
        }

        private void button_books_navigation_Click(object sender, EventArgs e)
        {
            var childForm = new BooksForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_main);
        }

        private void button_employee_navigation_Click(object sender, EventArgs e)
        {
            var childForm = new EmployeeForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_main);
        }
    }
}
