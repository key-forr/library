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
    public partial class ReminderListForm : Form
    {
        private ReminderListManager reminderListManager;

        public ReminderListForm()
        {
            InitializeComponent();
            reminderListManager = new ReminderListManager();    
        }

        private void ReminderListForm_Load(object sender, EventArgs e)
        {
            DisplayReminder();
        }

        public void DisplayReminder()
        {
            this.Controls.Clear(); 
            int x = 15; 
            int y = 15;

            foreach (var reminder in reminderListManager.Reminder)
            {
                ReminderCardFactory reminderCardFactory = new ReminderCardFactory(this);
                var reminderCard = reminderCardFactory.CreateReminderCard(reminder, x, y);

                this.Controls.Add(reminderCard);

                y += reminderCard.Height + 10; 
            }
        }
    }
}
