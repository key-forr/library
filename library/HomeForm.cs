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

        private void button_storage_nav_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void button_add_book_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        private void text_box_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void reminder_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_personal_office_nav_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр форми
            ModalWindowUser windowUser = new ModalWindowUser
            {
                StartPosition = FormStartPosition.Manual // Вручну задаємо позицію
            };

            // Розрахунок позиції для розташування з правого верхнього кута
            windowUser.Location = new Point(
                this.Location.X + this.Width - windowUser.Width, // Правий край основної форми
                this.Location.Y // Верхній край основної форми
            );

            // Відображення форми
            windowUser.Show();
        }


        private void button_storage_nav_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.ForeColor = Color.FromArgb(154, 73, 229);
            }
        }

        private void button_storage_nav_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.ForeColor = Color.White;  // Відновлення кольору
            }
        }

    }
}
