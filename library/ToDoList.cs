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
        }

        public void HomeForm_Load()
        {
            dataTable.Columns.Add("Назва");
            dataTable.Columns.Add("Опис");

            viewHome.MyDataGridView.DataSource = dataTable;
        }

        public void SaveReminder(string title, string discription)
        {
            DataBaseHelper dataBaseHelper = new DataBaseHelper();
            dataBaseHelper.SaveReminder(title, discription, UserSession.CurrentUserLogin);
        }

        public DataTable MyDataTable
        {
            get { return dataTable; }
        }
    }
}
