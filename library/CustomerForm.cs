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
    public partial class CustomerForm : Form
    {
        private CustomerListForm customerListForm;
        private CustomerAddForm customerAddForm;
        private CustomerEditForm customerEditForm;  

        public CustomerForm()
        {
            InitializeComponent();
            customerAddForm = new CustomerAddForm(this);
            PanelAndFormManager.EmbedFormInPanel(customerAddForm, panel_add_customer);

            customerListForm = new CustomerListForm(this);
            PanelAndFormManager.EmbedFormInPanel(customerListForm, panel_client_interaction);
        }

        public void UpdateCustomerListForm()
        {
            panel_client_interaction.Controls.Clear();

            customerListForm = new CustomerListForm(this);
            PanelAndFormManager.EmbedFormInPanel(customerListForm, panel_client_interaction);
        }

        public void OpenCustomerDetails(CustomerConfig customerConfig)
        {
            panel_add_customer.Controls.Clear();

            customerEditForm = new CustomerEditForm(customerConfig, this);
            PanelAndFormManager.EmbedFormInPanel(customerEditForm, panel_add_customer);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_customer_Click(object sender, EventArgs e)
        {
            customerAddForm = new CustomerAddForm(this);
            PanelAndFormManager.EmbedFormInPanel(customerAddForm, panel_add_customer);
        }
    }
}
