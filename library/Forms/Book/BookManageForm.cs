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
using library.Classes.Configuration;
using library.Classes.Utils;
using library.Classes;

namespace library.Forms.Book
{
    public partial class BookManageForm : Form
    {
        private BooksForm booksForm;
        private BookDetailsForm bookDetailsForm;

        public BookConfig bookConfig { get; set; }

        public BookManageForm(BookConfig bookConfig, BooksForm booksForm)
        {
            InitializeComponent();
            this.bookConfig = bookConfig;
            this.booksForm = booksForm;

            bookDetailsForm = new BookDetailsForm(booksForm, this);
            PanelAndFormUtils.EmbedFormInPanel(bookDetailsForm, panel_book_info);
        }

        public Panel PanelBookInteraction
        {
            get { return panel_book_interaction; }
        }

        public void UpdateBookInfoForm()
        {
            panel_book_info.Controls.Clear();

            bookDetailsForm = new BookDetailsForm(booksForm, this);
            PanelAndFormUtils.EmbedFormInPanel(bookDetailsForm, panel_book_info);
        }

        private void BookDetailsForm_Load(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                bookConfig = dbHelper.LoadBookDetails(bookConfig.Id);
            }
        }
    }
}
