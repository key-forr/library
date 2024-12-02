using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class ClientEditForm : Form
    {
        private ClientsForm clientsForm;
        public ClientConfig clientConfig { get; set; }

        public ClientEditForm(ClientConfig clientConfig, ClientsForm clientsForm)
        {
            InitializeComponent();
            this.clientConfig = clientConfig;

            text_box_name.Text = clientConfig.Name;
            text_box_surname.Text = clientConfig.Surname;
            text_box_patronymic.Text = clientConfig.Patronymic;
            text_box_phone.Text = clientConfig.Phone;
            this.clientsForm = clientsForm;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                clientConfig.Name = text_box_name.Text;
                clientConfig.Surname = text_box_surname.Text;
                clientConfig.Patronymic = text_box_patronymic.Text;
                clientConfig.Phone = text_box_phone.Text;

                dbHelper.UpdateClient(clientConfig);
            }

            clientsForm.UpdateClientsListForm();
        }

        private void button_save_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_save, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_save_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_save, false, Color.FromArgb(36, 42, 78), 5);
        }
    }
}
