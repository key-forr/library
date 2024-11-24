using Guna.UI2.WinForms;
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
    public partial class HomeForm : Form
    {
        private PanelStateManager panelStateManager = new PanelStateManager();
        private readonly HomeFormPresenter presenter;

        public HomeForm()
        {
            InitializeComponent();
            presenter = new HomeFormPresenter(this);

            LoadAllPanels();
            LoadReminders();
        }

        private void LoadAllPanels()
        {
            panelStateManager.SavePanelState(guna2Panel1);
            panelStateManager.SavePanelState(guna2Panel2);
            panelStateManager.SavePanelState(guna2Panel3);
            panelStateManager.SavePanelState(panel_reminder);
            panelStateManager.SavePanelState(panel_main);
        }

        public void BackPanel(Panel targetPanel)
        {
            panelStateManager.RestorePanelState(targetPanel);
        }

        public void LoadFormOnPanel(Form childForm, Panel targetPanel)
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

            targetPanel.SizeChanged += (sender, e) =>
            {
                childForm.Size = targetPanel.Size;
            };

            targetPanel.Controls.Add(childForm);

            childForm.Show();
        }
      
        private void HomeForm_Load(object sender, EventArgs e)
        {
            presenter.MyToDoList.InitializeDataGridView();
        }

        private void LoadReminders()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                dataBaseHelper.LoadRemindersToDataGrid(this, UserSession.UserId);
            }
        }
        public DataGridView MyDataGridView
        {
            get { return reminder_view; }
        }

        private void button_employee_nav_Click(object sender, EventArgs e)
        {
            EmployeeForm childForm = new EmployeeForm(this, panel_main);
            LoadFormOnPanel(childForm, panel_main);
        }

        private void button_more_reminder_Click(object sender, EventArgs e)
        {
            ReminderAddForm childForm = new ReminderAddForm(this, panel_reminder, presenter.MyToDoList);
            LoadFormOnPanel(childForm, panel_reminder);
        }

       
    }
}
