using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageConverter
{
    public static class ImageConvert
    {
        public static Bitmap image_resizer(Image source, int maxWidth, int maxHeight, string WaterMark) {

            try
            {
                using (Bitmap original = new Bitmap(source))
                {
                    float ration = Math.Min(maxWidth / original.Width, maxHeight / original.Height);
                    int Width = (int)(original.Width * ration);
                    int Height = (int)(original.Height * ration);
                    using (Bitmap resize = new Bitmap(Width,Height, PixelFormat.Format32bppRgb))
                    {
                        using (Graphics Graphic = Graphics.FromImage(resize))
                        {
                            Graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            Graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            Graphic.DrawImage(original, 0, 0, Width, Height);

                            Font font = new Font("Arial", 12);
                            Brush brush = new SolidBrush(Color.Brown);
                            if (!String.IsNullOrEmpty(WaterMark) && WaterMark.Length <=10)
                            {
                                Graphic.DrawString(WaterMark, font, brush, new Point(Width - 100, Height - 50));
                            }
                            else
                            {
                                Graphic.DrawString("Watermark", font, brush, new Point(Width - 100, Height - 50));

                            }
                            return new Bitmap(resize);
                        }
                    }
                }
            }
            catch (Exception)
            {

                return null;
            }
          
        }
    }
}
