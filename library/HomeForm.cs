using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace library
{
    public partial class HomeForm : Form
    {
        private readonly HomeFormPresenter presenter;

        public HomeForm()
        {
            InitializeComponent();
            presenter = new HomeFormPresenter(this);

            RefreshRemindersList();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ConfigureReminderDataGrid();
        }

        private void RefreshRemindersList()
        {
            using (var dataBaseHelper = new DataBaseHelper())
            {
                dataBaseHelper.LoadRemindersIntoDataGrid(this, UserSession.Id);
            }
        }

        public void UpdateReminderDataGrid(DataTable reminderData)
        {
            reminder_view.SuspendLayout();

            reminder_view.DataSource = null;
            reminder_view.Columns.Clear();

            reminder_view.DataSource = reminderData;
            ConfigureReminderDataGrid();

            reminder_view.ResumeLayout();
        }

        public void ConfigureReminderDataGrid()
        {
            if (reminder_view.Columns.Count > 0)
            {
                if (reminder_view.Columns.Contains("title"))
                    reminder_view.Columns["title"].HeaderText = "Заголовок";

                if (reminder_view.Columns.Contains("description"))
                    reminder_view.Columns["description"].HeaderText = "Опис";
            }
        }

        private void button_employee_nav_Click(object sender, EventArgs e)
        {
            var childForm = new EmployeeForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_main);
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
            var childForm = new ReminderAddForm(presenter.ToDoList);
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_reminder);
        }

      
    }
}
