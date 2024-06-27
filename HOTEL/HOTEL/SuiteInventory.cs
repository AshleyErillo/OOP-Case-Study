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
    public partial class SuiteInventory : UserControl
    {
        public SuiteInventory()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Backsuite3_Click(object sender, EventArgs e)
        {
            Suiteadd back = new Suiteadd();
            back.Show();
            this.Hide();
        }

        private void Nextsuite3_Click(object sender, EventArgs e)
        {
            var Mainpage = new ReservationForm();
            Mainpage.Show();
            this.Hide();
        }
    }
}
