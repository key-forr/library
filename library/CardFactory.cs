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
        Guna.UI2.WinForms.Guna2GroupBox CreateEmployeeCard(EmployeeConfig employeeConfig, int x, int y);
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

        public Guna.UI2.WinForms.Guna2GroupBox CreateEmployeeCard(EmployeeConfig employeeConfig, int x, int y)
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

            var text_box_title = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                DefaultText = reminderCardConfig.Title,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                Multiline = true,
                ReadOnly = true,
                Location = new Point(3, 6),
                Size = new Size(230, 40),
                Padding = new Padding(5, 5, 5, 5),
                TextAlign = HorizontalAlignment.Left
            };

            using (Graphics g = text_box_title.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(text_box_title.Text, text_box_title.Font, text_box_title.Width);
                int adjustedHeight = (int)Math.Ceiling(textSize.Height) + 10;
                text_box_title.Size = new Size(text_box_title.Width, adjustedHeight);
            }

            var text_box_description = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                DefaultText = reminderCardConfig.Description,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.DarkGray,
                Multiline = true,
                ReadOnly = true,
                Location = new Point(4, text_box_title.Bottom + 5),
                Size = new Size(280, 60),
                Padding = new Padding(5, 5, 5, 5),
                TextAlign = HorizontalAlignment.Left
            };

            using (Graphics g = text_box_description.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(text_box_description.Text, text_box_description.Font, text_box_description.Width);
                int adjustedHeight = (int)Math.Ceiling(textSize.Height) + 10;
                text_box_description.Size = new Size(text_box_description.Width, adjustedHeight);
            }

            var text_box_date = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                DefaultText = reminderCardConfig.ReminderDate.ToString(),
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.White,
                Multiline = true,
                ReadOnly = true,
                Location = new Point(group_box.Width - 110, 6),
                Size = new Size(120, 40),
                Padding = new Padding(5, 5, 5, 5),
                TextAlign = HorizontalAlignment.Center
            };

            group_box.Size = new Size(group_box.Width, text_box_description.Bottom + 10);

            var button_attach = new Guna.UI2.WinForms.Guna2Button()
            {
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.White,
                Image = global::library.Properties.Resources.PinNotHover,
                ImageSize = new Size(35, 35),
                Location = new Point(289, group_box.Height - 48),
                Size = new Size(43, 37)
            };

            group_box.Controls.Add(text_box_title);
            group_box.Controls.Add(text_box_description);
            group_box.Controls.Add(text_box_date);  // Додаємо текстове поле з датою
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

        public Guna.UI2.WinForms.Guna2GroupBox CreateEmployeeCard(EmployeeConfig employeeConfig, int x, int y)
        {
            throw new NotImplementedException("This method is not applicable for ReminderCardFactory");
        }

        public Guna.UI2.WinForms.Guna2GroupBox CreateBookCard(BookConfig config, int x, int y)
        {
            var book_card = new Guna.UI2.WinForms.Guna2GroupBox()
            {
                BorderColor = Color.White,
                BorderRadius = 30,
                BorderThickness = 1,
                CustomBorderThickness = new Padding(0, 0, 0, 0),
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(125, 137, 149),
                Location = new Point(x, y),
                Size = new Size(441, 166),
                Cursor = Cursors.Hand
            };

            var titleText = config.Name.Length > 12 ? config.Name.Substring(0, 12) + "..." : config.Name;
            var titleLabel = new Label()
            {
                AutoSize = true,
                BackColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(28, 20),
                Text = titleText,
                Cursor = Cursors.Hand
            };

            var authorText = config.Author.Length > 20 ? config.Author.Substring(0, 20) + "..." : config.Author;
            var authorLabel = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(28, 60),
                Size = new Size(256, 45),
                Text = authorText,
                ReadOnly = true,
                Cursor = Cursors.Hand
            };

            var availabilityText = config.Quantity > 0
                ? $"В наявності: ({config.Quantity} шт.)"
                : "Немає в наявності";
            var availabilityLabel = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                ForeColor = config.Quantity > 0 ? Color.FromArgb(72, 169, 118) : Color.Red,
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
                Image = ImageUtils.LoadAndScaleImage(config.ImagePath, new Size(120, 130)),
                Cursor = Cursors.Hand
            };

            EventHandler hoverEffect = (sender, e) =>
            {
                book_card.BorderThickness = 3;
                book_card.BorderColor = Color.FromArgb(72, 169, 118);
            };

            EventHandler resetEffect = (sender, e) =>
            {
                book_card.BorderThickness = 1;
                book_card.BorderColor = Color.White;
            };

            EventHandler openDetails = (sender, e) =>
            {
                parentForm.OpenBookDetails(config);
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

        public Guna.UI2.WinForms.Guna2GroupBox CreateReminderCard(ReminderConfig reminderCardConfig, int x, int y)
        {
            throw new NotImplementedException();
        }

        public class EmployeeCardFactory : ICardFactory
        {
            private EmployeeForm parentForm;

            public EmployeeCardFactory(EmployeeForm parentForm)
            {
                this.parentForm = parentForm;
            }

            public Guna.UI2.WinForms.Guna2GroupBox CreateEmployeeCard(EmployeeConfig employeeConfig, int x, int y)
            {
                var group_box = new Guna.UI2.WinForms.Guna2GroupBox()
                {
                    BorderColor = Color.FromArgb(22, 26, 50),
                    BorderRadius = 20,
                    BorderThickness = 0,
                    CustomBorderThickness = new Padding(0),
                    FillColor = Color.FromArgb(36, 42, 78),
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(125, 137, 149),
                    Location = new Point(x, y),
                    Name = "group_box",
                    Size = new Size(440, 120),
                    Tag = false
                };

                // Текстове поле для прізвища та імені працівника
                var text_box_name = new Guna.UI2.WinForms.Guna2TextBox()
                {
                    BorderThickness = 0,
                    DefaultText = $"{employeeConfig.Surname} {employeeConfig.Name}",
                    FillColor = Color.FromArgb(36, 42, 78),
                    Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Multiline = true,
                    ReadOnly = true,
                    Location = new Point(10, 10),
                    Padding = new Padding(10, 5, 10, 5),
                    Size = new Size(300, 50),
                    TextAlign = HorizontalAlignment.Left
                };

                // Текстове поле для ролі працівника
                string roleName = new RoleListManager().Roles
                    .FirstOrDefault(g => g.Id == employeeConfig.RoleId)?.Name ?? "Роль не знайдено";

                var text_box_role = new Guna.UI2.WinForms.Guna2TextBox()
                {
                    BorderThickness = 0,
                    DefaultText = $"Роль: {roleName}",
                    FillColor = Color.FromArgb(36, 42, 78),
                    Font = new Font("Segoe UI", 14F),
                    ForeColor = Color.DarkGray,
                    Multiline = true,
                    ReadOnly = true,
                    Location = new Point(10, text_box_name.Bottom + 5),
                    Padding = new Padding(10, 5, 10, 5),
                    Size = new Size(300, 50),
                    TextAlign = HorizontalAlignment.Left
                };

                group_box.Size = new Size(group_box.Width, text_box_role.Bottom + 15);

                // Події для hover-ефекту та відкриття деталей працівника
                EventHandler hoverEffect = (sender, e) =>
                {
                    group_box.BorderThickness = 3;
                    group_box.BorderColor = Color.FromArgb(72, 169, 118);
                };

                EventHandler resetEffect = (sender, e) =>
                {
                    group_box.BorderThickness = 0;
                    group_box.BorderColor = Color.FromArgb(22, 26, 50);
                };

                EventHandler openDetails = (sender, e) =>
                {
                    parentForm.OpenEmployeeDetails(employeeConfig);
                };

                // Додаємо події до елементів
                group_box.MouseEnter += hoverEffect;
                group_box.MouseLeave += resetEffect;
                group_box.DoubleClick += openDetails;

                text_box_name.MouseEnter += hoverEffect;
                text_box_name.MouseLeave += resetEffect;
                text_box_name.DoubleClick += openDetails;

                text_box_role.MouseEnter += hoverEffect;
                text_box_role.MouseLeave += resetEffect;
                text_box_role.DoubleClick += openDetails;

                // Додавання елементів у груповий бокс
                group_box.Controls.Add(text_box_name);
                group_box.Controls.Add(text_box_role);

                return group_box;
            }


            public Guna.UI2.WinForms.Guna2GroupBox CreateBookCard(BookConfig config, int x, int y)
            {
                throw new NotImplementedException("This method is not applicable for ReminderCardFactory");
            }

            public Guna.UI2.WinForms.Guna2GroupBox CreateReminderCard(ReminderConfig reminderCardConfig, int x, int y)
            {
                throw new NotImplementedException("This method is not applicable for ReminderCardFactory");
            }
        }
    }
}

