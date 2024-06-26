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
    public partial class GuestPagePanel : UserControl
    {
        public GuestPagePanel()
        {
            InitializeComponent();
        }

        private void Guest_button_Click(object sender, EventArgs e)
        {
            guestPanel_VIEW_2.Show();
            guest_FeedbackPanel_VIEW_3.Hide();

            Guest_button.BackColor = Color.Gold;
            Feedback_Button.BackColor = Color.White;
        }


        private void Feedback_Button_Click(object sender, EventArgs e)
        {
            guest_FeedbackPanel_VIEW_3.Show();
            guestPanel_VIEW_2.Hide();

            Feedback_Button.BackColor = Color.Gold;
            Guest_button.BackColor = Color.White;
        }

    }
}
