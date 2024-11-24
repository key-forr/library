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
            InitializeDataGridView();
        }

        public void InitializeDataGridView()
        {
            if (viewHome.MyDataGridView.Columns.Count == 0)
            {
                viewHome.MyDataGridView.Columns.Add("Назва", "Назва");
                viewHome.MyDataGridView.Columns.Add("Опис", "Опис");

                // Налаштування зовнішнього вигляду
                viewHome.MyDataGridView.ColumnHeadersHeight = 40;
                viewHome.MyDataGridView.RowTemplate.Height = 40;
                viewHome.MyDataGridView.AllowUserToAddRows = false;
                viewHome.MyDataGridView.AllowUserToDeleteRows = false;
                viewHome.MyDataGridView.ReadOnly = true;

                foreach (DataGridViewColumn column in viewHome.MyDataGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        public void HomeForm_Load()
        {
            dataTable.Columns.Add("Назва");
            dataTable.Columns.Add("Опис");

            viewHome.MyDataGridView.DataSource = dataTable;
        }

        public void SaveReminder(string title, string description)
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                if (dataBaseHelper.SaveReminder(title, description, UserSession.CurrentUserLogin))
                {
                    // Оновлюємо дані після збереження
                    dataBaseHelper.LoadRemindersToDataGrid(viewHome, UserSession.UserId);
                }
            }
        }

        public DataTable MyDataTable
        {
            get { return dataTable; }
        }
    }
}
