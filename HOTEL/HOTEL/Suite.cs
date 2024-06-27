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
    public partial class Suite : Form
    {
        public Suite()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nextsuite1_Click(object sender, EventArgs e)
        {
            var Mainpage = new Suiteadd();
            Mainpage.Show();
            this.Hide();
        }
    }
}
