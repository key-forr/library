using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace library
{
    internal class GenresListManager
    {
        private List<GenreConfig> genres;

        public List<GenreConfig> Genres
        {
            get { return genres; }
            private set { genres = value; }
        }

        public GenresListManager()
        {
            LoadGenres();
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
