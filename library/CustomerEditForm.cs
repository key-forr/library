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
    public partial class CustomerEditForm : Form
    {
        private CustomerForm customerForm;
        public CustomerConfig customerConfig { get; set; }

        public CustomerEditForm(CustomerConfig customerConfig, CustomerForm customerForm)
        {
            InitializeComponent();
            this.customerConfig = customerConfig;

            text_box_name.Text = customerConfig.Name;
            text_box_surname.Text = customerConfig.Surname;
            text_box_patronymic.Text = customerConfig.Patronymic;
            text_box_phone.Text = customerConfig.Phone;
            this.customerForm = customerForm;
        }

        private void button_save_customer_Click(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                customerConfig.Name = text_box_name.Text;
                customerConfig.Surname = text_box_surname.Text;
                customerConfig.Patronymic = text_box_patronymic.Text;
                customerConfig.Phone = text_box_phone.Text;

                dbHelper.UpdateCustomer(customerConfig);
            }

            customerForm.UpdateCustomerListForm();
        }
    }
}
