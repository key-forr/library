using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.Configuration
{
    public class ReminderConfig
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ReminderDate { get; set; }

        public ReminderConfig(int userId, string title, string description, DateTime? reminderDate)
        {
            UserId = userId;
            Title = title;
            Description = description;
            ReminderDate = reminderDate;
        }
    }
}
