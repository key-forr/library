using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class CustomerListManager
    {
        private List<CustomerConfig> customer;

        public CustomerListManager()
        {
            LoadCustomer();
        }

        public List<CustomerConfig> Customer
        {
            get { return customer; }
            private set { customer = value; }
        }

        public void LoadCustomer()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                customer = dataBaseHelper.LoadCustomer();
            }
        }
    }
}
