namespace ROYAL_REEF_HOTEL
{
    partial class MainPagePanel
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
            this.Header = new System.Windows.Forms.Label();
            this.Header2 = new System.Windows.Forms.Label();
            this.CheckInsOverallCount = new System.Windows.Forms.Label();
            this.CheckInsOverallCount2 = new System.Windows.Forms.Label();
            this.DashboardNavi2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Header.Location = new System.Drawing.Point(246, 66);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(333, 25);
            this.Header.TabIndex = 0;
            this.Header.Text = "\"Effortlessly plan, book, and manage\r\n";
            // 
            // Header2
            // 
            this.Header2.AutoSize = true;
            this.Header2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Header2.Location = new System.Drawing.Point(208, 91);
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(409, 25);
            this.Header2.TabIndex = 1;
            this.Header2.Text = "your business lodging with Royal Reef Hotel.\"";
            // 
            // CheckInsOverallCount
            // 
            this.CheckInsOverallCount.AutoSize = true;
            this.CheckInsOverallCount.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInsOverallCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CheckInsOverallCount.Location = new System.Drawing.Point(320, 130);
            this.CheckInsOverallCount.Name = "CheckInsOverallCount";
            this.CheckInsOverallCount.Size = new System.Drawing.Size(184, 75);
            this.CheckInsOverallCount.TabIndex = 2;
            this.CheckInsOverallCount.Text = "0000";
            // 
            // CheckInsOverallCount2
            // 
            this.CheckInsOverallCount2.AutoSize = true;
            this.CheckInsOverallCount2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInsOverallCount2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CheckInsOverallCount2.Location = new System.Drawing.Point(383, 198);
            this.CheckInsOverallCount2.Name = "CheckInsOverallCount2";
            this.CheckInsOverallCount2.Size = new System.Drawing.Size(58, 15);
            this.CheckInsOverallCount2.TabIndex = 3;
            this.CheckInsOverallCount2.Text = "Check Ins";
            // 
            // DashboardNavi2
            // 
            this.DashboardNavi2.BackColor = System.Drawing.Color.MidnightBlue;
            this.DashboardNavi2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardNavi2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DashboardNavi2.Location = new System.Drawing.Point(298, 232);
            this.DashboardNavi2.Name = "DashboardNavi2";
            this.DashboardNavi2.Size = new System.Drawing.Size(229, 62);
            this.DashboardNavi2.TabIndex = 5;
            this.DashboardNavi2.Text = "Check Available Rooms";
            this.DashboardNavi2.UseVisualStyleBackColor = false;
            // 
            // MainPagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.DashboardNavi2);
            this.Controls.Add(this.CheckInsOverallCount2);
            this.Controls.Add(this.CheckInsOverallCount);
            this.Controls.Add(this.Header2);
            this.Controls.Add(this.Header);
            this.Name = "MainPagePanel";
            this.Size = new System.Drawing.Size(800, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label Header2;
        private System.Windows.Forms.Label CheckInsOverallCount;
        private System.Windows.Forms.Label CheckInsOverallCount2;
        private System.Windows.Forms.Button DashboardNavi2;
    }
}
