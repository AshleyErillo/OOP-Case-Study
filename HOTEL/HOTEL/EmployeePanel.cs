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
    public partial class EmployeePanel : UserControl
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            myProfile1.Show();
            employeePage_EMPLOYEE_AGENTS_1.Hide();

            Profile_button.BackColor = Color.Gold;
            EmployeeAgents_Button.BackColor = Color.White;
        }

        private void EmployeeAgents_Button_Click(object sender, EventArgs e)
        {
            employeePage_EMPLOYEE_AGENTS_1.Show();
            myProfile1.Hide();

            EmployeeAgents_Button.BackColor = Color.Gold;
            Profile_button.BackColor = Color.White;
        }

    }
}
