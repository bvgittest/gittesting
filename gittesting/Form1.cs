﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gittesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message from button 1 - changed");
            //added by Edward
            MessageBox.Show("Added by Edward");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //added by Edward here too
            MessageBox.Show("Added by Edward in button 2 as well");
            MessageBox.Show("2ndButton testing sync");
        }
    }
}
