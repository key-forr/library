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
        private List<BookCardConfig> books;
        private BooksForm booksForm;
        public BookListForm(BooksForm booksForm)
        {
            InitializeComponent();
            this.booksForm = booksForm;
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                books = dataBaseHelper.LoadBookDataForCard();
                DisplayBooks();
            }
        }

        public void DisplayBooks()
        {
            int x = 30;
            int y = 30;
            int bookCount = 0;

            foreach (var book in books)
            {
                BookCardFactory bookCardFactory = new BookCardFactory(booksForm);
                Guna.UI2.WinForms.Guna2GroupBox bookCard = bookCardFactory.CreateBookCard(book, x, y);

                this.Controls.Add(bookCard);

                x += 400;
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
