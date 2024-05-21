﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak08
{
    public partial class CustomForma : Form
    {
        public CustomForma()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnMinimiziraj_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaksimiziraj_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
