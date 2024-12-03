using library.Classes.CardFactory;
using library.Forms.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Classes.Utils;
using library.Classes.Configuration;

namespace library.Forms.Order
{
    public partial class OrderForm : Form
    {
        private OrderListForm orderListForm;
        private OrderMakeForm orderMakeForm;
        private OrderDetailsForm orderDetailsForm;

        public OrderForm()
        {
            InitializeComponent();

            orderListForm = new OrderListForm(this);
            PanelAndFormUtils.EmbedFormInPanel(orderListForm, panel_order_list);
        }

        public void OpenOrderDetails(OrderConfig orderConfig)
        {
            orderDetailsForm = new OrderDetailsForm(orderConfig, this);
            PanelAndFormUtils.EmbedFormInPanel(orderDetailsForm, panel_main);
        }

        private void button_make_order_navigation_Click(object sender, EventArgs e)
        {
            orderMakeForm = new OrderMakeForm();
            PanelAndFormUtils.EmbedFormInPanel(orderMakeForm, panel_main);
        }

        private void button_make_order_navigation_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_make_order_navigation, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_make_order_navigation_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_make_order_navigation, false, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
