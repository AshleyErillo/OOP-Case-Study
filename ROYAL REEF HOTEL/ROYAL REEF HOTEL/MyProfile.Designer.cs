namespace ROYAL_REEF_HOTEL
{
    partial class MyProfile
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
            this.ProfileView = new System.Windows.Forms.Button();
            this.EmployeeAgentsPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfileView
            // 
            this.ProfileView.Location = new System.Drawing.Point(3, 3);
            this.ProfileView.Name = "ProfileView";
            this.ProfileView.Size = new System.Drawing.Size(140, 36);
            this.ProfileView.TabIndex = 0;
            this.ProfileView.Text = "My Profile";
            this.ProfileView.UseVisualStyleBackColor = true;
            // 
            // EmployeeAgentsPage
            // 
            this.EmployeeAgentsPage.Location = new System.Drawing.Point(3, 45);
            this.EmployeeAgentsPage.Name = "EmployeeAgentsPage";
            this.EmployeeAgentsPage.Size = new System.Drawing.Size(140, 36);
            this.EmployeeAgentsPage.TabIndex = 1;
            this.EmployeeAgentsPage.Text = "Employee Agents";
            this.EmployeeAgentsPage.UseVisualStyleBackColor = true;
            // 
            // GuestPagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.EmployeeAgentsPage);
            this.Controls.Add(this.ProfileView);
            this.Name = "GuestPagePanel";
            this.Size = new System.Drawing.Size(800, 395);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ProfileView;
        private System.Windows.Forms.Button EmployeeAgentsPage;
    }
}
