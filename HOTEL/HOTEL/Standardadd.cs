﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Standardadd : UserControl
    {
        public Standardadd()
        {
            InitializeComponent();
        }

        private void Backstandard_Click(object sender, EventArgs e)
        {
            Stanroom back = new Stanroom();
            back.Show();
            this.Hide();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Titleinventory2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nextstandard2_Click(object sender, EventArgs e)
        {
            var Mainpage = new Standardinventory();
            Mainpage.Show();
            this.Hide();
        }

        private void Standardadd_Load(object sender, EventArgs e)
        {

        }
    }
}