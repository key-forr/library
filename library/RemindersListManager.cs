using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class RemindersListManager
    {
        private List<ReminderConfig> reminders;

        public List<ReminderConfig> Reminders
        {
            get { return reminders; }
            private set { reminders = value; }
        }

        public RemindersListManager()
        {
            LoadReminder();
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
