using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.Classes.Configuration;


namespace library.Classes.ListManagers
{
    internal class OrderListManager
    {

        private List<OrderConfig> orders;

        public OrderListManager()
        {
            LoadOrders();
        }

        public List<OrderConfig> Orders
        {
            get { return orders; }
            private set { orders = value; }
        }

        public void LoadOrders()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                orders = dataBaseHelper.LoadOrders();
            }
        }
    }
}
