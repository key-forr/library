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
    public partial class BookDetailsForm : Form
    {
        private BookManageForm bookManageForm;
        private BooksForm booksForm;

        public BookDetailsForm(BooksForm booksForm, BookManageForm bookManageForm)
        {
            InitializeComponent();
            this.booksForm = booksForm;
            this.bookManageForm = bookManageForm;
        }

        private void BookDetailsForm_Load(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                bookManageForm.bookCardConfig = dbHelper.LoadBookDetails(bookManageForm.bookCardConfig.Id);

                text_box_author.Text = bookManageForm.bookCardConfig.Author;
                label_name.Text = bookManageForm.bookCardConfig.Name;
                picure_box_book.Image = ImageUtils.LoadAndScaleImage(bookManageForm.bookCardConfig.ImagePath, new Size(263, 403));
                text_box_genre.Text = new GenreListManager().Genres.FirstOrDefault(g => g.Id == bookManageForm.bookCardConfig.GenreId)?.Name ?? "Жанр не знайдено";
                text_box_publishing.Text = bookManageForm.bookCardConfig.Publishing;
                text_box_quantity.Text = bookManageForm.bookCardConfig.Quantity.ToString();
                text_box_year.Text = bookManageForm.bookCardConfig.Year.ToString();
            }
        }

        private void button_edit_book_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_edit_book, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_edit_book_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_edit_book, false, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_edit_book_Click(object sender, EventArgs e)
        {
            EditBookForm childForm = new EditBookForm(booksForm, bookManageForm);
            PanelAndFormManager.EmbedFormInPanel(childForm, bookManageForm.PanelBookInteraction);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            bookManageForm.Close();
        }
    }
}
