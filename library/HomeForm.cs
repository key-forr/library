using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using MySqlX.XDevAPI.Common;
using System;
using System.Data;
using System.Windows.Forms;

namespace library
{
    public partial class HomeForm : Form
    {
        private PanelStateManager panelStateManager = new PanelStateManager();
        private readonly HomeFormPresenter presenter;

        public HomeForm()
        {
            InitializeComponent();
            presenter = new HomeFormPresenter(this);
            InitializePanels();
            RefreshRemindersList();
        }

        private void InitializePanels()
        {
            panelStateManager.SavePanelState(guna2Panel1);
            panelStateManager.SavePanelState(guna2Panel2);
            panelStateManager.SavePanelState(guna2Panel3);
            panelStateManager.SavePanelState(panel_reminder);
            panelStateManager.SavePanelState(panel_main);
        }

        public void RestorePreviousPanel(Panel targetPanel)
        {
            panelStateManager.RestorePanelState(targetPanel);
        }

        public void EmbedFormInPanel(Form childForm, Panel targetPanel)
        {
            targetPanel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = targetPanel.Size;
            childForm.AutoScaleMode = AutoScaleMode.None;
            childForm.AutoSize = true;
            childForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            childForm.AutoScroll = false;

            targetPanel.SizeChanged += (sender, e) => childForm.Size = targetPanel.Size;

            targetPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void RefreshRemindersList()
        {
            using (var dataBaseHelper = new DataBaseHelper())
            {
                dataBaseHelper.LoadRemindersIntoDataGrid(this, UserSession.UserId);
            }
        }
       
        public DataGridView DataGridToDoList
        {
            get { return reminder_view; }
        }

        private void button_employee_nav_Click(object sender, EventArgs e)
        {
            var childForm = new EmployeeForm(this, panel_main);
            EmbedFormInPanel(childForm, panel_main);
        }

        private void button_trash_reminder_Click(object sender, EventArgs e)
        {
            
        }

        private void button_add_reminder_Click(object sender, EventArgs e)
        {
            var childForm = new ReminderAddForm(this, panel_reminder, presenter.ToDoList);
            EmbedFormInPanel(childForm, panel_reminder);
        }
    }
}