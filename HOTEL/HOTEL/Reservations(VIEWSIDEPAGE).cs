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
    public partial class Reservations_VIEWSIDEPAGE_ : UserControl
    {
        public Reservations_VIEWSIDEPAGE_()
        {
            InitializeComponent();
        }

        private void Reservations_VIEWSIDEPAGE__Click(object sender, EventArgs e)
        {
            ReservationsPANEL pANEL = new ReservationsPANEL();
            pANEL.Show();
        }
    }
}
