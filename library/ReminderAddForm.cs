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
        private HomeForm parentForm; 
        private Panel targetPanel; 
        private ToDoList toDoList;

        public ReminderAddForm(HomeForm parentForm, Panel targetPanel, ToDoList toDoList)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.targetPanel = targetPanel;
            this.toDoList = toDoList;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_box_title.Text) || string.IsNullOrWhiteSpace(text_box_description.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.toDoList.MyDataTable.Rows.Add(text_box_title.Text, text_box_description.Text);
            toDoList.SaveReminder(text_box_title.Text, text_box_description.Text);

            text_box_title.Text = "";
            text_box_description.Text = "";
        }

        private void butoon_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parentForm.BackPanel(this.targetPanel);
        }

        
    }
}
