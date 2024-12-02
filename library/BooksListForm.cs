using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace library
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
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
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
                BookCardFactory bookCardFactory = new BookCardFactory(booksForm);
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
