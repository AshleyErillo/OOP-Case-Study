namespace HOTEL
{
    partial class AdminMainpage
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
            this.Dashboard_Button = new System.Windows.Forms.Label();
            this.Employee_Button = new System.Windows.Forms.Label();
            this.Main_Button = new System.Windows.Forms.Label();
            this.LogoPicture_Pic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard_Button
            // 
            this.Dashboard_Button.AutoSize = true;
            this.Dashboard_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboard_Button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_Button.Location = new System.Drawing.Point(563, 22);
            this.Dashboard_Button.Name = "Dashboard_Button";
            this.Dashboard_Button.Size = new System.Drawing.Size(60, 14);
            this.Dashboard_Button.TabIndex = 9;
            this.Dashboard_Button.Text = "Dashboard";
            // 
            // Employee_Button
            // 
            this.Employee_Button.AutoSize = true;
            this.Employee_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Employee_Button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Button.Location = new System.Drawing.Point(634, 22);
            this.Employee_Button.Name = "Employee_Button";
            this.Employee_Button.Size = new System.Drawing.Size(89, 14);
            this.Employee_Button.TabIndex = 8;
            this.Employee_Button.Text = "Employee Name";
            // 
            // Main_Button
            // 
            this.Main_Button.AutoSize = true;
            this.Main_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main_Button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Button.Location = new System.Drawing.Point(518, 22);
            this.Main_Button.Name = "Main_Button";
            this.Main_Button.Size = new System.Drawing.Size(32, 14);
            this.Main_Button.TabIndex = 7;
            this.Main_Button.Text = "Main";
            // 
            // LogoPicture_Pic
            // 
            this.LogoPicture_Pic.Image = global::HOTEL.Properties.Resources._2;
            this.LogoPicture_Pic.Location = new System.Drawing.Point(1, 1);
            this.LogoPicture_Pic.Name = "LogoPicture_Pic";
            this.LogoPicture_Pic.Size = new System.Drawing.Size(146, 50);
            this.LogoPicture_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture_Pic.TabIndex = 12;
            this.LogoPicture_Pic.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HOTEL.Properties.Resources.logout_256x256;
            this.pictureBox2.Location = new System.Drawing.Point(762, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HOTEL.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(731, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoPicture_Pic);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dashboard_Button);
            this.Controls.Add(this.Employee_Button);
            this.Controls.Add(this.Main_Button);
            this.Name = "AdminMainpage";
            this.Text = "AdminMainpage";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Dashboard_Button;
        private System.Windows.Forms.Label Employee_Button;
        private System.Windows.Forms.Label Main_Button;
        private System.Windows.Forms.PictureBox LogoPicture_Pic;
    }
}