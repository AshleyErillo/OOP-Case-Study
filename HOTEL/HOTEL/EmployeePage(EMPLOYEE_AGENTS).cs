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
    public partial class EmployeePage_EMPLOYEE_AGENTS_ : UserControl
    {
        public EmployeePage_EMPLOYEE_AGENTS_()
        {
            InitializeComponent();
        }

        private void View_Icon_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePage_EMPLOYEE_AGENTS__Load(object sender, EventArgs e)
        {

        }

        private void NewEmpAge_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployees f1 = new AddEmployees();
            f1.Show();

        }

        private void Edit_Icon_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditEmployeeProfiles f2 = new EditEmployeeProfiles();
            f2.Show();
            {

            };
        }
    }
}
