using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace library.Classes.Utils
{
    public static class ButtonUtils
    {
        public static void AnimateButtonOnHover(Guna.UI2.WinForms.Guna2Button button, bool isHovering, Color originalColor, int sizeChange)
        {
            if (button == null) return;

            int fontChange = 1;
            int lightenAmount = 30;

            if (isHovering)
            {
                button.Location = new Point(
                    button.Location.X - sizeChange / 2,
                    button.Location.Y - sizeChange / 2
                );
                button.Size = new Size(
                    button.Width + sizeChange,
                    button.Height + sizeChange
                );

                button.Font = new Font(
                    button.Font.FontFamily,
                    button.Font.Size + fontChange
                );

                button.FillColor = Color.FromArgb(
                    Math.Min(255, originalColor.R + lightenAmount),
                    Math.Min(255, originalColor.G + lightenAmount),
                    Math.Min(255, originalColor.B + lightenAmount)
                );
            }
            else
            {
                button.Location = new Point(
                    button.Location.X + sizeChange / 2,
                    button.Location.Y + sizeChange / 2
                );
                button.Size = new Size(
                    button.Width - sizeChange,
                    button.Height - sizeChange
                );

                button.Font = new Font(
                    button.Font.FontFamily,
                    button.Font.Size - fontChange
                );

                button.FillColor = originalColor;
            }
        }

        public static void AnimateNavigationButton(Button button, bool isHovering, Color originalTextColor, Color originalBackColor)
        {
            if (button == null) return;

            Color hoverTextColor = Color.FromArgb(156, 74, 232); 
            Color hoverBackColor = Color.FromArgb(22, 26, 50);   

            if (isHovering)
            {
                button.ForeColor = hoverTextColor;
                button.BackColor = hoverBackColor;

                button.FlatAppearance.MouseOverBackColor = hoverBackColor;
                button.FlatAppearance.MouseDownBackColor = hoverBackColor;
            }
            else
            {
                button.ForeColor = originalTextColor;
                button.BackColor = originalBackColor;

                button.FlatAppearance.MouseOverBackColor = originalBackColor;
                button.FlatAppearance.MouseDownBackColor = originalBackColor;
            }
        }

        public static void AnimateNavigationIconButton(IconButton button, bool isHovering, Color originalIconColor, Color originalBackColor)
        {
            if (button == null) return;

            Color hoverIconColor = Color.FromArgb(156, 74, 232); 
            Color hoverBackColor = Color.FromArgb(22, 26, 50);  

            if (isHovering)
            {
                button.IconColor = hoverIconColor;
                button.BackColor = hoverBackColor;

                button.FlatAppearance.MouseOverBackColor = hoverBackColor;
                button.FlatAppearance.MouseDownBackColor = hoverBackColor;
            }
            else
            {
                button.IconColor = originalIconColor;
                button.BackColor = originalBackColor;

                button.FlatAppearance.MouseOverBackColor = originalBackColor;
                button.FlatAppearance.MouseDownBackColor = originalBackColor;
            }
        }
    }
}
