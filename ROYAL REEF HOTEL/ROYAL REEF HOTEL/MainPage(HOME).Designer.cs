namespace ROYAL_REEF_HOTEL
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MainPage = new System.Windows.Forms.Label();
            this.GuestPage = new System.Windows.Forms.Label();
            this.DashboardPage = new System.Windows.Forms.Label();
            this.UserEmployee = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogOut_Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPagePanel1 = new ROYAL_REEF_HOTEL.MainPagePanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOut_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPage
            // 
            this.MainPage.AutoSize = true;
            this.MainPage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.Location = new System.Drawing.Point(462, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(36, 15);
            this.MainPage.TabIndex = 2;
            this.MainPage.Text = "Main";
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // GuestPage
            // 
            this.GuestPage.AutoSize = true;
            this.GuestPage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestPage.Location = new System.Drawing.Point(504, 22);
            this.GuestPage.Name = "GuestPage";
            this.GuestPage.Size = new System.Drawing.Size(38, 15);
            this.GuestPage.TabIndex = 3;
            this.GuestPage.Text = "Guest";
            this.GuestPage.Click += new System.EventHandler(this.GuestPage_Click);
            // 
            // DashboardPage
            // 
            this.DashboardPage.AutoSize = true;
            this.DashboardPage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardPage.Location = new System.Drawing.Point(548, 22);
            this.DashboardPage.Name = "DashboardPage";
            this.DashboardPage.Size = new System.Drawing.Size(68, 15);
            this.DashboardPage.TabIndex = 4;
            this.DashboardPage.Tag = "";
            this.DashboardPage.Text = "Dashboard";
            // 
            // UserEmployee
            // 
            this.UserEmployee.AutoSize = true;
            this.UserEmployee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmployee.Location = new System.Drawing.Point(622, 22);
            this.UserEmployee.Name = "UserEmployee";
            this.UserEmployee.Size = new System.Drawing.Size(101, 15);
            this.UserEmployee.TabIndex = 5;
            this.UserEmployee.Tag = "";
            this.UserEmployee.Text = "(Employee Name)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ROYAL_REEF_HOTEL.Properties.Resources.user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(729, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // LogOut_Icon
            // 
            this.LogOut_Icon.Image = global::ROYAL_REEF_HOTEL.Properties.Resources.logout_256x256;
            this.LogOut_Icon.Location = new System.Drawing.Point(764, 19);
            this.LogOut_Icon.Name = "LogOut_Icon";
            this.LogOut_Icon.Size = new System.Drawing.Size(20, 20);
            this.LogOut_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOut_Icon.TabIndex = 6;
            this.LogOut_Icon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ROYAL_REEF_HOTEL.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPagePanel1
            // 
            this.mainPagePanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPagePanel1.Location = new System.Drawing.Point(0, 56);
            this.mainPagePanel1.Name = "mainPagePanel1";
            this.mainPagePanel1.Size = new System.Drawing.Size(800, 395);
            this.mainPagePanel1.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPagePanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LogOut_Icon);
            this.Controls.Add(this.UserEmployee);
            this.Controls.Add(this.DashboardPage);
            this.Controls.Add(this.GuestPage);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Royal Reef Hotel";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOut_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainPage;
        private System.Windows.Forms.Label GuestPage;
        private System.Windows.Forms.Label DashboardPage;
        private System.Windows.Forms.Label UserEmployee;
        private System.Windows.Forms.PictureBox LogOut_Icon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MainPagePanel mainPagePanel1;
    }
}