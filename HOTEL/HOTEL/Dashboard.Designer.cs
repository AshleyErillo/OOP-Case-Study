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
            this.Bdash = new System.Windows.Forms.Button();
            this.Reservations_Label = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dashboardView1 = new HOTEL.DashboardView();
            this.reservationsPANEL1 = new HOTEL.ReservationsPANEL();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Bdash);
            this.panel2.Controls.Add(this.Reservations_Label);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 478);
            this.panel2.TabIndex = 3;
            // 
            // Bdash
            // 
            this.Bdash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bdash.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdash.Location = new System.Drawing.Point(4, 57);
            this.Bdash.Name = "Bdash";
            this.Bdash.Size = new System.Drawing.Size(176, 46);
            this.Bdash.TabIndex = 1;
            this.Bdash.Text = "Dashboard";
            this.Bdash.UseVisualStyleBackColor = true;
            this.Bdash.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Reservations_Label
            // 
            this.Reservations_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reservations_Label.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Reservations_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reservations_Label.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservations_Label.Location = new System.Drawing.Point(4, 4);
            this.Reservations_Label.Margin = new System.Windows.Forms.Padding(4);
            this.Reservations_Label.Name = "Reservations_Label";
            this.Reservations_Label.Size = new System.Drawing.Size(176, 46);
            this.Reservations_Label.TabIndex = 0;
            this.Reservations_Label.Text = "Reservations";
            this.Reservations_Label.UseVisualStyleBackColor = true;
            this.Reservations_Label.Click += new System.EventHandler(this.Reservations_Label_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.vScrollBar1.Location = new System.Drawing.Point(189, 5);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 478);
            this.vScrollBar1.TabIndex = 4;
            // 
            // dashboardView1
            // 
            this.dashboardView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardView1.Location = new System.Drawing.Point(209, 5);
            this.dashboardView1.Name = "dashboardView1";
            this.dashboardView1.Size = new System.Drawing.Size(849, 478);
            this.dashboardView1.TabIndex = 5;
            this.dashboardView1.Load += new System.EventHandler(this.DashboardView1_Load);
            // 
            // reservationsPANEL1
            // 
            this.reservationsPANEL1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservationsPANEL1.Location = new System.Drawing.Point(210, 4);
            this.reservationsPANEL1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservationsPANEL1.Name = "reservationsPANEL1";
            this.reservationsPANEL1.Size = new System.Drawing.Size(849, 478);
            this.reservationsPANEL1.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dashboardView1);
            this.Controls.Add(this.reservationsPANEL1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1068, 486);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Reservations_Label;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button Bdash;
        private DashboardView dashboardView1;
        private ReservationsPANEL reservationsPANEL1;
    }
}
