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
        private ToDoList toDoList;

        public ReminderAddForm(ToDoList toDoList)
        {
            InitializeComponent();
            this.toDoList = toDoList;
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
                toDoList.SaveReminder(text_box_title.Text, text_box_description.Text);

                using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
                {
                    dataBaseHelper.LoadRemindersIntoDataGrid(new HomeForm(), UserSession.Id);
                }

                text_box_title.Text = "";
                text_box_description.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні нагадування: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
