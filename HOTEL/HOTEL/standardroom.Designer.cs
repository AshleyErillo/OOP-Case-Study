namespace HOTEL
{
    partial class standardroom
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
            this.StandardPanel = new System.Windows.Forms.Panel();
            this.NameStandard2 = new System.Windows.Forms.TextBox();
            this.Namestandard = new System.Windows.Forms.TextBox();
            this.Buttonstandard = new System.Windows.Forms.Button();
            this.Logo1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stanroom3 = new HOTEL.Stanroom();
            this.standardadd3 = new HOTEL.Standardadd();
            this.Staninven2 = new HOTEL.Standardinventory();
            this.StandardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StandardPanel
            // 
            this.StandardPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StandardPanel.Controls.Add(this.NameStandard2);
            this.StandardPanel.Controls.Add(this.Namestandard);
            this.StandardPanel.Controls.Add(this.Buttonstandard);
            this.StandardPanel.Controls.Add(this.Logo1);
            this.StandardPanel.Location = new System.Drawing.Point(4, 3);
            this.StandardPanel.Name = "StandardPanel";
            this.StandardPanel.Size = new System.Drawing.Size(181, 555);
            this.StandardPanel.TabIndex = 0;
            // 
            // NameStandard2
            // 
            this.NameStandard2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameStandard2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameStandard2.Location = new System.Drawing.Point(2, 98);
            this.NameStandard2.Name = "NameStandard2";
            this.NameStandard2.Size = new System.Drawing.Size(176, 25);
            this.NameStandard2.TabIndex = 3;
            this.NameStandard2.Text = "Available";
            // 
            // Namestandard
            // 
            this.Namestandard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Namestandard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namestandard.Location = new System.Drawing.Point(1, 67);
            this.Namestandard.Name = "Namestandard";
            this.Namestandard.Size = new System.Drawing.Size(176, 25);
            this.Namestandard.TabIndex = 2;
            this.Namestandard.Text = "Standard Room";
            // 
            // Buttonstandard
            // 
            this.Buttonstandard.BackColor = System.Drawing.Color.Gold;
            this.Buttonstandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buttonstandard.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonstandard.Location = new System.Drawing.Point(2, 132);
            this.Buttonstandard.Name = "Buttonstandard";
            this.Buttonstandard.Size = new System.Drawing.Size(176, 46);
            this.Buttonstandard.TabIndex = 1;
            this.Buttonstandard.Text = "Room 101 Floor1";
            this.Buttonstandard.UseVisualStyleBackColor = false;
            this.Buttonstandard.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Logo1
            // 
            this.Logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo1.Image = global::HOTEL.Properties.Resources._2;
            this.Logo1.Location = new System.Drawing.Point(1, 1);
            this.Logo1.Name = "Logo1";
            this.Logo1.Size = new System.Drawing.Size(179, 60);
            this.Logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo1.TabIndex = 0;
            this.Logo1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stanroom3);
            this.panel1.Controls.Add(this.standardadd3);
            this.panel1.Controls.Add(this.Staninven2);
            this.panel1.Location = new System.Drawing.Point(191, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 554);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint_1);
            // 
            // stanroom3
            // 
            this.stanroom3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stanroom3.Location = new System.Drawing.Point(0, 0);
            this.stanroom3.Name = "stanroom3";
            this.stanroom3.Size = new System.Drawing.Size(890, 559);
            this.stanroom3.TabIndex = 0;
            // 
            // standardadd3
            // 
            this.standardadd3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.standardadd3.Location = new System.Drawing.Point(0, 0);
            this.standardadd3.Name = "standardadd3";
            this.standardadd3.Size = new System.Drawing.Size(890, 559);
            this.standardadd3.TabIndex = 1;
            // 
            // Staninven2
            // 
            this.Staninven2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Staninven2.Location = new System.Drawing.Point(-4, -1);
            this.Staninven2.Name = "Staninven2";
            this.Staninven2.Size = new System.Drawing.Size(889, 555);
            this.Staninven2.TabIndex = 2;
            // 
            // standardroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StandardPanel);
            this.Name = "standardroom";
            this.Text = "standardroom";
            this.StandardPanel.ResumeLayout(false);
            this.StandardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StandardPanel;
        private System.Windows.Forms.PictureBox Logo1;
        private System.Windows.Forms.Button Buttonstandard;
        private System.Windows.Forms.TextBox Namestandard;
        private System.Windows.Forms.TextBox NameStandard2;
        private System.Windows.Forms.Panel panel1;
        private Stanroom stanroom3;
        private Standardadd standardadd3;
        private Standardinventory Staninven2;
    }
}