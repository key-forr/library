using library.Classes.CardFactory;
using library.Classes.ListManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.Forms.Order
{
    public partial class OrderListForm : Form
    {
        private OrderListManager orderListManager;
        private OrderForm orderForm;

        public OrderListForm(OrderForm orderForm)
        {
            InitializeComponent();
            this.orderForm = orderForm;
            orderListManager = new OrderListManager();

            DisplayOrder();
        }

        public void DisplayOrder()
        {
            this.Controls.Clear();

            int x = 30;
            int y = 30;

            foreach (var order in orderListManager.Orders)
            {
                OrderCard orderCardFactory = new OrderCard(orderForm);
                var orderCard = orderCardFactory.CreateOrderCard(order, x, y);

                this.Controls.Add(orderCard);


                y += 200;
            }
        }
    }
}
