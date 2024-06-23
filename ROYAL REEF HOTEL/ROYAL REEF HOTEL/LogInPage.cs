using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROYAL_REEF_HOTEL
{
    public partial class RoyalReefHotel : Form
    {
        public RoyalReefHotel()
        {
            InitializeComponent();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            string Username, Password;
            Username = Username_Textbox.Text;
            Password = Password_Textbox.Text;

            //if (Username == "Admin123" || Password == "12345678")
            {
                var mainpage = new Form2();
                mainpage.Show();
                this.Hide();
            }
            //else
            {
                MessageBox.Show("Error! Try Again.");
            }
        }
    }
}
