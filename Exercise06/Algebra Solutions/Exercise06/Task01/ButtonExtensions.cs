using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class ButtonStyle
    {
        public Color Background { get; set; }
        public Color Foreground { get; set; }
    }

    internal static class ButtonExtensions
    {
        internal static void ApplyStyle(this Button btn, ButtonStyle style)
        {
            btn.BackColor = style.Background;
            btn.ForeColor = style.Foreground;
        }

    }
}
