namespace CivicConnectSA.Forms
{
    partial class LocalEventsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.grpUpcomingEvents = new System.Windows.Forms.GroupBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.grpEventDetails = new System.Windows.Forms.GroupBox();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.grpRecommendedEvents = new System.Windows.Forms.GroupBox();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.grpUpcomingEvents.SuspendLayout();
            this.grpEventDetails.SuspendLayout();
            this.grpRecommendedEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblTitle.Location = new System.Drawing.Point(361, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Local Events & Announcements";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search and Filter Events";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(445, 512);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Find community events and municipal announcements.\r\nStay informed and get involve" +
    "d in your community.\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearFilters);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.lblToDate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.lblFromDate);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Location = new System.Drawing.Point(25, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 81);
            this.panel1.TabIndex = 4;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(821, 45);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilters.TabIndex = 9;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(555, 48);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(168, 20);
            this.dtpToDate.TabIndex = 7;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(552, 31);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(44, 13);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "To date";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(740, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(347, 31);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(54, 13);
            this.lblFromDate.TabIndex = 4;
            this.lblFromDate.Text = "From date";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(175, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(178, 47);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(350, 48);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(183, 20);
            this.dtpFromDate.TabIndex = 5;
            // 
            // grpUpcomingEvents
            // 
            this.grpUpcomingEvents.Controls.Add(this.lstEvents);
            this.grpUpcomingEvents.Location = new System.Drawing.Point(31, 215);
            this.grpUpcomingEvents.Name = "grpUpcomingEvents";
            this.grpUpcomingEvents.Size = new System.Drawing.Size(299, 291);
            this.grpUpcomingEvents.TabIndex = 5;
            this.grpUpcomingEvents.TabStop = false;
            this.grpUpcomingEvents.Text = "Upcoming Events";
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(17, 45);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(268, 225);
            this.lstEvents.TabIndex = 0;
            // 
            // grpEventDetails
            // 
            this.grpEventDetails.Controls.Add(this.lblEventDetails);
            this.grpEventDetails.Location = new System.Drawing.Point(354, 215);
            this.grpEventDetails.Name = "grpEventDetails";
            this.grpEventDetails.Size = new System.Drawing.Size(283, 291);
            this.grpEventDetails.TabIndex = 6;
            this.grpEventDetails.TabStop = false;
            this.grpEventDetails.Text = "Event Details";
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.Location = new System.Drawing.Point(21, 45);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(246, 225);
            this.lblEventDetails.TabIndex = 0;
            // 
            // grpRecommendedEvents
            // 
            this.grpRecommendedEvents.Controls.Add(this.lstRecommendations);
            this.grpRecommendedEvents.Location = new System.Drawing.Point(657, 215);
            this.grpRecommendedEvents.Name = "grpRecommendedEvents";
            this.grpRecommendedEvents.Size = new System.Drawing.Size(279, 291);
            this.grpRecommendedEvents.TabIndex = 7;
            this.grpRecommendedEvents.TabStop = false;
            this.grpRecommendedEvents.Text = "Recommended Events";
            // 
            // lstRecommendations
            // 
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.Location = new System.Drawing.Point(6, 34);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(258, 238);
            this.lstRecommendations.TabIndex = 0;
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 572);
            this.Controls.Add(this.grpRecommendedEvents);
            this.Controls.Add(this.grpEventDetails);
            this.Controls.Add(this.grpUpcomingEvents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Name = "LocalEventsForm";
            this.Text = "LocalEventsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpUpcomingEvents.ResumeLayout(false);
            this.grpEventDetails.ResumeLayout(false);
            this.grpRecommendedEvents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.GroupBox grpUpcomingEvents;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.GroupBox grpEventDetails;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.GroupBox grpRecommendedEvents;
        private System.Windows.Forms.ListBox lstRecommendations;
    }
}