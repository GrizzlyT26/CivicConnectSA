
using CivicConnectSA.Helpers;
using CivicConnectSA.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace CivicConnectSA.Forms
{
    public partial class ReportIssuesForm : Form
    {
        private string selectedFilePath = string.Empty;

        public ReportIssuesForm()
        {
            InitializeComponent();

            LoadCategories();

            progressReport.Minimum = 0;
            progressReport.Maximum = 100;
            progressReport.Value = 0;

            UpdateProgress();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("Sanitation");
            cmbCategory.Items.Add("Roads and Potholes");
            cmbCategory.Items.Add("Water Supply");
            cmbCategory.Items.Add("Electricity");
            cmbCategory.Items.Add("Waste Management");
            cmbCategory.Items.Add("Street Lighting");
            cmbCategory.Items.Add("Public Safety");
            cmbCategory.Items.Add("Other");

            cmbCategory.SelectedIndex = -1;
        }

        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                progress += 30;

            if (cmbCategory.SelectedIndex >= 0)
                progress += 25;

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
                progress += 35;

            if (!string.IsNullOrWhiteSpace(selectedFilePath))
                progress += 10;

            progressReport.Value = progress;

            if (progress == 0)
            {
                lblEngagement.Text =
                    "Your report helps the municipality identify\n" +
                    "and improve services in your community.";
            }
            else if (progress < 100)
            {
                lblEngagement.Text =
                    "You're making progress! Complete the remaining\n" +
                    "fields to submit your municipal report.";
            }
            else
            {
                lblEngagement.Text =
                    "Great! Your report is complete and ready to submit.";
            }
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Supporting File";

                openFileDialog.Filter =
                    "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|" +
                    "PDF Files (*.pdf)|*.pdf|" +
                    "Word Documents (*.doc;*.docx)|*.doc;*.docx|" +
                    "All Files (*.*)|*.*";

                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo =
                        new FileInfo(openFileDialog.FileName);

                    // Maximum attachment size: 10 MB.
                    if (fileInfo.Length > 10 * 1024 * 1024)
                    {
                        MessageBox.Show(
                            "The selected file is too large.\n\n" +
                            "Please select a file smaller than 10 MB.",
                            "File Too Large",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    selectedFilePath = openFileDialog.FileName;

                    lblSelectedFile.Text =
                        "Selected file: " +
                        Path.GetFileName(selectedFilePath);

                    UpdateProgress();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Only authenticated users can submit incidents.
            if (!SessionContext.IsAuthenticated)
            {
                MessageBox.Show(
                    "Please log in before submitting a municipal issue.",
                    "Authentication Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Reporting is intended for citizen accounts.
            if (SessionContext.UserRole != "Citizen")
            {
                MessageBox.Show(
                    "Only citizen accounts can submit municipal issues.",
                    "Access Restricted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an issue category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show(
                    "Please provide a detailed description of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                rtbDescription.Focus();
                return;
            }

            if (rtbDescription.Text.Length > 1000)
            {
                MessageBox.Show(
                    "Your description cannot exceed 1000 characters.",
                    "Description Too Long",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                rtbDescription.Focus();
                return;
            }

            string referenceNumber =
                "CIV-" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

            DateTime submissionDate = DateTime.Now;

            Issue newIssue = new Issue
            {
                ReferenceNumber = referenceNumber,
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                AttachmentPath = selectedFilePath,
                DateReported = submissionDate,

                // Ownership tracking.
                SubmittedBy = SessionContext.Username,

                // Initial status.
                Status = "Submitted",

                LastUpdatedBy = SessionContext.Username,
                LastUpdatedDate = submissionDate
            };

            // Save to the shared issue collection.
            IssueDataStore.ReportedIssues.Add(newIssue);

            MessageBox.Show(
                "Your municipal issue has been submitted successfully!\n\n" +
                "Reference Number: " + referenceNumber + "\n" +
                "Submitted By: " + SessionContext.Username + "\n" +
                "Status: Submitted\n\n" +
                "You can track this request through Service Request Status.",
                "Report Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
        }

        private void ClearForm()
        {
            txtLocation.Clear();

            lblCharacterCount.Text = "0 / 1000 characters";

            cmbCategory.SelectedIndex = -1;

            rtbDescription.Clear();

            selectedFilePath = string.Empty;

            lblSelectedFile.Text = "No file selected";

            progressReport.Value = 0;

            lblEngagement.Text =
                "Your report helps the municipality identify\n" +
                "and improve services in your community.";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void cmbCategory_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void rtbDescription_TextChanged(
            object sender, EventArgs e)
        {
            UpdateProgress();

            int characterCount = rtbDescription.Text.Length;

            lblCharacterCount.Text =
                characterCount + " / 1000 characters";
        }


    }
}
