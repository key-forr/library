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
    public partial class CustomerListForm : Form
    {
        private CustomerListManager customerListManager;
        private CustomerForm parentForm;

        public CustomerListForm(CustomerForm parentForm)
        {
            InitializeComponent();
            customerListManager = new CustomerListManager();
            this.parentForm = parentForm;
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            DisplayCustomer();
        }

        public void DisplayCustomer()
        {
            this.Controls.Clear();
            int x = 15;
            int y = 15;

            foreach (var customer in customerListManager.Customer)
            {
                CustomerCardFactory customerCardFactory = new CustomerCardFactory(parentForm);
                var customerCard = customerCardFactory.CreateCustomerCard(customer, x, y);

                this.Controls.Add(customerCard);

                y += customerCard.Height + 10;
            }
        }
    }
}
