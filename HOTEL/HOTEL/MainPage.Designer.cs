namespace HOTEL
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Main_Button = new System.Windows.Forms.Label();
            this.Guest_Button = new System.Windows.Forms.Label();
            this.Employee_Button = new System.Windows.Forms.Label();
            this.Dashboard_Button = new System.Windows.Forms.Label();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoPicture_Pic = new System.Windows.Forms.PictureBox();
            this.mainPage_Panel1 = new HOTEL.MainPage_Panel();
            this.Mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Button
            // 
            this.Main_Button.AutoSize = true;
            this.Main_Button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Button.Location = new System.Drawing.Point(446, 17);
            this.Main_Button.Name = "Main_Button";
            this.Main_Button.Size = new System.Drawing.Size(35, 14);
            this.Main_Button.TabIndex = 1;
            this.Main_Button.Text = "Main";
            this.Main_Button.Click += new System.EventHandler(this.Main_Button_Click);
            // 
            // Guest_Button
            // 
            this.Guest_Button.AutoSize = true;
            this.Guest_Button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest_Button.Location = new System.Drawing.Point(497, 17);
            this.Guest_Button.Name = "Guest_Button";
            this.Guest_Button.Size = new System.Drawing.Size(39, 14);
            this.Guest_Button.TabIndex = 2;
            this.Guest_Button.Text = "Guest";
            // 
            // Employee_Button
            // 
            this.Employee_Button.AutoSize = true;
            this.Employee_Button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Button.Location = new System.Drawing.Point(635, 17);
            this.Employee_Button.Name = "Employee_Button";
            this.Employee_Button.Size = new System.Drawing.Size(95, 14);
            this.Employee_Button.TabIndex = 3;
            this.Employee_Button.Text = "Employee Name";
            // 
            // Dashboard_Button
            // 
            this.Dashboard_Button.AutoSize = true;
            this.Dashboard_Button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_Button.Location = new System.Drawing.Point(552, 17);
            this.Dashboard_Button.Name = "Dashboard_Button";
            this.Dashboard_Button.Size = new System.Drawing.Size(67, 14);
            this.Dashboard_Button.TabIndex = 4;
            this.Dashboard_Button.Text = "Dashboard";
            // 
            // Mainpanel
            // 
            this.Mainpanel.Controls.Add(this.mainPage_Panel1);
            this.Mainpanel.Location = new System.Drawing.Point(0, 56);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(801, 395);
            this.Mainpanel.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HOTEL.Properties.Resources.logout_256x256;
            this.pictureBox2.Location = new System.Drawing.Point(763, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HOTEL.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(732, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LogoPicture_Pic
            // 
            this.LogoPicture_Pic.Image = global::HOTEL.Properties.Resources._2;
            this.LogoPicture_Pic.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture_Pic.Name = "LogoPicture_Pic";
            this.LogoPicture_Pic.Size = new System.Drawing.Size(146, 50);
            this.LogoPicture_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture_Pic.TabIndex = 0;
            this.LogoPicture_Pic.TabStop = false;
            // 
            // mainPage_Panel1
            // 
            this.mainPage_Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPage_Panel1.Location = new System.Drawing.Point(-3, 0);
            this.mainPage_Panel1.Name = "mainPage_Panel1";
            this.mainPage_Panel1.Size = new System.Drawing.Size(801, 395);
            this.mainPage_Panel1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dashboard_Button);
            this.Controls.Add(this.Employee_Button);
            this.Controls.Add(this.Guest_Button);
            this.Controls.Add(this.Main_Button);
            this.Controls.Add(this.LogoPicture_Pic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Royal Reef Hotel";
            this.Mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicture_Pic;
        private System.Windows.Forms.Label Main_Button;
        private System.Windows.Forms.Label Guest_Button;
        private System.Windows.Forms.Label Employee_Button;
        private System.Windows.Forms.Label Dashboard_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Mainpanel;
        private MainPage_Panel mainPage_Panel1;
    }
}