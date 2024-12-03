using library.Classes.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Forms.Reminder;
using library.Forms.Book;
using library.Forms.Order;

namespace library.Classes.CardFactory
{
    public class ReminderCard
    { 
        private RemindersListForm reminderListForm;

        public ReminderCard(RemindersListForm reminderListForm)
        {
            this.reminderListForm = reminderListForm;
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
            group_box.Controls.Add(text_box_date);
            group_box.Controls.Add(button_attach);

            return group_box;
        }
    }
}
