namespace ROYAL_REEF_HOTEL
{
    partial class RoyalReefHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoyalReefHotel));
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.Username_Text = new System.Windows.Forms.Label();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Text = new System.Windows.Forms.Label();
            this.ForgotPassword_Text = new System.Windows.Forms.Label();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.ForeColor = System.Drawing.Color.Black;
            this.Username_Textbox.Location = new System.Drawing.Point(352, 227);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(180, 20);
            this.Username_Textbox.TabIndex = 1;
            this.Username_Textbox.UseWaitCursor = true;
            // 
            // Username_Text
            // 
            this.Username_Text.AutoSize = true;
            this.Username_Text.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Username_Text.Location = new System.Drawing.Point(280, 230);
            this.Username_Text.Name = "Username_Text";
            this.Username_Text.Size = new System.Drawing.Size(66, 14);
            this.Username_Text.TabIndex = 2;
            this.Username_Text.Text = "Username:";
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.ForeColor = System.Drawing.Color.Black;
            this.Password_Textbox.Location = new System.Drawing.Point(352, 253);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(180, 20);
            this.Password_Textbox.TabIndex = 3;
            // 
            // Password_Text
            // 
            this.Password_Text.AutoSize = true;
            this.Password_Text.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password_Text.Location = new System.Drawing.Point(283, 256);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(62, 14);
            this.Password_Text.TabIndex = 4;
            this.Password_Text.Text = "Password:";
            // 
            // ForgotPassword_Text
            // 
            this.ForgotPassword_Text.AutoSize = true;
            this.ForgotPassword_Text.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ForgotPassword_Text.Location = new System.Drawing.Point(430, 276);
            this.ForgotPassword_Text.Name = "ForgotPassword_Text";
            this.ForgotPassword_Text.Size = new System.Drawing.Size(102, 14);
            this.ForgotPassword_Text.TabIndex = 5;
            this.ForgotPassword_Text.Text = "Forgot Password?";
            // 
            // LogIn_button
            // 
            this.LogIn_button.BackColor = System.Drawing.Color.SteelBlue;
            this.LogIn_button.Location = new System.Drawing.Point(352, 304);
            this.LogIn_button.Margin = new System.Windows.Forms.Padding(0);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(119, 33);
            this.LogIn_button.TabIndex = 0;
            this.LogIn_button.Text = "Log In";
            this.LogIn_button.UseVisualStyleBackColor = false;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = global::ROYAL_REEF_HOTEL.Properties.Resources.HOTEL2;
            this.PictureLogo.Location = new System.Drawing.Point(282, 94);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(249, 118);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogo.TabIndex = 0;
            this.PictureLogo.TabStop = false;
            // 
            // RoyalReefHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogIn_button);
            this.Controls.Add(this.ForgotPassword_Text);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Username_Text);
            this.Controls.Add(this.Username_Textbox);
            this.Controls.Add(this.PictureLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoyalReefHotel";
            this.Text = "Royal Reef Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.Label Username_Text;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Label Password_Text;
        private System.Windows.Forms.Label ForgotPassword_Text;
        private System.Windows.Forms.Button LogIn_button;
    }
}

