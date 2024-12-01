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
    public partial class EmployeeEditForm : Form
    {
        private EmployeeForm employeeForm;
        public EmployeeConfig employeeConfig { get; set; }

        public EmployeeEditForm(EmployeeConfig employeeConfig, EmployeeForm employeeForm)
        {
            InitializeComponent();
            LoadEmployeeRole();
            this.employeeConfig = employeeConfig;

            text_box_name.Text = employeeConfig.Name;
            text_box_surname.Text = employeeConfig.Surname;
            text_box_phone.Text = employeeConfig.Phone;
            text_box_login.Text = employeeConfig.Login;
            text_box_password.Text = employeeConfig.Password;
            combo_box_role.Text = new RoleListManager().Roles.FirstOrDefault(g => g.Id == employeeConfig.RoleId)?.Name ?? "Роль не знайдено";
            this.employeeForm = employeeForm;
        }

        private void LoadEmployeeRole()
        {
            RoleListManager roleListManager = new RoleListManager();
            foreach (var genre in roleListManager.Roles)
            {
                combo_box_role.Items.Add(genre.Name);
            }
        }

        private void button_save_employee_Click(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                employeeConfig.Name = text_box_name.Text;
                employeeConfig.Surname = text_box_surname.Text;
                employeeConfig.Phone = text_box_phone.Text;
                employeeConfig.Login = text_box_login.Text;
                employeeConfig.Password = text_box_password.Text;
                employeeConfig.RoleId = new RoleListManager()
                     .Roles.FirstOrDefault(g => g.Name.Equals(combo_box_role.Text, 
                     StringComparison.OrdinalIgnoreCase))?.Id ?? 0;

                dbHelper.UpdateEmployee(employeeConfig);
            }

            employeeForm.UpdateEmployeeListForm();
        }
    }
}
