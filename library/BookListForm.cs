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
    public partial class BookListForm : Form
    {
        private BookListManager bookListManager;
        private BooksForm parentForm;

        public BookListForm(BooksForm parentForm)
        {
            InitializeComponent();
            bookListManager = new BookListManager();
            this.parentForm = parentForm;
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

            foreach (var book in bookListManager.Books)
            {
                BookCardFactory bookCardFactory = new BookCardFactory(parentForm);
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
