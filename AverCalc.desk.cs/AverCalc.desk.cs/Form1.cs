﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverCalc.desk.cs
{
    public partial class Form1 : Form
    {
        public int average;
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("TextFile1.txt");
            foreach(string line in lines)
            {
                average = average + Int32.Parse(line);
                count++;
            }
            average = average / count;
            MessageBox.Show(average.ToString());
        }

        private void Form1_Enter(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
