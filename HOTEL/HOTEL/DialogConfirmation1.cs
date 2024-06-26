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
    public partial class DialogConfirmation1 : Form
    {
        public DialogConfirmation1()
        {
            InitializeComponent();
        }

        private void DialogConfirmation1_Load(object sender, EventArgs e)
        {

        }

        private void MyProfileHeader_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployees f2 = new AddEmployees();
            f2.Show();


        }
        
    }
}
