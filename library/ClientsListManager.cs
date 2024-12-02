using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class ClientsListManager
    {
        private List<ClientConfig> clients;

        public ClientsListManager()
        {
            LoadClients();
        }

        public List<ClientConfig> Clients
        {
            get { return clients; }
            private set { clients = value; }
        }

        public void LoadClients()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                clients = dataBaseHelper.LoadClients();
            }
        }
    }
}
