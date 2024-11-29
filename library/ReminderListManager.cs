using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class ReminderListManager
    {
        private List<ReminderConfig> reminders;

        public ReminderListManager()
        {
            LoadReminder();
        }

        public List<ReminderConfig> Reminder
        {
            get { return reminders; }
            private set { reminders = value; }
        }

        public void LoadReminder()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                reminders = dataBaseHelper.LoadReminder();
            }
        }
    }
}
