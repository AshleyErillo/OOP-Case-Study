namespace HOTEL
{
    partial class GuestPagePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.QRCode_Feedback = new System.Windows.Forms.PictureBox();
            this.Feedback_Button = new System.Windows.Forms.Button();
            this.Guest_button = new System.Windows.Forms.Button();
            this.GuestPanel = new HOTEL.GuestPanel_VIEW_();
            this.guest_FeedbackPanel_VIEW_1 = new HOTEL.Guest_FeedbackPanel_VIEW_();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode_Feedback)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GuestPanel);
            this.panel1.Controls.Add(this.guest_FeedbackPanel_VIEW_1);
            this.panel1.Location = new System.Drawing.Point(161, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 388);
            this.panel1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(141, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 388);
            this.vScrollBar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.QRCode_Feedback);
            this.panel2.Controls.Add(this.Feedback_Button);
            this.panel2.Controls.Add(this.Guest_button);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 388);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scan for feedback";
            // 
            // QRCode_Feedback
            // 
            this.QRCode_Feedback.Image = global::HOTEL.Properties.Resources.HOTEL__1_;
            this.QRCode_Feedback.Location = new System.Drawing.Point(3, 219);
            this.QRCode_Feedback.Name = "QRCode_Feedback";
            this.QRCode_Feedback.Size = new System.Drawing.Size(130, 130);
            this.QRCode_Feedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRCode_Feedback.TabIndex = 0;
            this.QRCode_Feedback.TabStop = false;
            // 
            // Feedback_Button
            // 
            this.Feedback_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Feedback_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Feedback_Button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback_Button.Location = new System.Drawing.Point(3, 46);
            this.Feedback_Button.Name = "Feedback_Button";
            this.Feedback_Button.Size = new System.Drawing.Size(132, 37);
            this.Feedback_Button.TabIndex = 1;
            this.Feedback_Button.Text = "Feedback";
            this.Feedback_Button.UseVisualStyleBackColor = true;
            this.Feedback_Button.Click += new System.EventHandler(this.Feedback_Button_Click);
            // 
            // Guest_button
            // 
            this.Guest_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Guest_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guest_button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest_button.Location = new System.Drawing.Point(3, 3);
            this.Guest_button.Name = "Guest_button";
            this.Guest_button.Size = new System.Drawing.Size(132, 37);
            this.Guest_button.TabIndex = 0;
            this.Guest_button.Text = "Guest";
            this.Guest_button.UseVisualStyleBackColor = true;
            this.Guest_button.Click += new System.EventHandler(this.Guest_button_Click);
            // 
            // GuestPanel
            // 
            this.GuestPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GuestPanel.Location = new System.Drawing.Point(0, 0);
            this.GuestPanel.Name = "GuestPanel";
            this.GuestPanel.Size = new System.Drawing.Size(637, 388);
            this.GuestPanel.TabIndex = 1;
            this.GuestPanel.Load += new System.EventHandler(this.GuestPanel_Load);
            // 
            // guest_FeedbackPanel_VIEW_1
            // 
            this.guest_FeedbackPanel_VIEW_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guest_FeedbackPanel_VIEW_1.Location = new System.Drawing.Point(0, 0);
            this.guest_FeedbackPanel_VIEW_1.Name = "guest_FeedbackPanel_VIEW_1";
            this.guest_FeedbackPanel_VIEW_1.Size = new System.Drawing.Size(637, 388);
            this.guest_FeedbackPanel_VIEW_1.TabIndex = 0;
            // 
            // GuestPagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GuestPagePanel";
            this.Size = new System.Drawing.Size(801, 395);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode_Feedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Guest_button;
        private System.Windows.Forms.PictureBox QRCode_Feedback;
        private System.Windows.Forms.Button Feedback_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private GuestPanel_VIEW_ GuestPanel;
        private Guest_FeedbackPanel_VIEW_ guest_FeedbackPanel_VIEW_1;
    }
}
