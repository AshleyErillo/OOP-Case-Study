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
    public partial class AddEmployees : Form
    {
        public AddEmployees()
        {
            InitializeComponent();
        }

        private void MyProfileHeader_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogConfirmation1 f2 = new DialogConfirmation1();
            f2. Show();



        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}