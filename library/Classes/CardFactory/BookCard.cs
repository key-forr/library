using library.Classes.Configuration;
using System;
using System.Drawing;
using System.Windows.Forms;
using library.Forms.Book;
using library.Classes.Utils;
using library.Forms.Order;

namespace library.Classes.CardFactory
{
    public class BookCard
    {
        private BooksForm booksForm;
        private OrderMakeForm orderMakeForm;

        public BookCard(BooksForm booksForm)
        {
            this.booksForm = booksForm;
        }

        public BookCard(OrderMakeForm orderMakeForm)
        {
            this.orderMakeForm = orderMakeForm;
        }

        public Guna.UI2.WinForms.Guna2GroupBox CreateBookCard(BookConfig bookConfig, int x, int y)
        {
            var book_card = new Guna.UI2.WinForms.Guna2GroupBox()
            {
                CustomBorderThickness = new Padding(0, 0, 0, 0),
                BorderRadius = 30,
                BorderThickness = 0,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(125, 137, 149),
                Location = new Point(x, y),
                Size = new Size(441, 166),
                Cursor = Cursors.Hand
            };

            var titleText = bookConfig.Name.Length > 12 ? bookConfig.Name.Substring(0, 12) + "..." : bookConfig.Name;
            var titleLabel = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(28, 20),
                Text = titleText,
                Cursor = Cursors.Hand
            };

            var authorText = bookConfig.Author.Length > 20 ? bookConfig.Author.Substring(0, 20) + "..." : bookConfig.Author;
            var authorLabel = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                ForeColor = Color.DimGray,
                Location = new Point(28, 60),
                Size = new Size(256, 45),
                Text = authorText,
                ReadOnly = true,
                Cursor = Cursors.Hand
            };

            var availabilityText = bookConfig.Quantity > 0
                ? $"В наявності: ({bookConfig.Quantity} шт.)"
                : "Немає в наявності";
            var availabilityLabel = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                ForeColor = bookConfig.Quantity > 0 ? Color.FromArgb(72, 169, 118) : Color.Red,
                Location = new Point(28, 115),
                Size = new Size(205, 30),
                Text = availabilityText,
                ReadOnly = true,
                Cursor = Cursors.Hand
            };

            var pictureBox = new PictureBox()
            {
                Location = new Point(291, 19),
                Size = new Size(120, 132),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = ImageUtils.LoadAndScaleImage(bookConfig.ImagePath, new Size(120, 130)),
                Cursor = Cursors.Hand
            };

            EventHandler hoverEffect = (sender, e) =>
            {
                book_card.BorderThickness = 3;
                book_card.BorderColor = Color.FromArgb(72, 169, 118);
            };

            EventHandler resetEffect = (sender, e) =>
            {
                book_card.BorderThickness = 0;
                book_card.BorderColor = Color.White;
            };

            EventHandler openDetails = (sender, e) =>
            {
                if (booksForm != null)
                {
                    booksForm.OpenBookDetails(bookConfig); 
                }
                else if (orderMakeForm != null)
                {
                    orderMakeForm.AddBookToOrder(bookConfig);
                }
            };

            book_card.MouseEnter += hoverEffect;
            book_card.MouseLeave += resetEffect;
            book_card.DoubleClick += openDetails;

            titleLabel.MouseEnter += hoverEffect;
            titleLabel.MouseLeave += resetEffect;
            titleLabel.DoubleClick += openDetails;

            authorLabel.MouseEnter += hoverEffect;
            authorLabel.MouseLeave += resetEffect;
            authorLabel.DoubleClick += openDetails;

            availabilityLabel.MouseEnter += hoverEffect;
            availabilityLabel.MouseLeave += resetEffect;
            availabilityLabel.DoubleClick += openDetails;

            pictureBox.MouseEnter += hoverEffect;
            pictureBox.MouseLeave += resetEffect;
            pictureBox.DoubleClick += openDetails;

            book_card.Controls.Add(titleLabel);
            book_card.Controls.Add(authorLabel);
            book_card.Controls.Add(availabilityLabel);
            book_card.Controls.Add(pictureBox);

            return book_card;
        }
    }
}
