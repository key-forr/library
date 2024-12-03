using library.Classes.Utils;
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

namespace library.Forms.Client
{
    public partial class ClientsForm : Form
    {
        private ClientsListForm clientsListForm;
        private ClientAddForm clientAddForm;
        private ClientEditForm clientEditForm;  

        public ClientsForm()
        {
            InitializeComponent();

            clientAddForm = new ClientAddForm(this);
            PanelAndFormUtils.EmbedFormInPanel(clientAddForm, panel_client_interaction);

            clientsListForm = new ClientsListForm(this);
            PanelAndFormUtils.EmbedFormInPanel(clientsListForm, panel_clients_list);
        }

        public void UpdateClientsListForm()
        {
            panel_clients_list.Controls.Clear();

            clientsListForm = new ClientsListForm(this);
            PanelAndFormUtils.EmbedFormInPanel(clientsListForm, panel_clients_list);
        }

        public void OpenClientDetails(ClientConfig clientConfig)
        {
            panel_client_interaction.Controls.Clear();

            clientEditForm = new ClientEditForm(clientConfig, this);
            PanelAndFormUtils.EmbedFormInPanel(clientEditForm, panel_client_interaction);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            clientAddForm = new ClientAddForm(this);
            PanelAndFormUtils.EmbedFormInPanel(clientAddForm, panel_client_interaction);
        }

        private void button_add_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_add_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add, false, Color.FromArgb(36, 42, 78), 5);
        }
    }
}
