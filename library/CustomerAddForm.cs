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
    public partial class CustomerAddForm : Form
    {
        private CustomerForm customerForm;
        public CustomerAddForm(CustomerForm customerForm)
        {
            InitializeComponent();
            this.customerForm = customerForm;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_box_customer_name.Text)
              || string.IsNullOrWhiteSpace(text_box_customer_surname.Text)
              || string.IsNullOrWhiteSpace(text_box_customer_patronymic.Text)
              || string.IsNullOrWhiteSpace(text_box_customer_phone.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string name = text_box_customer_name.Text;
                string surname = text_box_customer_surname.Text;
                string patronymic = text_box_customer_patronymic.Text;
                string phone = text_box_customer_phone.Text;

                using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
                {
                    dataBaseHelper.AddCustomer(name, surname, patronymic, phone);
                }

                customerForm.UpdateCustomerListForm();

                text_box_customer_name.Text = "";
                text_box_customer_surname.Text = "";
                text_box_customer_patronymic.Text = "";
                text_box_customer_phone.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні нагадування: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
