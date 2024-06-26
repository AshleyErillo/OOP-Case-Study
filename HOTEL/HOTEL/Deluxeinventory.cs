using System;
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
    public partial class Deluxeinventory : UserControl
    {
        public Deluxeinventory()
        {
            InitializeComponent();
        }

        private void Backdeluxe3_Click(object sender, EventArgs e)
        {
            var Mainpage = new deluxeadd();
            Mainpage.Show();
            this.Hide();
        }

        private void Nextbutton3_Click(object sender, EventArgs e)
        {
            var Mainpage = new ReservationForm();
            Mainpage.Show();
            this.Hide();
        }
    }
}
