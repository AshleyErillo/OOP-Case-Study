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
    public partial class Suiteadd : UserControl
    {
        public Suiteadd()
        {
            InitializeComponent();
        }

        private void Backsuite2_Click(object sender, EventArgs e)
        {
            var Mainpage = new Suite();
            Mainpage.Show();
            this.Hide();
        }

        private void Nextsuite2_Click(object sender, EventArgs e)
        {
            var Mainpage = new SuiteInventory();
            Mainpage.Show();
            this.Hide();
        }
    }
}
