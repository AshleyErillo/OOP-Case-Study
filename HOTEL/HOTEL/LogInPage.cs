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
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            string Username, Password;
            Username = Username_Textbox.Text;
            Password = Password_Textbox.Text;

            if (Username == "Admin123" || Password == "12345678")
            {
                var mainpage = new MainPage();
                mainpage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error! Try Again.");
            }
        }

    }
}
