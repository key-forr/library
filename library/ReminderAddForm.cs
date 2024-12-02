using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace library
{
    public partial class ReminderAddForm : Form
    {
        private HomeForm homeForm;

        public ReminderAddForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_box_title.Text) || string.IsNullOrWhiteSpace(text_box_description.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
                {
                    dataBaseHelper.AddReminder(text_box_title.Text, text_box_description.Text, date_picker.Value);
                }

                homeForm.UpdateReminderListForm();

                text_box_title.Text = "";
                text_box_description.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні нагадування: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_back_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateNavigationButton(button_back, false, Color.White, Color.FromArgb(22, 26, 50));
        }

        private void button_back_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateNavigationButton(button_back, false, Color.White, Color.FromArgb(22, 26, 50));
        }

        private void button_add_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateNavigationButton(button_add, true, Color.White, Color.FromArgb(22, 26, 50));
        }

        private void button_add_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateNavigationButton(button_add, false, Color.White, Color.FromArgb(22, 26, 50));
        }
    }
}
