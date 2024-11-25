using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    internal class HomeFormPresenter
    {
        private readonly HomeForm viewHome;
        private ToDoList toDoList;

        public HomeFormPresenter(HomeForm viewHome)
        {
            toDoList = new ToDoList(viewHome);
            this.viewHome = viewHome;
        }

        public ToDoList ToDoList
        {
            get { return toDoList; }
        }
    }
}
