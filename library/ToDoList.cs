using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace library
{
    public class ToDoList
    {
        private DataTable dataTable = new DataTable();
        private readonly HomeForm viewHome;

        public ToDoList(HomeForm view)
        {
            this.viewHome = view;
            viewHome.ConfigureReminderDataGrid();
        }

        public void SaveReminder(string title, string description)
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                if (dataBaseHelper.SaveReminder(title, description, UserSession.CurrentUserLogin))
                {
                    dataBaseHelper.LoadRemindersIntoDataGrid(viewHome, UserSession.UserId);
                }
            }
        }
    }
}
