using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace library
{
    public partial class BookDetailsForm : Form
    {
        private BookCardConfig bookCardConfig;
        public BookDetailsForm(BookCardConfig bookCardConfig)
        {
            InitializeComponent();
            this.bookCardConfig = bookCardConfig;
        }

       

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookDetailsForm_Load(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                bookCardConfig = dbHelper.LoadBookDetails(bookCardConfig.Id);
                text_box_author.Text = bookCardConfig.Author;
                label_name.Text = bookCardConfig.Title;
                picure_box_book.Image = ImageUtils.LoadAndScaleImage(bookCardConfig.ImagePath, new Size(263, 403));
                text_box_genre.Text = bookCardConfig.Genre;
                text_box_publishing.Text = bookCardConfig.Publishing;
                text_box_quantity.Text = bookCardConfig.Count.ToString();
                text_box_year.Text = bookCardConfig.Year.ToString();
            }
        }

        private void button_edit_book_Click(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                bookCardConfig.Author = text_box_author.Text;
                bookCardConfig.Title = label_name.Text;
                bookCardConfig.Genre = text_box_genre.Text;
                bookCardConfig.Publishing = text_box_publishing.Text  ;
                bookCardConfig.Count = string.IsNullOrEmpty(text_box_quantity.Text) ? 0 : Convert.ToInt32(text_box_quantity.Text);
                bookCardConfig.Year = string.IsNullOrEmpty(text_box_year.Text) ? 0 : Convert.ToInt32(text_box_year.Text);
                dbHelper.UpdateBook(bookCardConfig);
            }
        }
    }
}
