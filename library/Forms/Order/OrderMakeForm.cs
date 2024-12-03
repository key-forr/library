using library.Classes.CardFactory;
using library.Classes.ListManagers;
using library.Classes.Configuration;
using library.Classes.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace library.Forms.Order
{
    public partial class OrderMakeForm : Form
    {
        private BookListInOrder bookListInOrder;
        private BooksListManager booksListManager;

        public OrderMakeForm()
        {
            InitializeComponent();

            bookListInOrder = new BookListInOrder(this);
            PanelAndFormUtils.EmbedFormInPanel(bookListInOrder, panel_book_list);

            booksListManager = new BooksListManager();  
        }

        private void text_box_search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = text_box_search.Text.ToLower(); 
            var filteredBooks = booksListManager.Books.Where(b => b.Name.ToLower().Contains(searchQuery) || b.Author.ToLower().Contains(searchQuery)).ToList();

            bookListInOrder.DisplayFilteredBooks(filteredBooks);
        }

        public void AddBookToOrder(BookConfig bookConfig)
        {
            // Add book to the order (implementation details here)
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
