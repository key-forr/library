using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static library.BookCardFactory;

namespace library
{
    public partial class EmployeeListForm : Form
    {
        private EmployeeListManager employeeListManager;
        private EmployeeForm parentForm;

        public EmployeeListForm(EmployeeForm parentForm)
        {
            InitializeComponent();
            employeeListManager = new EmployeeListManager();
            this.parentForm = parentForm;
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            DisplayEmployee();
        }

        public void DisplayEmployee()
        {
            this.Controls.Clear();
            int x = 15;
            int y = 15;

            foreach (var employee in employeeListManager.Employee)
            {
                EmployeeCardFactory employeeCardFactory = new EmployeeCardFactory(parentForm);
                var employeeCard = employeeCardFactory.CreateEmployeeCard(employee, x, y);

                this.Controls.Add(employeeCard);

                y += employeeCard.Height + 10;
            }
        }


    }
}
