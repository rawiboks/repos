﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInherit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            SetBackground();
            //InitializeComponent();
        }

        public void SetBackground()
        {
            this.BackColor = System.Drawing.Color.Black;
        }
    }
}
