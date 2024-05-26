using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class ViewUtils
    {
        public static Control GetThumbnailPicture(string filePath, Control parentContainer)
        {
            Panel canvas = new Panel();
            canvas.Size = GetCanvasSize(parentContainer);
            canvas.BackColor = Color.White;
            canvas.Margin = new Padding(0, 2, 0, 2);

            PictureBox pb = new PictureBox();

            Image imgThumbnail = Image.FromFile(filePath);
            pb.Image = imgThumbnail;
            SetPictureSizeAndLocation(pb, canvas);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            return canvas;
        }

        private static void SetPictureSizeAndLocation(PictureBox pb, Control canvas)
        {
            var percent = 0.1;
            var border = canvas.Width * percent;

            var w = (int)(canvas.Width - border);
            var h = (int)(canvas.Height - border);

            var x = (int)(border / 2);
            var y = (int)(border / 2);

            canvas.Controls.Add(pb);
            pb.Size = new Size(w, h);
            pb.Location = new Point(x, y);
        }

        private static Size GetCanvasSize(Control parentContainer)
        {
            double scale = 2.0 / 3.0;
            var w = parentContainer.Width;
            var h = (int)(w * scale);

            return new Size(w, h);
        }

    }
}
