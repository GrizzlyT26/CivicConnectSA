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
            this.grpStatusResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(258, 30);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(364, 29);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "Check Service Request Status";
            // 
            // lblStatusInstructions
            // 
            this.lblStatusInstructions.Location = new System.Drawing.Point(244, 76);
            this.lblStatusInstructions.Name = "lblStatusInstructions";
            this.lblStatusInstructions.Size = new System.Drawing.Size(378, 23);
            this.lblStatusInstructions.TabIndex = 1;
            this.lblStatusInstructions.Text = "Enter your municipal service request reference number";
            this.lblStatusInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReferenceNumber
            // 
            this.lblReferenceNumber.AutoSize = true;
            this.lblReferenceNumber.Location = new System.Drawing.Point(78, 134);
            this.lblReferenceNumber.Name = "lblReferenceNumber";
            this.lblReferenceNumber.Size = new System.Drawing.Size(97, 13);
            this.lblReferenceNumber.TabIndex = 2;
            this.lblReferenceNumber.Text = "Reference Number";
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(192, 165);
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
            this.grpStatusResult.Location = new System.Drawing.Point(192, 203);
            this.grpStatusResult.Name = "grpStatusResult";
            this.grpStatusResult.Size = new System.Drawing.Size(475, 215);
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
            this.btnBack.Location = new System.Drawing.Point(263, 435);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.Location = new System.Drawing.Point(192, 126);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(258, 20);
            this.txtReferenceNumber.TabIndex = 6;
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.txtReferenceNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpStatusResult);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.lblReferenceNumber);
            this.Controls.Add(this.lblStatusInstructions);
            this.Controls.Add(this.lblStatusTitle);
            this.Name = "ServiceRequestStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Request Status";
            this.Load += new System.EventHandler(this.ServiceRequestStatusForm_Load);
            this.grpStatusResult.ResumeLayout(false);
            this.grpStatusResult.PerformLayout();
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
    }
}