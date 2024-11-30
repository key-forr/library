using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace library
{
    public static class ImageUtils
    {
        private static Image ResizeImagePreserveAspect(Image originalImage, Size containerSize)
        {
            if (originalImage == null)
                return CreatePlaceholderImage(containerSize);

            int sourceWidth = originalImage.Width;
            int sourceHeight = originalImage.Height;

            float scaleW = (float)containerSize.Width / sourceWidth;
            float scaleH = (float)containerSize.Height / sourceHeight;
            float scale = Math.Min(scaleW, scaleH);

            int destWidth = (int)(sourceWidth * scale);
            int destHeight = (int)(sourceHeight * scale);

            Bitmap scaledBitmap = new Bitmap(destWidth, destHeight);

            using (Graphics graphics = Graphics.FromImage(scaledBitmap))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                graphics.DrawImage(
                    originalImage,
                    0,
                    0,
                    destWidth,
                    destHeight
                );
            }

            return scaledBitmap;
        }

        
        public static Image LoadAndScaleImage(string imagePath, Size containerSize)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                {
                    return CreatePlaceholderImage(containerSize);
                }

                using (Image originalImage = Image.FromFile(imagePath))
                {
                    return ResizeImagePreserveAspect(originalImage, containerSize);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Помилка завантаження зображення: {ex.Message}");
                return CreatePlaceholderImage(containerSize);
            }
        }

        public static Image CreatePlaceholderImage(Size size)
        {
            Bitmap bmp = new Bitmap(size.Width, size.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);

                using (Font font = new Font("Segoe UI", 8, FontStyle.Regular))
                using (SolidBrush brush = new SolidBrush(Color.DarkGray))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    g.DrawString(
                        "Зображення\nвідсутнє",
                        font,
                        brush,
                        new RectangleF(0, 0, size.Width, size.Height),
                        sf
                    );
                }
            }

            return bmp;
        }
    }
}