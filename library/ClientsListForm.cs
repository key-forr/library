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
    public partial class ClientsListForm : Form
    {
        private ClientsListManager clientsListManager;
        private ClientsForm clientsForm;

        public ClientsListForm(ClientsForm clientsForm)
        {
            InitializeComponent();
            clientsListManager = new ClientsListManager();
            this.clientsForm = clientsForm;

            DisplayClients();
        }

        public void DisplayClients()
        {
            this.Controls.Clear();

            int x = 15;
            int y = 15;

            foreach (var client in clientsListManager.Clients)
            {
                ClientCardFactory clientCardFactory = new ClientCardFactory(clientsForm);
                var clientCard = clientCardFactory.CreateClientCard(client, x, y);

                this.Controls.Add(clientCard);

                y += clientCard.Height + 10;
            }
        }
    }
}
