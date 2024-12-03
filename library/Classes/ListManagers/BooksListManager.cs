using library.Classes.CardFactory;
using library.Classes.Configuration;
using library.Forms.Book;
using System.Collections.Generic;
using System.Windows.Forms;

namespace library.Classes.ListManagers
{
    internal class BooksListManager
    {
        private List<BookConfig> books;

        public BooksListManager()
        {
            LoadBooks();
        }

        public List<BookConfig> Books
        {
            get { return books; }
            private set { books = value; }
        }

        public void LoadBooks()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                books = dataBaseHelper.LoadBooks();
            }
        }
    }
}
