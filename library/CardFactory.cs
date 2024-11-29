using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public interface ICardFactory
    {
        Guna.UI2.WinForms.Guna2GroupBox CreateBookCard(BookConfig config, int x, int y);
        Guna.UI2.WinForms.Guna2GroupBox CreateReminderCard(ReminderConfig reminderCardConfig, int x, int y);
    }

    

    public class ReminderCardFactory : ICardFactory
    {
        private ReminderListForm reminderListForm;

        public ReminderCardFactory(ReminderListForm reminderListForm)
        {
            this.reminderListForm = reminderListForm;
        }

        public Guna.UI2.WinForms.Guna2GroupBox CreateBookCard(BookConfig config, int x, int y)
        {
            throw new NotImplementedException("This method is not applicable for ReminderCardFactory");
        }
        public Guna.UI2.WinForms.Guna2GroupBox CreateReminderCard(ReminderConfig reminderCardConfig, int x, int y)
        {
            var group_box = new Guna.UI2.WinForms.Guna2GroupBox()
            {
                BorderColor = Color.FromArgb(22, 26, 50),
                BorderRadius = 10,
                BorderThickness = 0,
                CustomBorderThickness = new Padding(0),
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(125, 137, 149),
                Location = new Point(x, y),
                Name = "group_box",
                Size = new Size(335, 100),
                Tag = false
            };

            var label_title = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(3, 6),
                Name = "label_title",
                Text = reminderCardConfig.Title
            };

            var text_box_description = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BackColor = Color.FromArgb(36, 42, 78),
                BorderThickness = 0,
                DefaultText = reminderCardConfig.Description,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.DarkGray,
                Location = new Point(4, 44),
                Multiline = true,
                ReadOnly = true,
                Size = new Size(264, 60)
            };

            var text_box_date = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BackColor = Color.FromArgb(36, 42, 78),
                BorderThickness = 0,
                DefaultText = "",
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.DimGray,
                Location = new Point(206, 3),
                Multiline = true,
                ReadOnly = true,
                Size = new Size(126, 43)
            };

            var button_attach = new Guna.UI2.WinForms.Guna2Button()
            {
                BackColor = Color.FromArgb(36, 42, 78),
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.White,
                Image = global::library.Properties.Resources.PinNotHover,
                ImageSize = new Size(35, 35),
                Location = new Point(289, 52),
                Size = new Size(43, 37)
            };

            group_box.Controls.Add(label_title);
            group_box.Controls.Add(text_box_description);
            group_box.Controls.Add(text_box_date);
            group_box.Controls.Add(button_attach);

            return group_box;
        }
    }

   

    public class BookCardFactory : ICardFactory
    {
        private BooksForm parentForm;

        public BookCardFactory(BooksForm parentForm)
        {
            this.parentForm = parentForm;
        }

        public Guna.UI2.WinForms.Guna2GroupBox CreateBookCard(BookConfig config, int x, int y)
        {
            var book_card = new Guna.UI2.WinForms.Guna2GroupBox()
            {
                BackColor = Color.FromArgb(22, 26, 50),
                BorderRadius = 20,
                BorderThickness = 3,
                CustomBorderColor = Color.FromArgb(0, 64, 0),
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(125, 137, 149),
                Location = new Point(x, y),
                Size = new Size(350, 150)
            };

            var titleText = config.Name.Length > 14 ? config.Name.Substring(0, 14) + "..." : config.Name;
            var titleLabel = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(13, 16),
                Text = titleText
            };

            var authorText = config.Author.Length > 20 ? config.Author.Substring(0, 17) + "..." : config.Author;
            var authorLabel = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI Light", 10F),
                ForeColor = Color.DimGray,
                Location = new Point(13, 55),
                Text = authorText
            };

            var availabilityText = config.Quantity > 0
                ? $"В наявності ({config.Quantity} шт.)"
                : "Немає в наявності";

            var availabilityLabel = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = config.Quantity > 0 ? Color.FromArgb(0, 64, 0) : Color.Red,
                Location = new Point(13, 90),
                Text = availabilityText
            };

            var pictureBox = new PictureBox()
            {
                Location = new Point(210, 10),
                Size = new Size(120, 130),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = ImageUtils.LoadAndScaleImage(config.ImagePath, new Size(120, 80))
            };

            book_card.MouseEnter += (sender, e) =>
            {
                book_card.BorderColor = Color.FromArgb(0, 64, 0);
            };

            book_card.MouseLeave += (sender, e) =>
            {
                book_card.BorderColor = Color.White;
            };

            book_card.DoubleClick += (sender, e) =>
            {
                parentForm.OpenBookDetails(config);
            };

            book_card.Controls.Add(titleLabel);
            book_card.Controls.Add(authorLabel);
            book_card.Controls.Add(availabilityLabel);
            book_card.Controls.Add(pictureBox);

            return book_card;
        }

        public Guna.UI2.WinForms.Guna2GroupBox CreateReminderCard(ReminderConfig reminderCardConfig, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
