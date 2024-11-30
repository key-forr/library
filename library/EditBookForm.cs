using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class EditBookForm : Form
    {
        private BooksForm booksForm;
        private BookManageForm bookManageForm;

        public EditBookForm(BooksForm booksForm, BookManageForm bookManageForm)
        {
            InitializeComponent();
            this.booksForm = booksForm;
            this.bookManageForm = bookManageForm;
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            LoadGenres();
            LoadComponents();
        }

        private void button_save_book_Click(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                bookManageForm.bookCardConfig.Name = label_name.Text;
                bookManageForm.bookCardConfig.Author = text_box_author.Text;
                bookManageForm.bookCardConfig.GenreId = new GenreListManager().Genres.FirstOrDefault(g => g.Name.Equals(combo_box_genre.Text, StringComparison.OrdinalIgnoreCase)).Id;
                bookManageForm.bookCardConfig.Publishing = text_box_publishing.Text;
                bookManageForm.bookCardConfig.Quantity = string.IsNullOrEmpty(text_box_quantity.Text) ? 0 : Convert.ToInt32(text_box_quantity.Text);
                bookManageForm.bookCardConfig.Year = string.IsNullOrEmpty(text_box_year.Text) ? 0 : Convert.ToInt32(text_box_year.Text);
                bookManageForm.bookCardConfig.ImagePath = string.IsNullOrEmpty(text_box_photo.Text) ? null : text_box_photo.Text;
                dbHelper.UpdateBook(bookManageForm.bookCardConfig);
            }
            booksForm.UpdateBookListForm();
            bookManageForm.UpdateBookInfoForm();
        }

        private void button_browse_photo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Book Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    text_box_photo.Text = openFileDialog.FileName;
                }
            }
        }

        private void LoadGenres()
        {
            GenreListManager genreListManager = new GenreListManager();
            foreach (var genre in genreListManager.Genres)
            {
                combo_box_genre.Items.Add(genre.Name);
            }
        }

        public void LoadComponents()
        {
            text_box_author.Text = bookManageForm.bookCardConfig.Author;
            text_box_name.Text = bookManageForm.bookCardConfig.Name;
            text_box_photo.Text = bookManageForm.bookCardConfig.ImagePath;
            combo_box_genre.Text = new GenreListManager().Genres.FirstOrDefault(g => g.Id == bookManageForm.bookCardConfig.GenreId)?.Name ?? "Жанр не знайдено";
            text_box_publishing.Text = bookManageForm.bookCardConfig.Publishing;
            text_box_quantity.Text = bookManageForm.bookCardConfig.Quantity.ToString();
            text_box_year.Text = bookManageForm.bookCardConfig.Year.ToString();
        }

        private void button_save_book_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_save_book, false, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_save_book_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_save_book, true, Color.FromArgb(36, 42, 78), 5);
        }
    }
}
