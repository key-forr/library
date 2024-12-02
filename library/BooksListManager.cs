using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
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
