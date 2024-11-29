using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace library
{
    public partial class HomeForm : Form
    {
        private ReminderListForm reminderListForm;
        private BooksForm booksForm;
        private EmployeeForm employeeForm;
        private ReminderAddForm reminderAddForm;

        public HomeForm()
        {
            InitializeComponent();
            reminderListForm = new ReminderListForm();
            PanelAndFormManager.EmbedFormInPanel(reminderListForm, panel_reminder_list);
        }

        public void UpdateReminderListForm()
        {
            panel_reminder_list.Controls.Clear();

            reminderListForm = new ReminderListForm();
            PanelAndFormManager.EmbedFormInPanel(reminderListForm, panel_reminder_list);
        }

        public Panel MainPanel
        {
            get { return panel_main; }
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
            ReminderAddForm childForm = new ReminderAddForm(this);
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_reminder);
        }

        private void button_books_navigation_Click(object sender, EventArgs e)
        {
            BooksForm childForm = new BooksForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_main);
        }

        private void button_employee_navigation_Click(object sender, EventArgs e)
        {
            EmployeeForm childForm = new EmployeeForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_main);
        }
    }
}
