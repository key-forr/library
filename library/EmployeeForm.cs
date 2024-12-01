using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class EmployeeForm : Form
    {
        private EmployeeListForm employeeForm;
        private EmployeeAddForm employeeAddForm;
        private EmployeeEditForm employeeEditForm;

        public EmployeeForm()
        {
            InitializeComponent();
            employeeForm = new EmployeeListForm(this);
            PanelAndFormManager.EmbedFormInPanel(employeeForm, panel_employee_interaction);

            employeeAddForm = new EmployeeAddForm(this);
            PanelAndFormManager.EmbedFormInPanel(employeeAddForm, panel_employee_info);
        }

        public void OpenEmployeeDetails(EmployeeConfig employeeConfig)
        {
            employeeEditForm = new EmployeeEditForm(employeeConfig, this);
            PanelAndFormManager.EmbedFormInPanel(employeeEditForm, panel_employee_info);
        }

        public void UpdateEmployeeListForm()
        {
            panel_employee_interaction.Controls.Clear();

            employeeForm = new EmployeeListForm(this);
            PanelAndFormManager.EmbedFormInPanel(employeeForm, panel_employee_interaction);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_employee_Click(object sender, EventArgs e)
        {
            employeeAddForm = new EmployeeAddForm(this);
            PanelAndFormManager.EmbedFormInPanel(employeeAddForm, panel_employee_info);
        }
    }
}
