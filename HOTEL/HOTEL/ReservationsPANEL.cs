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
    public partial class ReservationsPANEL : UserControl
    {
        public ReservationsPANEL()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditReservation f2 = new  EditReservation();
            f2.Show();


        }

        private void CheckInvoice_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogBoxDelete f2 = new DialogBoxDelete();
            f2.Show();
        }
    }
}
