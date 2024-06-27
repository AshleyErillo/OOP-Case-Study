namespace HOTEL
{
    partial class Suite
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
            this.Suitepanel1 = new System.Windows.Forms.Panel();
            this.Buttonsuite = new System.Windows.Forms.Button();
            this.Namesuite2 = new System.Windows.Forms.TextBox();
            this.Namesuite = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.suiteInventory1 = new HOTEL.SuiteInventory();
            this.suiteadd1 = new HOTEL.Suiteadd();
            this.suiteroom1 = new HOTEL.Suiteroom();
            this.Suitepanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Suitepanel1
            // 
            this.Suitepanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Suitepanel1.Controls.Add(this.Buttonsuite);
            this.Suitepanel1.Controls.Add(this.Namesuite2);
            this.Suitepanel1.Controls.Add(this.Namesuite);
            this.Suitepanel1.Controls.Add(this.pictureBox1);
            this.Suitepanel1.Location = new System.Drawing.Point(4, 3);
            this.Suitepanel1.Name = "Suitepanel1";
            this.Suitepanel1.Size = new System.Drawing.Size(181, 555);
            this.Suitepanel1.TabIndex = 0;
            // 
            // Buttonsuite
            // 
            this.Buttonsuite.BackColor = System.Drawing.Color.Gold;
            this.Buttonsuite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buttonsuite.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonsuite.Location = new System.Drawing.Point(2, 132);
            this.Buttonsuite.Name = "Buttonsuite";
            this.Buttonsuite.Size = new System.Drawing.Size(176, 46);
            this.Buttonsuite.TabIndex = 3;
            this.Buttonsuite.Text = "Room 101 Floor 1";
            this.Buttonsuite.UseVisualStyleBackColor = false;
            // 
            // Namesuite2
            // 
            this.Namesuite2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Namesuite2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Namesuite2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namesuite2.Location = new System.Drawing.Point(2, 98);
            this.Namesuite2.Name = "Namesuite2";
            this.Namesuite2.Size = new System.Drawing.Size(176, 29);
            this.Namesuite2.TabIndex = 2;
            this.Namesuite2.Text = "Available";
            // 
            // Namesuite
            // 
            this.Namesuite.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Namesuite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Namesuite.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namesuite.Location = new System.Drawing.Point(1, 67);
            this.Namesuite.Name = "Namesuite";
            this.Namesuite.Size = new System.Drawing.Size(176, 29);
            this.Namesuite.TabIndex = 1;
            this.Namesuite.Text = "Suite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HOTEL.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // suiteInventory1
            // 
            this.suiteInventory1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.suiteInventory1.Location = new System.Drawing.Point(187, 3);
            this.suiteInventory1.Name = "suiteInventory1";
            this.suiteInventory1.Size = new System.Drawing.Size(889, 555);
            this.suiteInventory1.TabIndex = 1;
            // 
            // suiteadd1
            // 
            this.suiteadd1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.suiteadd1.Location = new System.Drawing.Point(186, 3);
            this.suiteadd1.Name = "suiteadd1";
            this.suiteadd1.Size = new System.Drawing.Size(890, 559);
            this.suiteadd1.TabIndex = 2;
            // 
            // suiteroom1
            // 
            this.suiteroom1.Location = new System.Drawing.Point(186, 3);
            this.suiteroom1.Name = "suiteroom1";
            this.suiteroom1.Size = new System.Drawing.Size(890, 555);
            this.suiteroom1.TabIndex = 3;
            // 
            // Suite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 561);
            this.Controls.Add(this.suiteroom1);
            this.Controls.Add(this.suiteadd1);
            this.Controls.Add(this.suiteInventory1);
            this.Controls.Add(this.Suitepanel1);
            this.Name = "Suite";
            this.Text = "Suite";
            this.Suitepanel1.ResumeLayout(false);
            this.Suitepanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Suitepanel1;
        private System.Windows.Forms.TextBox Namesuite2;
        private System.Windows.Forms.TextBox Namesuite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Buttonsuite;
        private SuiteInventory suiteInventory1;
        private Suiteadd suiteadd1;
        private Suiteroom suiteroom1;
    }
}