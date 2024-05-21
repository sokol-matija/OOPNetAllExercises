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
    }
}