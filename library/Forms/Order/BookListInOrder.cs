using library.Classes.CardFactory;
using library.Classes.ListManagers;
using library.Forms.Book;
using library.Classes.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace library.Forms.Order
{
    public partial class BookListInOrder : Form
    {
        private BooksListManager booksListManager;
        private OrderMakeForm orderMakeForm;

        public BookListInOrder(OrderMakeForm orderMakeForm)
        {
            InitializeComponent();
            booksListManager = new BooksListManager();
            this.orderMakeForm = orderMakeForm;

            DisplayBooks(booksListManager.Books); 
        }

        public void DisplayBooks(List<BookConfig> books)
        {
            this.Controls.Clear();  

            int x = 10;
            int y = 30;

            foreach (var book in books)
            {
                BookCard bookCardFactory = new BookCard(orderMakeForm);
                var bookCard = bookCardFactory.CreateBookCard(book, x, y);

                this.Controls.Add(bookCard);

                y += 200;  
            }
        }

        public void DisplayFilteredBooks(List<BookConfig> filteredBooks)
        {
            DisplayBooks(filteredBooks);  
        }
    }
}