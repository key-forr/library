﻿using MySql.Data.MySqlClient;
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
    public partial class BookManageForm : Form
    {
        private BooksForm booksForm;
        private BookDetailsForm bookDetailsForm;
        public BookConfig bookCardConfig { get; set; }

        public BookManageForm(BookConfig bookCardConfig, BooksForm booksForm)
        {
            InitializeComponent();
            this.bookCardConfig = bookCardConfig;
            this.booksForm = booksForm;

            bookDetailsForm = new BookDetailsForm(booksForm, this);
            PanelAndFormManager.EmbedFormInPanel(bookDetailsForm, panel_book_info);
        }

        public Panel PanelBookInfo
        {
            get { return panel_book_info; }
        }

        public Panel PanelBookInteraction
        {
            get { return panel_book_interaction; }
        }


        public void UpdateBookInfoForm()
        {
            panel_book_info.Controls.Clear();

            bookDetailsForm = new BookDetailsForm(booksForm, this);
            PanelAndFormManager.EmbedFormInPanel(bookDetailsForm, panel_book_info);
        }

        private void BookDetailsForm_Load(object sender, EventArgs e)
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                bookCardConfig = dbHelper.LoadBookDetails(bookCardConfig.Id);
            }
        }
    }
}