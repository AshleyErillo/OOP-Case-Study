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
    public partial class Deluxeadd : UserControl
    {
        public Deluxeadd()
        {
            InitializeComponent();
        }

        private void Backdeluxe2_Click(object sender, EventArgs e)
        {
            Delroom back = new Delroom ();
            back.Show();
            this.Hide();    
        }

        private void Nextdeluxeadd2_Click(object sender, EventArgs e)
        {
            var Mainpage = new Deluxeinventory();
            Mainpage.Show();
            this.Hide();
        }
    }
}
