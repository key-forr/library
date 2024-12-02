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
        private BooksListForm bookListForm;

        public BooksForm()
        {
            InitializeComponent();

            bookListForm = new BooksListForm(this);
            PanelAndFormManager.EmbedFormInPanel(bookListForm, panel_books_interaction);
        }

        public void UpdateBookListForm()
        {
            panel_books_interaction.Controls.Clear();

            bookListForm = new BooksListForm(this);
            PanelAndFormManager.EmbedFormInPanel(bookListForm, panel_books_interaction);
        }

        private void button_add_book_Click(object sender, EventArgs e)
        {
            AddBookForm childForm = new AddBookForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_books_interaction);
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

        public void OpenBookDetails(BookConfig bookConfig)
        {
            var childForm = new BookManageForm(bookConfig, this);
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_main);
        }

        private void button_list_book_Click(object sender, EventArgs e)
        {
            bookListForm = new BooksListForm(this);
            PanelAndFormManager.EmbedFormInPanel(bookListForm, panel_books_interaction);
        }

        private void button_books_list_navigation_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_books_list_navigation, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_books_list_navigation_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_books_list_navigation, false, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_add_book_navigation_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_books_list_navigation, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_add_book_navigation_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_books_list_navigation, false, Color.FromArgb(36, 42, 78), 5);
        }
    }
}
