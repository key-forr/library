﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Classes.ListManagers;
using library.Classes.CardFactory;

namespace library.Forms.Reminder
{
    public partial class RemindersListForm : Form
    {
        private RemindersListManager reminderListManager;

        public RemindersListForm()
        {
            InitializeComponent();
            reminderListManager = new RemindersListManager();

            DisplayReminder();
        }

        public void DisplayReminder()
        {
            this.Controls.Clear(); 

            int x = 15; 
            int y = 15;

            foreach (var reminder in reminderListManager.Reminders)
            {
                ReminderCard reminderCardFactory = new ReminderCard(this);
                var reminderCard = reminderCardFactory.CreateReminderCard(reminder, x, y);

                this.Controls.Add(reminderCard);

                y += reminderCard.Height + 10; 
            }
        }
    }
}