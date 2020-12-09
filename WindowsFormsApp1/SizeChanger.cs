﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SizeChanger : Form
    {
        public SizeChanger(int min, int max, int step,int size)
        {
            InitializeComponent();
            trackBar1.Minimum = min;
            trackBar1.Maximum = max;
            trackBar1.SmallChange = step;
            trackBar1.Value = size;
            label1.Text = Convert.ToString(size);

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MainForm.penSize = trackBar1.Value;
            label1.Text = Convert.ToString(trackBar1.Value);
            MainForm.PenButton.Text = Convert.ToString(trackBar1.Value);
        }

        private void SizeChanger_Load(object sender, EventArgs e)
        {

        }
    }
}
