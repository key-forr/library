using System;
using System.ComponentModel;
using System.Windows.Forms;
using library.Classes.ListManagers;
using library.Forms.Order;
using static Guna.UI2.Native.WinApi;
using library.Classes.CardFactory;

namespace library.Forms.Book
{
    public partial class BooksListForm : Form
    {
        private BooksListManager booksListManager;
        private BooksForm booksForm;

        public BooksListForm(BooksForm booksForm)
        {
            InitializeComponent();
            booksListManager = new BooksListManager();

            this.booksForm = booksForm;
            DisplayBooks();
        }

        public void DisplayBooks()
        {
            this.Controls.Clear();

            int x = 30;
            int y = 30;
            int bookCount = 0;

            foreach (var book in booksListManager.Books)
            {
                BookCard bookCardFactory = new BookCard(booksForm);
                var bookCard = bookCardFactory.CreateBookCard(book, x, y);

                this.Controls.Add(bookCard);

                x += 500;
                bookCount++;

                if (bookCount % 2 == 0)
                {
                    x = 30;
                    y += 200;
                }
            }
        }
    }
}
