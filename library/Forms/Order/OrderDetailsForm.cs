using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Classes.Configuration;

namespace library.Forms.Order
{
    public partial class OrderDetailsForm : Form
    {
        private OrderConfig config;
        private OrderForm OrderForm;

        public OrderDetailsForm(OrderConfig config, OrderForm orderForm)
        {
            InitializeComponent();
            this.config = config;
            this.OrderForm = orderForm;
        }
    }
}
