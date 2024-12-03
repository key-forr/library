using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using library.Classes.ListManagers;
using library.Classes.Utils;
using library.Classes;

namespace library.Forms.Book
{
    public partial class BookEditForm : Form
    {
        private BooksForm booksForm;
        private BookManageForm bookManageForm;

        public BookEditForm(BooksForm booksForm, BookManageForm bookManageForm)
        {
            InitializeComponent();
            this.booksForm = booksForm;
            this.bookManageForm = bookManageForm;

            LoadGenres();
            LoadComponents();
        }

        private void LoadGenres()
        {
            GenresListManager genreListManager = new GenresListManager();
            foreach (var genre in genreListManager.Genres)
            {
                combo_box_genres.Items.Add(genre.Name);
            }
        }

        public void LoadComponents()
        {
            text_box_author.Text = bookManageForm.bookConfig.Author;
            text_box_name.Text = bookManageForm.bookConfig.Name;

            picure_box_book.Image = ImageUtils.LoadAndScaleImage(bookManageForm.bookConfig.ImagePath, new Size(232, 277));
            text_box_photo.Text = bookManageForm.bookConfig.ImagePath;

            combo_box_genres.Text = new GenresListManager()
                .Genres.FirstOrDefault(g => g.Id == bookManageForm.bookConfig.GenreId)?.Name ?? "Жанр не знайдено";
            text_box_publishing.Text = bookManageForm.bookConfig.Publishing;
            text_box_quantity.Text = bookManageForm.bookConfig.Quantity.ToString();
            text_box_year.Text = bookManageForm.bookConfig.Year.ToString();
        }

        private void button_browse_photo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Book Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picure_box_book.Image = ImageUtils.LoadAndScaleImage(openFileDialog.FileName, new Size(232, 243));
                    text_box_photo.Text = openFileDialog.FileName;
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                bookManageForm.bookConfig.Name = text_box_name.Text;
                bookManageForm.bookConfig.Author = text_box_author.Text;
                bookManageForm.bookConfig.GenreId = new GenresListManager()
                    .Genres.FirstOrDefault(g => g.Name.Equals(combo_box_genres.Text, StringComparison.OrdinalIgnoreCase))?.Id ?? 0;
                bookManageForm.bookConfig.Publishing = text_box_publishing.Text;
                bookManageForm.bookConfig.Quantity = string.IsNullOrEmpty(text_box_quantity.Text) ? 0 : Convert.ToInt32(text_box_quantity.Text);
                bookManageForm.bookConfig.Year = string.IsNullOrEmpty(text_box_year.Text) ? 0 : Convert.ToInt32(text_box_year.Text);

                bookManageForm.bookConfig.ImagePath = picure_box_book.Image != null ? text_box_photo.Text : null;

                dbHelper.UpdateBook(bookManageForm.bookConfig);
            }

            booksForm.UpdateBookListForm();
            bookManageForm.UpdateBookInfoForm();
        }

        private void button_save_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_save, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_save_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_save, false, Color.FromArgb(36, 42, 78), 5);
        }
    }
}
