using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Classes.Configuration
{
    public class BookConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Publishing { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public int GenreId { get; set; }

        public BookConfig(int id, string name, string author, int year, string publishing, int quantity, string imagePath, int genreId)
        {
            Id = id;
            Name = name;
            Author = author;
            Year = year;
            Publishing = publishing;
            Quantity = quantity;
            ImagePath = imagePath;
            GenreId = genreId;
        }
    }
}
