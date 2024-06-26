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
    public partial class RoomAssignment : UserControl
    {
        public RoomAssignment()
        {
            InitializeComponent();
        }

        private void Reservations_Label_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckInvoice_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogBoxDelete f2 = new DialogBoxDelete();
            f2.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Search_label_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RoomAssignment_Load(object sender, EventArgs e)
        {

        }
    }
}
