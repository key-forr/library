using library.Forms.Order;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Classes.Configuration;

namespace library.Classes.CardFactory
{
    internal class OrderCard
    {
        private OrderForm orderForm;

        public OrderCard(OrderForm orderForm)
        {
            this.orderForm = orderForm;
        }

        public Guna.UI2.WinForms.Guna2GroupBox CreateOrderCard(OrderConfig orderConfig, int x, int y)
        {
            var group_box = new Guna.UI2.WinForms.Guna2GroupBox()
            {
                BorderColor = Color.FromArgb(22, 26, 50),
                BorderRadius = 20,
                BorderThickness = 0,
                CustomBorderThickness = new Padding(0),
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(125, 137, 149),
                Location = new Point(x, y),
                Name = "group_box",
                Size = new Size(440, 120),
                Tag = false
            };

            var text_box_order_number = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                DefaultText = $"Номер замовлення: {orderConfig.OrderID}",
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                Multiline = true,
                ReadOnly = true,
                Location = new Point(10, 10),
                Padding = new Padding(10, 5, 10, 5),
                Size = new Size(300, 50),
                TextAlign = HorizontalAlignment.Left
            };

           

            EventHandler hoverEffect = (sender, e) =>
            {
                group_box.BorderThickness = 3;
                group_box.BorderColor = Color.FromArgb(72, 169, 118);
            };

            EventHandler resetEffect = (sender, e) =>
            {
                group_box.BorderThickness = 0;
                group_box.BorderColor = Color.FromArgb(22, 26, 50);
            };

            EventHandler openDetails = (sender, e) =>
            {
                orderForm.OpenOrderDetails(orderConfig);
            };

            group_box.MouseEnter += hoverEffect;
            group_box.MouseLeave += resetEffect;
            group_box.DoubleClick += openDetails;

            group_box.Controls.Add(text_box_order_number);

            return group_box;
        }
    }
}
