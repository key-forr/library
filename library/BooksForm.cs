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
        private BookListManager bookListManager;
        private BookListForm bookListForm;

        public BooksForm()
        {
            InitializeComponent();
            bookListForm = new BookListForm(this);
            PanelAndFormManager.EmbedFormInPanel(bookListForm, panel_main);
        }

        public void UpdateBookListForm()
        {
            panel_main.Controls.Clear();

            bookListForm = new BookListForm(this);
            PanelAndFormManager.EmbedFormInPanel(bookListForm, panel_main);
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

        public void OpenBookDetails(BookConfig bookCardConfig)
        {
            var childForm = new BookManageForm(bookCardConfig, this);
            PanelAndFormManager.EmbedFormInPanel(childForm, panel);
        }

        private void button_list_book_Click(object sender, EventArgs e)
        {
            bookListForm = new BookListForm(this);
            PanelAndFormManager.EmbedFormInPanel(bookListForm, panel_main);
        }
        private void button_list_book_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_list_book, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_list_book_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_list_book, false, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_add_book_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add_book, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_add_book_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add_book, false, Color.FromArgb(36, 42, 78), 5);
        }
    }
}
