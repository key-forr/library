using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    internal static class CreateSomeTool
    {
        public static Guna.UI2.WinForms.Guna2GroupBox CreateBookCard(
    string bookTitle,
    string author,
    int bookCount,
    int x,                  
    int y,                 
    string imagePath = null)
        {
            Guna.UI2.WinForms.Guna2GroupBox book_card = new Guna.UI2.WinForms.Guna2GroupBox()
            {
                BackColor = Color.FromArgb(22, 26, 50),
                BorderColor = Color.FromArgb(0, 64, 0),
                BorderRadius = 20,
                BorderThickness = 3,
                CustomBorderColor = Color.FromArgb(0, 64, 0),
                CustomBorderThickness = new Padding(0),
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(125, 137, 149),
                Location = new Point(x, y),  // Використання переданих координат
                Name = "book_card",
                Size = new Size(338, 140)
            };

            // Create book title label
            Label titleLabel = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(13, 16),
                Name = "lblBookTitle",
                Text = bookTitle
            };

            // Create author label
            Label authorLabel = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI Light", 9F),
                ForeColor = Color.DimGray,
                Location = new Point(13, 58),
                Name = "lblAuthor",
                Text = author
            };

            // Create availability label
            bool isAvailable = bookCount > 0;
            Label availabilityLabel = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = isAvailable ? Color.FromArgb(0, 64, 0) : Color.Red,
                Location = new Point(13, 89),
                Name = "lblAvailability",
                Text = isAvailable
                    ? $"В наявності ({bookCount} шт.)"
                    : "Немає в наявності"
            };

            // Create PictureBox
            PictureBox pictureBox = new PictureBox()
            {
                Location = new Point(197, 47),
                Name = "pictureBox1",
                Size = new Size(113, 77),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Set image if path is provided and file exists
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    // Можете додати логування помилки
                    pictureBox.Image = null;
                }
            }

            // Add controls to the GroupBox
            book_card.Controls.Add(titleLabel);
            book_card.Controls.Add(authorLabel);
            book_card.Controls.Add(availabilityLabel);
            book_card.Controls.Add(pictureBox);

            return book_card;
        }

    }
}
