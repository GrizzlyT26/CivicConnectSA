namespace CivicConnectSA.Forms
{
    partial class ReportIssuesForm
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
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescriptionHint = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.grpEngagement = new System.Windows.Forms.GroupBox();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.progressReport = new System.Windows.Forms.ProgressBar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.grpEngagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(308, 36);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(301, 29);
            this.lblReportTitle.TabIndex = 0;
            this.lblReportTitle.Text = "Report a Municipal Issue";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(151, 74);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(600, 40);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Please provide the details below so that the municipality\ncan better understand a" +
    "nd respond to your report.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(169, 140);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(88, 13);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location of Issue";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(300, 133);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(325, 20);
            this.txtLocation.TabIndex = 3;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(169, 183);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Issue Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(303, 175);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(325, 21);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(166, 258);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Issue Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(300, 255);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(325, 96);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // lblDescriptionHint
            // 
            this.lblDescriptionHint.AutoSize = true;
            this.lblDescriptionHint.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDescriptionHint.Location = new System.Drawing.Point(300, 375);
            this.lblDescriptionHint.Name = "lblDescriptionHint";
            this.lblDescriptionHint.Size = new System.Drawing.Size(281, 13);
            this.lblDescriptionHint.TabIndex = 8;
            this.lblDescriptionHint.Text = "Please provide as much detail as possible about the issue.";
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(169, 413);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(111, 13);
            this.lblAttachment.TabIndex = 9;
            this.lblAttachment.Text = "Attach Supporting File";
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Location = new System.Drawing.Point(303, 403);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(149, 23);
            this.btnAttachFile.TabIndex = 10;
            this.btnAttachFile.Text = "Attach Image / Document";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSelectedFile.Location = new System.Drawing.Point(310, 429);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(80, 13);
            this.lblSelectedFile.TabIndex = 11;
            this.lblSelectedFile.Text = "No file selected";
            // 
            // grpEngagement
            // 
            this.grpEngagement.Controls.Add(this.lblEngagement);
            this.grpEngagement.Location = new System.Drawing.Point(303, 458);
            this.grpEngagement.Name = "grpEngagement";
            this.grpEngagement.Size = new System.Drawing.Size(306, 69);
            this.grpEngagement.TabIndex = 12;
            this.grpEngagement.TabStop = false;
            this.grpEngagement.Text = "Community Engagement";
            // 
            // lblEngagement
            // 
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Location = new System.Drawing.Point(10, 20);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(198, 26);
            this.lblEngagement.TabIndex = 0;
            this.lblEngagement.Text = "Your report helps the municipality identify\nand improve services in your communit" +
    "y.";
            this.lblEngagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressReport
            // 
            this.progressReport.Location = new System.Drawing.Point(411, 544);
            this.progressReport.Name = "progressReport";
            this.progressReport.Size = new System.Drawing.Size(100, 23);
            this.progressReport.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(469, 583);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(156, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit Report";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(300, 583);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterCount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCharacterCount.Location = new System.Drawing.Point(300, 362);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(66, 13);
            this.lblCharacterCount.TabIndex = 16;
            this.lblCharacterCount.Text = "0 characters";
            
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.progressReport);
            this.Controls.Add(this.grpEngagement);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnAttachFile);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.lblDescriptionHint);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblReportTitle);
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Municipal Issue";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.grpEngagement.ResumeLayout(false);
            this.grpEngagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescriptionHint;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.GroupBox grpEngagement;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.ProgressBar progressReport;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCharacterCount;
    }
}