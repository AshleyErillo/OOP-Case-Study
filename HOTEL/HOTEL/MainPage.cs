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
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public object PanelContainer { get; private set; }

        public void MainPage_Load(object sender, EventArgs e)
        {
            mainPage_Panel1.Show();
            guestPagePanel1.Hide();
            employeePanel1.Hide();
            dashboard1.Hide();
        }

        private void Main_Button_Click(object sender, EventArgs e)
        {
            mainPage_Panel1.Show();
            guestPagePanel1.Hide();
            employeePanel1.Hide();
            dashboard1.Hide();

            Main_Button.ForeColor = Color.RoyalBlue;
            Main_Button.Font = new Font("Calibri", 9, FontStyle.Bold);
            Guest_Button.ForeColor = Color.Black;
            Employee_Button.ForeColor = Color.Black;
            Dashboard_Button.ForeColor = Color.Black;
        }

        private void Guest_Button_Click(object sender, EventArgs e)
        {
            mainPage_Panel1.Hide();
            guestPagePanel1.Show();
            employeePanel1.Hide();
            dashboard1.Hide();

            Main_Button.ForeColor = Color.Black;
            Guest_Button.ForeColor = Color.RoyalBlue;
            Guest_Button.Font = new Font("Calibri", 9, FontStyle.Bold);
            Employee_Button.ForeColor = Color.Black;
            Dashboard_Button.ForeColor = Color.Black;
        }

        private void Employee_Button_Click(object sender, EventArgs e)
        {
            mainPage_Panel1.Hide();
            guestPagePanel1.Hide();
            employeePanel1.Show();
            dashboard1.Hide();

            Main_Button.ForeColor = Color.Black;
            Guest_Button.ForeColor = Color.Black;
            Dashboard_Button.ForeColor = Color.Black;
            Employee_Button.ForeColor = Color.RoyalBlue;
            Employee_Button.Font = new Font("Calibri", 9, FontStyle.Bold);

        }

        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            mainPage_Panel1.Hide();
            guestPagePanel1.Hide();
            employeePanel1.Hide();

            Main_Button.ForeColor = Color.Black;
            Guest_Button.ForeColor = Color.Black;
            Employee_Button.ForeColor = Color.Black;
            Dashboard_Button.ForeColor = Color.RoyalBlue;
            Dashboard_Button.Font = new Font("Calibri", 9, FontStyle.Bold);

        }

        private void MainPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
