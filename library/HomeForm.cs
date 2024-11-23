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

        public HomeForm()
        {
            InitializeComponent();
        }

        public void LoadFormOnPanel(Form childForm, Panel targetPanel)
        {
            panelStateManager.SavePanelState(targetPanel);

            targetPanel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            targetPanel.Controls.Add(childForm);
            childForm.Show();
        }

        public void BackPanel(Panel targetPanel)
        {
            panelStateManager.RestorePanelState(targetPanel);
        }

        
        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            ReminderAddForm childForm = new ReminderAddForm(this, guna2Panel4);
            LoadFormOnPanel(childForm, guna2Panel4);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EmployeeForm childForm = new EmployeeForm(this, guna2Panel5);
            LoadFormOnPanel(childForm, guna2Panel5);
        }
    }
}
