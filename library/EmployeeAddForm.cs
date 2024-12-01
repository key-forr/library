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
    public partial class EmployeeAddForm : Form
    {
        private EmployeeForm employeeForm;

        public EmployeeAddForm(EmployeeForm employeeForm)
        {
            InitializeComponent();
            this.employeeForm = employeeForm;
        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeRole();
        }

        private void LoadEmployeeRole()
        {
            RoleListManager roleListManager = new RoleListManager();
            foreach (var genre in roleListManager.Roles)
            {
                combo_box_employee_role.Items.Add(genre.Name);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_box_employee_name.Text)
               || string.IsNullOrWhiteSpace(text_box_employee_surname.Text)
               || string.IsNullOrWhiteSpace(text_box_employee_phone.Text)
               || string.IsNullOrWhiteSpace(text_box_employee_login.Text)
               || string.IsNullOrWhiteSpace(text_box_employee_password.Text)
               || string.IsNullOrWhiteSpace(combo_box_employee_role.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string name = text_box_employee_name.Text;
                string surname = text_box_employee_surname.Text;
                string phone = text_box_employee_phone.Text;
                string login = text_box_employee_login.Text;
                string password = text_box_employee_password.Text;
                int roleId = combo_box_employee_role.SelectedIndex + 1;

                using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
                {
                    dataBaseHelper.AddUser(name, surname, phone, login,
                                            password, roleId);
                }

                employeeForm.UpdateEmployeeListForm();

                text_box_employee_name.Text = "";
                text_box_employee_surname.Text = "";
                text_box_employee_phone.Text = "";
                text_box_employee_login.Text = "";
                text_box_employee_password.Text = "";
                combo_box_employee_role.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні нагадування: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
