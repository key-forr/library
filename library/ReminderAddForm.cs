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
    public partial class ReminderAddForm : Form
    {
        private HomeForm _parentForm; // Посилання на головну форму
        private Panel _targetPanel;  // Панель, яку потрібно відновити

        public ReminderAddForm(HomeForm parentForm, Panel targetPanel)
        {
            InitializeComponent();
            _parentForm = parentForm;  // Зберігаємо посилання на головну форму
            _targetPanel = targetPanel; // Зберігаємо посилання на панель
        }

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parentForm.BackPanel(_targetPanel);
        }
    }
}
