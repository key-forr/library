﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace library
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void LoadGenres()
        {
            using (DataBaseHelper dbHelper = new DataBaseHelper())
            {
                dbHelper.LoadGenreIntoComboBox(combo_box_genre);
            }
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            LoadGenres();
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

        private void button_add_reminder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_box_book_name.Text) 
                || string.IsNullOrWhiteSpace(text_box_author.Text)
                || string.IsNullOrWhiteSpace(text_box_year.Text) 
                || string.IsNullOrWhiteSpace(text_box_publishing.Text)
                || string.IsNullOrWhiteSpace(text_box_quantity.Text) 
                || string.IsNullOrWhiteSpace(text_box_photo.Text)
                || string.IsNullOrWhiteSpace(combo_box_genre.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string name       = text_box_book_name.Text;
                string author     = text_box_author.Text;
                int year          = int.Parse(text_box_year.Text);
                string publishing = text_box_publishing.Text;
                int quantity      = int.Parse(text_box_quantity.Text);
                string photoPath  = text_box_photo.Text;
                int genreId       = combo_box_genre.SelectedIndex + 1;

                using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
                {
                    dataBaseHelper.AddBook(name, author, year, publishing,
                                            quantity, photoPath, genreId);
                }

                text_box_book_name.Text = "";
                text_box_author.Text = "";
                text_box_year.Text = "";
                text_box_publishing.Text = "";
                text_box_quantity.Text = "";
                text_box_photo.Text = "";
                combo_box_genre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні нагадування: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_box_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_box_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
