﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardeningGuide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBxResultFlowers.Text = cmboFlowers.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBxResultTrees.Text = "";
            foreach (int i in lstBxTrees.SelectedIndices)
            {
                txtBxResultTrees.Text += lstBxTrees.Items[i] + " ";

            }
        }
    }
}
