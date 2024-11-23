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

        // Метод для завантаження форми на панель
        public void LoadFormOnPanel(Form childForm, Panel targetPanel)
        {
            // Зберігаємо стан панелі
            panelStateManager.SavePanelState(targetPanel);

            // Очищаємо панель
            targetPanel.Controls.Clear();

            // Налаштовуємо властивості форми
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Додаємо форму до панелі
            targetPanel.Controls.Add(childForm);
            childForm.Show();
        }

        // Метод для повернення попереднього стану панелі
        public void BackPanel(Panel targetPanel)
        {
            panelStateManager.RestorePanelState(targetPanel);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            // Передаємо головну форму і панель у конструктор ReminderAddForm
            ReminderAddForm childForm = new ReminderAddForm(this, guna2Panel4);

            // Завантажуємо форму на панель
            LoadFormOnPanel(childForm, guna2Panel4);
        }
    }
}
