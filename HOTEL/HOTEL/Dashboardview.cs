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
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Titleavail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pstandard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pdeluxe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panelperweek_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panelguesttoday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Psuite_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Paneltotalcheckins_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panelavailroom_Paint(object sender, PaintEventArgs e)
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
