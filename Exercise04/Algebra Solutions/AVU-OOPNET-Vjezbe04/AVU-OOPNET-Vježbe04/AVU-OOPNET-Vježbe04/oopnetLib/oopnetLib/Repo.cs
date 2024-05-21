using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopnetLib
{
    public class Repo
    {
        private static readonly Random rnd = new Random();

        public static Color GetRandomColor()
        {
            var R = rnd.Next(256);
            var G = rnd.Next(256);
            var B = rnd.Next(256);
            return Color.FromArgb(R, G, B);
        }
        public static Point GetRandomLocation(Control parenControl, Control ctrl)
        {
            int maxX = parenControl.ClientSize.Width - ctrl.Width;
            int maxY = parenControl.ClientSize.Height - ctrl.Height;
            int x = rnd.Next(maxX);
            int y = rnd.Next(maxY);
            return new Point(x, y);
        }
    }
}
