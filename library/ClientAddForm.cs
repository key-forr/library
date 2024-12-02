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
    public partial class ClientAddForm : Form
    {
        private ClientsForm clientsForm;

        public ClientAddForm(ClientsForm clientsForm)
        {
            InitializeComponent();
            this.clientsForm = clientsForm;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_box_name.Text)
              || string.IsNullOrWhiteSpace(text_box_surname.Text)
              || string.IsNullOrWhiteSpace(text_box_patronymic.Text)
              || string.IsNullOrWhiteSpace(text_box_phone.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string name = text_box_name.Text;
                string surname = text_box_surname.Text;
                string patronymic = text_box_patronymic.Text;
                string phone = text_box_phone.Text;

                using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
                {
                    dataBaseHelper.AddClient(name, surname, patronymic, phone);
                }

                clientsForm.UpdateClientsListForm();

                text_box_name.Text = "";
                text_box_surname.Text = "";
                text_box_patronymic.Text = "";
                text_box_phone.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні нагадування: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
