using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.Configuration
{
    public class OrderConfig
    {
        public int OrderID { get; set; }

        public OrderConfig(int orderID)
        {
            OrderID = orderID;
        }
    }
}
