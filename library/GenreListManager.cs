using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace library
{
    internal class GenreListManager
    {
        private List<GenreConfig> genres;

        public GenreListManager()
        {
            LoadGenres();
        }

        public List<GenreConfig> Genres
        {
            get { return genres; }
            private set { genres = value; }
        }

        public void LoadGenres()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                genres = dataBaseHelper.LoadGenres();
            }
        }
    }
}
