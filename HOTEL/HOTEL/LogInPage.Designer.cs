namespace HOTEL
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Username_Text = new System.Windows.Forms.Label();
            this.Password_Text = new System.Windows.Forms.Label();
            this.ForgotPassword_Label = new System.Windows.Forms.Label();
            this.LogIn_Button = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_Textbox.Location = new System.Drawing.Point(327, 226);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(200, 20);
            this.Username_Textbox.TabIndex = 1;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password_Textbox.Location = new System.Drawing.Point(327, 261);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(200, 20);
            this.Password_Textbox.TabIndex = 2;
            // 
            // Username_Text
            // 
            this.Username_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_Text.AutoSize = true;
            this.Username_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Username_Text.Location = new System.Drawing.Point(253, 229);
            this.Username_Text.Name = "Username_Text";
            this.Username_Text.Size = new System.Drawing.Size(68, 15);
            this.Username_Text.TabIndex = 3;
            this.Username_Text.Text = "Username:";
            // 
            // Password_Text
            // 
            this.Password_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password_Text.AutoSize = true;
            this.Password_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password_Text.Location = new System.Drawing.Point(253, 264);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(64, 15);
            this.Password_Text.TabIndex = 4;
            this.Password_Text.Text = "Password:";
            // 
            // ForgotPassword_Label
            // 
            this.ForgotPassword_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForgotPassword_Label.AutoSize = true;
            this.ForgotPassword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ForgotPassword_Label.Location = new System.Drawing.Point(421, 284);
            this.ForgotPassword_Label.Name = "ForgotPassword_Label";
            this.ForgotPassword_Label.Size = new System.Drawing.Size(106, 15);
            this.ForgotPassword_Label.TabIndex = 5;
            this.ForgotPassword_Label.Text = "Forgot Password?";
            // 
            // LogIn_Button
            // 
            this.LogIn_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogIn_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogIn_Button.FlatAppearance.BorderSize = 0;
            this.LogIn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_Button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogIn_Button.Location = new System.Drawing.Point(340, 316);
            this.LogIn_Button.Name = "LogIn_Button";
            this.LogIn_Button.Size = new System.Drawing.Size(120, 39);
            this.LogIn_Button.TabIndex = 6;
            this.LogIn_Button.Text = "Log In";
            this.LogIn_Button.UseVisualStyleBackColor = false;
            this.LogIn_Button.Click += new System.EventHandler(this.LogIn_Button_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoPicture.Image = global::HOTEL.Properties.Resources.HOTEL;
            this.LogoPicture.Location = new System.Drawing.Point(256, 101);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(271, 114);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogIn_Button);
            this.Controls.Add(this.ForgotPassword_Label);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.Username_Text);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Username_Textbox);
            this.Controls.Add(this.LogoPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInPage";
            this.Text = "Royal Reef Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Label Username_Text;
        private System.Windows.Forms.Label Password_Text;
        private System.Windows.Forms.Label ForgotPassword_Label;
        private System.Windows.Forms.Button LogIn_Button;
    }
}

