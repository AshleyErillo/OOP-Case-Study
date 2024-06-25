namespace HOTEL
{
    partial class Dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Reservations_Label = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reservations_VIEWSIDEPAGE_1 = new HOTEL.Reservations_VIEWSIDEPAGE_();
            this.reservationsPANEL1 = new HOTEL.ReservationsPANEL();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.Reservations_Label);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 388);
            this.panel2.TabIndex = 3;
            // 
            // Reservations_Label
            // 
            this.Reservations_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reservations_Label.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Reservations_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reservations_Label.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservations_Label.Location = new System.Drawing.Point(3, 3);
            this.Reservations_Label.Name = "Reservations_Label";
            this.Reservations_Label.Size = new System.Drawing.Size(132, 37);
            this.Reservations_Label.TabIndex = 0;
            this.Reservations_Label.Text = "Reservations";
            this.Reservations_Label.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vScrollBar1.Location = new System.Drawing.Point(142, 4);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 388);
            this.vScrollBar1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.reservations_VIEWSIDEPAGE_1);
            this.panel1.Controls.Add(this.reservationsPANEL1);
            this.panel1.Location = new System.Drawing.Point(161, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 388);
            this.panel1.TabIndex = 5;
            // 
            // reservations_VIEWSIDEPAGE_1
            // 
            this.reservations_VIEWSIDEPAGE_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservations_VIEWSIDEPAGE_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_VIEWSIDEPAGE_1.Location = new System.Drawing.Point(268, -4);
            this.reservations_VIEWSIDEPAGE_1.Name = "reservations_VIEWSIDEPAGE_1";
            this.reservations_VIEWSIDEPAGE_1.Size = new System.Drawing.Size(372, 386);
            this.reservations_VIEWSIDEPAGE_1.TabIndex = 1;
            // 
            // reservationsPANEL1
            // 
            this.reservationsPANEL1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservationsPANEL1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservationsPANEL1.Location = new System.Drawing.Point(0, -1);
            this.reservationsPANEL1.Name = "reservationsPANEL1";
            this.reservationsPANEL1.Size = new System.Drawing.Size(637, 388);
            this.reservationsPANEL1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(801, 395);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Reservations_Label;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private Reservations_VIEWSIDEPAGE_ reservations_VIEWSIDEPAGE_1;
        private ReservationsPANEL reservationsPANEL1;
    }
}
