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
    public partial class standardroom : Form
    {
        public standardroom()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NextStandard_Click(object sender, EventArgs e)
        {
            var Mainpage = new Standardadd();
            Mainpage.Show();
            this.Hide();
        }
    }
}
