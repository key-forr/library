using Guna.UI2.WinForms.Internal;
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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            PanelAndFormManager.EmbedFormInPanel(new BookListForm(this), panel_main);
        }

        private void button_add_book_Click(object sender, EventArgs e)
        {
            AddBookForm childForm = new AddBookForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_main);
        }

        private void text_box_search_TextChanged(object sender, EventArgs e)
        {
            text_box_search.PlaceholderText = "Введіть назву книги";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_box_search_Enter(object sender, EventArgs e)
        {
            text_box_search.PlaceholderText = string.Empty;
        }

        public void OpenBookDetatils(BookCardConfig bookCardConfig)
        {
            var childForm = new BookDetailsForm(bookCardConfig);
            PanelAndFormManager.EmbedFormInPanel(childForm, panel);
        }
    }
}
