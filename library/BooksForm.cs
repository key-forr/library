﻿using System;
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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            PanelAndFormManager.EmbedFormInPanel(new BookListForm(), panel_main);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_book_Click(object sender, EventArgs e)
        {
            var childForm = new AddBookForm();
            PanelAndFormManager.EmbedFormInPanel(childForm, panel_main);
        }
    }
}
