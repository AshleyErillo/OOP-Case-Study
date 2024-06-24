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

        public void MainPage_Load(object Form)
        {
            if (this.Mainpanel.Controls.Count > 0) 
                this.Mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(f);
            this.Mainpanel.Tag = f;
            f.Show();
        }

        private void Main_Button_Click(object sender, EventArgs e)
        {
            MainPage_Load(new MainPage_Panel());

        }
    }
}
