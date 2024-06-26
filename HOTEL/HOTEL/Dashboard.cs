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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Mainpage = new DashboardView();
            Mainpage.Show();
            this.Hide();
        }

        private void Reservations_Label_Click(object sender, EventArgs e)
        {

        }

        private void Navstandard_Click(object sender, EventArgs e)
        {
            var Mainpage = new standardroom();
            Mainpage.Show();
            this.Hide();
        }

        private void Navdeluxe_Click(object sender, EventArgs e)
        {
            var Mainpage = new Updeluxe1();
            Mainpage.Show();
            this.Hide();
        }

        private void Navsuite_Click(object sender, EventArgs e)
        {
            var Mainpage = new Suite();
            Mainpage.Show();
            this.Hide();
        }
    }
}
