﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task05
{
    public partial class TextInput : Form
    {
        public TextInput()
        {
            InitializeComponent();

        }

        public string GetText()
        {
            return txtInput.Text;

        }
    }
}
