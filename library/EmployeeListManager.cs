using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class EmployeeListManager
    {
        private List<EmployeeConfig> employee;

        public EmployeeListManager()
        {
            LoadEmployee();
        }

        public List<EmployeeConfig> Employee
        {
            get { return employee; }
            private set { employee = value; }
        }

        public void LoadEmployee()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                employee = dataBaseHelper.LoadEmployee();
            }
        }
    }
}
