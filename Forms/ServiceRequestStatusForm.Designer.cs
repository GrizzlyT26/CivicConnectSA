namespace CivicConnectSA.Forms
{
    partial class ServiceRequestStatusForm
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
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatusInstructions = new System.Windows.Forms.Label();
            this.lblReferenceNumber = new System.Windows.Forms.Label();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.grpStatusResult = new System.Windows.Forms.GroupBox();
            this.lblStatusDescription = new System.Windows.Forms.Label();
            this.lblStatusDate = new System.Windows.Forms.Label();
            this.lblStatusCategory = new System.Windows.Forms.Label();
            this.lblStatusLocation = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.lblTotalRequests = new System.Windows.Forms.Label();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.label1_note = new System.Windows.Forms.Label();
            this.txtUpdateNote = new System.Windows.Forms.TextBox();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.pnlSubmitted = new System.Windows.Forms.Panel();
            this.lblSubmittedCount = new System.Windows.Forms.Label();
            this.lblSubmittedCaption = new System.Windows.Forms.Label();
            this.pnlResolved = new System.Windows.Forms.Panel();
            this.lblResolvedCaption = new System.Windows.Forms.Label();
            this.lblResolvedCount = new System.Windows.Forms.Label();
            this.pnlInProgress = new System.Windows.Forms.Panel();
            this.lblInProgressCaption = new System.Windows.Forms.Label();
            this.lblInProgressCount = new System.Windows.Forms.Label();
            this.grpStatusResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.pnlSubmitted.SuspendLayout();
            this.pnlResolved.SuspendLayout();
            this.pnlInProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(221, 9);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(364, 29);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "Check Service Request Status";
            // 
            // lblStatusInstructions
            // 
            this.lblStatusInstructions.Location = new System.Drawing.Point(223, 38);
            this.lblStatusInstructions.Name = "lblStatusInstructions";
            this.lblStatusInstructions.Size = new System.Drawing.Size(362, 23);
            this.lblStatusInstructions.TabIndex = 1;
            this.lblStatusInstructions.Text = "Enter your municipal service request reference number";
            this.lblStatusInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReferenceNumber
            // 
            this.lblReferenceNumber.AutoSize = true;
            this.lblReferenceNumber.Location = new System.Drawing.Point(49, 170);
            this.lblReferenceNumber.Name = "lblReferenceNumber";
            this.lblReferenceNumber.Size = new System.Drawing.Size(97, 13);
            this.lblReferenceNumber.TabIndex = 2;
            this.lblReferenceNumber.Text = "Reference Number";
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(352, 165);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(110, 23);
            this.btnCheckStatus.TabIndex = 3;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // grpStatusResult
            // 
            this.grpStatusResult.Controls.Add(this.lblStatusDescription);
            this.grpStatusResult.Controls.Add(this.lblStatusDate);
            this.grpStatusResult.Controls.Add(this.lblStatusCategory);
            this.grpStatusResult.Controls.Add(this.lblStatusLocation);
            this.grpStatusResult.Controls.Add(this.lblStatus);
            this.grpStatusResult.Location = new System.Drawing.Point(27, 339);
            this.grpStatusResult.Name = "grpStatusResult";
            this.grpStatusResult.Size = new System.Drawing.Size(329, 185);
            this.grpStatusResult.TabIndex = 4;
            this.grpStatusResult.TabStop = false;
            this.grpStatusResult.Text = "Request Status";
            // 
            // lblStatusDescription
            // 
            this.lblStatusDescription.AutoSize = true;
            this.lblStatusDescription.Location = new System.Drawing.Point(11, 158);
            this.lblStatusDescription.Name = "lblStatusDescription";
            this.lblStatusDescription.Size = new System.Drawing.Size(69, 13);
            this.lblStatusDescription.TabIndex = 4;
            this.lblStatusDescription.Text = "Description: -";
            // 
            // lblStatusDate
            // 
            this.lblStatusDate.AutoSize = true;
            this.lblStatusDate.Location = new System.Drawing.Point(8, 124);
            this.lblStatusDate.Name = "lblStatusDate";
            this.lblStatusDate.Size = new System.Drawing.Size(86, 13);
            this.lblStatusDate.TabIndex = 3;
            this.lblStatusDate.Text = "Date Reported: -";
            // 
            // lblStatusCategory
            // 
            this.lblStatusCategory.AutoSize = true;
            this.lblStatusCategory.Location = new System.Drawing.Point(7, 90);
            this.lblStatusCategory.Name = "lblStatusCategory";
            this.lblStatusCategory.Size = new System.Drawing.Size(58, 13);
            this.lblStatusCategory.TabIndex = 2;
            this.lblStatusCategory.Text = "Category: -";
            // 
            // lblStatusLocation
            // 
            this.lblStatusLocation.AutoSize = true;
            this.lblStatusLocation.Location = new System.Drawing.Point(8, 57);
            this.lblStatusLocation.Name = "lblStatusLocation";
            this.lblStatusLocation.Size = new System.Drawing.Size(57, 13);
            this.lblStatusLocation.TabIndex = 1;
            this.lblStatusLocation.Text = "Location: -";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status: -";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(236, 544);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.Location = new System.Drawing.Point(152, 163);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(172, 20);
            this.txtReferenceNumber.TabIndex = 6;
            // 
            // dgvRequests
            // 
            this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(27, 210);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(739, 109);
            this.dgvRequests.TabIndex = 7;
            // 
            // lblTotalRequests
            // 
            this.lblTotalRequests.AutoSize = true;
            this.lblTotalRequests.Location = new System.Drawing.Point(49, 66);
            this.lblTotalRequests.Name = "lblTotalRequests";
            this.lblTotalRequests.Size = new System.Drawing.Size(93, 13);
            this.lblTotalRequests.TabIndex = 9;
            this.lblTotalRequests.Text = "Summary statistics";
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Location = new System.Drawing.Point(478, 170);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(76, 13);
            this.lblStatusFilter.TabIndex = 10;
            this.lblStatusFilter.Text = "Filter by Status";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(560, 163);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(160, 21);
            this.cmbStatusFilter.TabIndex = 11;
            // 
            // cmbNewStatus
            // 
            this.cmbNewStatus.FormattingEnabled = true;
            this.cmbNewStatus.Location = new System.Drawing.Point(535, 358);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.Size = new System.Drawing.Size(160, 21);
            this.cmbNewStatus.TabIndex = 13;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(382, 544);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(97, 23);
            this.btnUpdateStatus.TabIndex = 14;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 185);
            this.dataGridView1.TabIndex = 15;
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Location = new System.Drawing.Point(400, 366);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(62, 13);
            this.lblUpdateStatus.TabIndex = 16;
            this.lblUpdateStatus.Text = "New Status";
            // 
            // label1_note
            // 
            this.label1_note.AutoSize = true;
            this.label1_note.Location = new System.Drawing.Point(400, 396);
            this.label1_note.Name = "label1_note";
            this.label1_note.Size = new System.Drawing.Size(119, 13);
            this.label1_note.TabIndex = 17;
            this.label1_note.Text = "Update Note (Optional):";
            // 
            // txtUpdateNote
            // 
            this.txtUpdateNote.Location = new System.Drawing.Point(403, 421);
            this.txtUpdateNote.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtUpdateNote.Multiline = true;
            this.txtUpdateNote.Name = "txtUpdateNote";
            this.txtUpdateNote.ReadOnly = true;
            this.txtUpdateNote.Size = new System.Drawing.Size(292, 75);
            this.txtUpdateNote.TabIndex = 18;
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.Silver;
            this.pnlTotal.Controls.Add(this.lblTotalCount);
            this.pnlTotal.Controls.Add(this.lblTotalCaption);
            this.pnlTotal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTotal.Location = new System.Drawing.Point(83, 91);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(137, 60);
            this.pnlTotal.TabIndex = 19;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(66, 10);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "0";
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.ForeColor = System.Drawing.Color.White;
            this.lblTotalCaption.Location = new System.Drawing.Point(31, 36);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(79, 13);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "Total Requests";
            // 
            // pnlSubmitted
            // 
            this.pnlSubmitted.BackColor = System.Drawing.Color.Silver;
            this.pnlSubmitted.Controls.Add(this.lblSubmittedCount);
            this.pnlSubmitted.Controls.Add(this.lblSubmittedCaption);
            this.pnlSubmitted.Location = new System.Drawing.Point(236, 91);
            this.pnlSubmitted.Name = "pnlSubmitted";
            this.pnlSubmitted.Size = new System.Drawing.Size(134, 60);
            this.pnlSubmitted.TabIndex = 20;
            // 
            // lblSubmittedCount
            // 
            this.lblSubmittedCount.AutoSize = true;
            this.lblSubmittedCount.ForeColor = System.Drawing.Color.White;
            this.lblSubmittedCount.Location = new System.Drawing.Point(56, 10);
            this.lblSubmittedCount.Name = "lblSubmittedCount";
            this.lblSubmittedCount.Size = new System.Drawing.Size(13, 13);
            this.lblSubmittedCount.TabIndex = 1;
            this.lblSubmittedCount.Text = "0";
            // 
            // lblSubmittedCaption
            // 
            this.lblSubmittedCaption.AutoSize = true;
            this.lblSubmittedCaption.ForeColor = System.Drawing.Color.White;
            this.lblSubmittedCaption.Location = new System.Drawing.Point(34, 36);
            this.lblSubmittedCaption.Name = "lblSubmittedCaption";
            this.lblSubmittedCaption.Size = new System.Drawing.Size(54, 13);
            this.lblSubmittedCaption.TabIndex = 0;
            this.lblSubmittedCaption.Text = "Submitted";
            // 
            // pnlResolved
            // 
            this.pnlResolved.BackColor = System.Drawing.Color.Silver;
            this.pnlResolved.Controls.Add(this.lblResolvedCaption);
            this.pnlResolved.Controls.Add(this.lblResolvedCount);
            this.pnlResolved.Location = new System.Drawing.Point(556, 91);
            this.pnlResolved.Name = "pnlResolved";
            this.pnlResolved.Size = new System.Drawing.Size(139, 60);
            this.pnlResolved.TabIndex = 21;
            // 
            // lblResolvedCaption
            // 
            this.lblResolvedCaption.AutoSize = true;
            this.lblResolvedCaption.ForeColor = System.Drawing.Color.White;
            this.lblResolvedCaption.Location = new System.Drawing.Point(48, 36);
            this.lblResolvedCaption.Name = "lblResolvedCaption";
            this.lblResolvedCaption.Size = new System.Drawing.Size(52, 13);
            this.lblResolvedCaption.TabIndex = 1;
            this.lblResolvedCaption.Text = "Resolved";
            // 
            // lblResolvedCount
            // 
            this.lblResolvedCount.AutoSize = true;
            this.lblResolvedCount.ForeColor = System.Drawing.Color.White;
            this.lblResolvedCount.Location = new System.Drawing.Point(66, 10);
            this.lblResolvedCount.Name = "lblResolvedCount";
            this.lblResolvedCount.Size = new System.Drawing.Size(13, 13);
            this.lblResolvedCount.TabIndex = 0;
            this.lblResolvedCount.Text = "0";
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.BackColor = System.Drawing.Color.Silver;
            this.pnlInProgress.Controls.Add(this.lblInProgressCaption);
            this.pnlInProgress.Controls.Add(this.lblInProgressCount);
            this.pnlInProgress.Location = new System.Drawing.Point(403, 91);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(139, 60);
            this.pnlInProgress.TabIndex = 22;
            // 
            // lblInProgressCaption
            // 
            this.lblInProgressCaption.AutoSize = true;
            this.lblInProgressCaption.ForeColor = System.Drawing.Color.White;
            this.lblInProgressCaption.Location = new System.Drawing.Point(43, 36);
            this.lblInProgressCaption.Name = "lblInProgressCaption";
            this.lblInProgressCaption.Size = new System.Drawing.Size(60, 13);
            this.lblInProgressCaption.TabIndex = 1;
            this.lblInProgressCaption.Text = "In Progress";
            // 
            // lblInProgressCount
            // 
            this.lblInProgressCount.AutoSize = true;
            this.lblInProgressCount.ForeColor = System.Drawing.Color.White;
            this.lblInProgressCount.Location = new System.Drawing.Point(63, 10);
            this.lblInProgressCount.Name = "lblInProgressCount";
            this.lblInProgressCount.Size = new System.Drawing.Size(13, 13);
            this.lblInProgressCount.TabIndex = 0;
            this.lblInProgressCount.Text = "0";
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.pnlInProgress);
            this.Controls.Add(this.pnlResolved);
            this.Controls.Add(this.pnlSubmitted);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.txtUpdateNote);
            this.Controls.Add(this.label1_note);
            this.Controls.Add(this.lblUpdateStatus);
            this.Controls.Add(this.cmbNewStatus);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.lblStatusFilter);
            this.Controls.Add(this.lblTotalRequests);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.txtReferenceNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpStatusResult);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.lblReferenceNumber);
            this.Controls.Add(this.lblStatusInstructions);
            this.Controls.Add(this.lblStatusTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServiceRequestStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Request Status";
            this.grpStatusResult.ResumeLayout(false);
            this.grpStatusResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlSubmitted.ResumeLayout(false);
            this.pnlSubmitted.PerformLayout();
            this.pnlResolved.ResumeLayout(false);
            this.pnlResolved.PerformLayout();
            this.pnlInProgress.ResumeLayout(false);
            this.pnlInProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatusInstructions;
        private System.Windows.Forms.Label lblReferenceNumber;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.GroupBox grpStatusResult;
        private System.Windows.Forms.Label lblStatusCategory;
        private System.Windows.Forms.Label lblStatusLocation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusDescription;
        private System.Windows.Forms.Label lblStatusDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Label lblTotalRequests;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Label label1_note;
        private System.Windows.Forms.TextBox txtUpdateNote;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlSubmitted;
        private System.Windows.Forms.Panel pnlResolved;
        private System.Windows.Forms.Panel pnlInProgress;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblSubmittedCount;
        private System.Windows.Forms.Label lblSubmittedCaption;
        private System.Windows.Forms.Label lblResolvedCaption;
        private System.Windows.Forms.Label lblResolvedCount;
        private System.Windows.Forms.Label lblInProgressCaption;
        private System.Windows.Forms.Label lblInProgressCount;
    }
}