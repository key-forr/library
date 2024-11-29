using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class GenreConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public GenreConfig(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    internal class RolesConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RolesConfig(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class ReminderConfig
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ReminderConfig(int userId, string title, string description)
        {
            UserId = userId;
            Title = title;
            Description = description;
        }
    }

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
