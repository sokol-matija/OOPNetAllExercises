using System.Drawing;

namespace Utilities
{
    public class Utility
    {
        private static Random random = new Random();

        public static Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        public static Point GetRandomLocationInParent(Size parentSize, Size childSize)
        {
            int maxX = parentSize.Width - childSize.Width;
            int maxY = parentSize.Height - childSize.Height;

            return new Point
            {
                X = random.Next(maxX),
                Y = random.Next(maxY)
            };
        }
    }
}