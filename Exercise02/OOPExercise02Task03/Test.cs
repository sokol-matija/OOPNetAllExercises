using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace OOPExercise02Task03
{
    public partial class Test : Form
    {
        private int buttonCount = 1;

        public Test()
        {
            InitializeComponent();
        }

        public void ChangeBackColor()
        {
            this.BackColor = Utility.GetRandomColor();
        }

        public void ChangeWinState()
        {
            this.WindowState = (FormWindowState)new Random().Next(3);
        }

        public void AddButton()
        {
            Button button = new Button
            {
                Text = $"Button {buttonCount++}"
            };
            pnlContainer.Controls.Add(button);
        }
    }
}
