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
                bookManageForm.bookConfig = dbHelper.LoadBookDetails(bookManageForm.bookConfig.Id);

                text_box_author.Text = bookManageForm.bookConfig.Author;
                label_name.Text = bookManageForm.bookConfig.Name;
                picure_box_book.Image = ImageUtils.LoadAndScaleImage(bookManageForm.bookConfig.ImagePath, new Size(263, 403));
                text_box_genre.Text = new GenresListManager().Genres.FirstOrDefault(g => g.Id == bookManageForm.bookConfig.GenreId)?.Name ?? "Жанр не знайдено";
                text_box_publishing.Text = bookManageForm.bookConfig.Publishing;
                text_box_quantity.Text = bookManageForm.bookConfig.Quantity.ToString();
                text_box_year.Text = bookManageForm.bookConfig.Year.ToString();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            bookManageForm.Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            BookEditForm childForm = new BookEditForm(booksForm, bookManageForm);
            PanelAndFormManager.EmbedFormInPanel(childForm, bookManageForm.PanelBookInteraction);
        }

        private void button_edit_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_edit, true, Color.FromArgb(36, 42, 78), 5);
        }

        private void button_edit_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_edit, false, Color.FromArgb(36, 42, 78), 5);
        }
    }
}
