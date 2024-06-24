namespace HOTEL
{
    partial class EmployeePanel
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
            this.EmployeeAgents_Button = new System.Windows.Forms.Button();
            this.Profile_button = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myProfile1 = new HOTEL.MyProfile();
            this.employeePage_EMPLOYEE_AGENTS_1 = new HOTEL.EmployeePage_EMPLOYEE_AGENTS_();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EmployeeAgents_Button);
            this.panel2.Controls.Add(this.Profile_button);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 388);
            this.panel2.TabIndex = 2;
            // 
            // EmployeeAgents_Button
            // 
            this.EmployeeAgents_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.EmployeeAgents_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeAgents_Button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeAgents_Button.Location = new System.Drawing.Point(3, 46);
            this.EmployeeAgents_Button.Name = "EmployeeAgents_Button";
            this.EmployeeAgents_Button.Size = new System.Drawing.Size(132, 37);
            this.EmployeeAgents_Button.TabIndex = 1;
            this.EmployeeAgents_Button.Text = "Employee Agents";
            this.EmployeeAgents_Button.UseVisualStyleBackColor = true;
            this.EmployeeAgents_Button.Click += new System.EventHandler(this.EmployeeAgents_Button_Click);
            // 
            // Profile_button
            // 
            this.Profile_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_button.Location = new System.Drawing.Point(3, 3);
            this.Profile_button.Name = "Profile_button";
            this.Profile_button.Size = new System.Drawing.Size(132, 37);
            this.Profile_button.TabIndex = 0;
            this.Profile_button.Text = "My Profile";
            this.Profile_button.UseVisualStyleBackColor = true;
            this.Profile_button.Click += new System.EventHandler(this.Profile_button_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(144, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 388);
            this.vScrollBar1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.myProfile1);
            this.panel1.Controls.Add(this.employeePage_EMPLOYEE_AGENTS_1);
            this.panel1.Location = new System.Drawing.Point(164, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 388);
            this.panel1.TabIndex = 4;
            // 
            // myProfile1
            // 
            this.myProfile1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myProfile1.Location = new System.Drawing.Point(0, 1);
            this.myProfile1.Name = "myProfile1";
            this.myProfile1.Size = new System.Drawing.Size(637, 388);
            this.myProfile1.TabIndex = 0;
            // 
            // employeePage_EMPLOYEE_AGENTS_1
            // 
            this.employeePage_EMPLOYEE_AGENTS_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeePage_EMPLOYEE_AGENTS_1.Location = new System.Drawing.Point(0, 0);
            this.employeePage_EMPLOYEE_AGENTS_1.Name = "employeePage_EMPLOYEE_AGENTS_1";
            this.employeePage_EMPLOYEE_AGENTS_1.Size = new System.Drawing.Size(637, 388);
            this.employeePage_EMPLOYEE_AGENTS_1.TabIndex = 1;
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel2);
            this.Name = "EmployeePanel";
            this.Size = new System.Drawing.Size(801, 395);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EmployeeAgents_Button;
        private System.Windows.Forms.Button Profile_button;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private MyProfile myProfile1;
        private EmployeePage_EMPLOYEE_AGENTS_ employeePage_EMPLOYEE_AGENTS_1;
    }
}
