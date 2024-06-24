namespace HOTEL
{
    partial class Guest_FeedbackPanel_VIEW_
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
            this.FeedbackHeader = new System.Windows.Forms.Label();
            this.FeedbackBox = new System.Windows.Forms.GroupBox();
            this.GuestName = new System.Windows.Forms.Label();
            this.Category_Label = new System.Windows.Forms.Label();
            this.GuestRating = new System.Windows.Forms.Label();
            this.Comment_Text = new System.Windows.Forms.Label();
            this.TimeStamp = new System.Windows.Forms.Label();
            this.NumberofFeedbacks_Label = new System.Windows.Forms.Label();
            this.FeedbackBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeedbackHeader
            // 
            this.FeedbackHeader.AutoSize = true;
            this.FeedbackHeader.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackHeader.Location = new System.Drawing.Point(3, 7);
            this.FeedbackHeader.Name = "FeedbackHeader";
            this.FeedbackHeader.Size = new System.Drawing.Size(170, 42);
            this.FeedbackHeader.TabIndex = 24;
            this.FeedbackHeader.Text = "Feedbacks";
            // 
            // FeedbackBox
            // 
            this.FeedbackBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FeedbackBox.Controls.Add(this.TimeStamp);
            this.FeedbackBox.Controls.Add(this.Comment_Text);
            this.FeedbackBox.Controls.Add(this.GuestRating);
            this.FeedbackBox.Controls.Add(this.Category_Label);
            this.FeedbackBox.Controls.Add(this.GuestName);
            this.FeedbackBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackBox.Location = new System.Drawing.Point(10, 52);
            this.FeedbackBox.Name = "FeedbackBox";
            this.FeedbackBox.Size = new System.Drawing.Size(613, 94);
            this.FeedbackBox.TabIndex = 26;
            this.FeedbackBox.TabStop = false;
            this.FeedbackBox.Text = "Feedback";
            // 
            // GuestName
            // 
            this.GuestName.AutoSize = true;
            this.GuestName.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestName.Location = new System.Drawing.Point(6, 17);
            this.GuestName.Name = "GuestName";
            this.GuestName.Size = new System.Drawing.Size(98, 21);
            this.GuestName.TabIndex = 0;
            this.GuestName.Text = "Guest Name";
            // 
            // Category_Label
            // 
            this.Category_Label.AutoSize = true;
            this.Category_Label.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Category_Label.Location = new System.Drawing.Point(11, 37);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(39, 11);
            this.Category_Label.TabIndex = 1;
            this.Category_Label.Text = "Category:";
            // 
            // GuestRating
            // 
            this.GuestRating.AutoSize = true;
            this.GuestRating.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestRating.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GuestRating.Location = new System.Drawing.Point(164, 37);
            this.GuestRating.Name = "GuestRating";
            this.GuestRating.Size = new System.Drawing.Size(54, 11);
            this.GuestRating.TabIndex = 2;
            this.GuestRating.Text = "Guest Rating:";
            // 
            // Comment_Text
            // 
            this.Comment_Text.AutoSize = true;
            this.Comment_Text.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Comment_Text.Location = new System.Drawing.Point(10, 50);
            this.Comment_Text.Name = "Comment_Text";
            this.Comment_Text.Size = new System.Drawing.Size(58, 14);
            this.Comment_Text.TabIndex = 3;
            this.Comment_Text.Text = "Comment";
            // 
            // TimeStamp
            // 
            this.TimeStamp.AutoSize = true;
            this.TimeStamp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeStamp.Location = new System.Drawing.Point(545, 70);
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Size = new System.Drawing.Size(59, 18);
            this.TimeStamp.TabIndex = 4;
            this.TimeStamp.Text = "Time Stamp";
            this.TimeStamp.UseCompatibleTextRendering = true;
            // 
            // NumberofFeedbacks_Label
            // 
            this.NumberofFeedbacks_Label.AutoSize = true;
            this.NumberofFeedbacks_Label.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofFeedbacks_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NumberofFeedbacks_Label.Location = new System.Drawing.Point(508, 29);
            this.NumberofFeedbacks_Label.Name = "NumberofFeedbacks_Label";
            this.NumberofFeedbacks_Label.Size = new System.Drawing.Size(115, 20);
            this.NumberofFeedbacks_Label.TabIndex = 5;
            this.NumberofFeedbacks_Label.Text = "Number of Feedbacks";
            this.NumberofFeedbacks_Label.UseCompatibleTextRendering = true;
            // 
            // Guest_FeedbackPanel_VIEW_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.NumberofFeedbacks_Label);
            this.Controls.Add(this.FeedbackBox);
            this.Controls.Add(this.FeedbackHeader);
            this.Name = "Guest_FeedbackPanel_VIEW_";
            this.Size = new System.Drawing.Size(637, 388);
            this.FeedbackBox.ResumeLayout(false);
            this.FeedbackBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FeedbackHeader;
        private System.Windows.Forms.GroupBox FeedbackBox;
        private System.Windows.Forms.Label TimeStamp;
        private System.Windows.Forms.Label Comment_Text;
        private System.Windows.Forms.Label GuestRating;
        private System.Windows.Forms.Label Category_Label;
        private System.Windows.Forms.Label GuestName;
        private System.Windows.Forms.Label NumberofFeedbacks_Label;
    }
}
