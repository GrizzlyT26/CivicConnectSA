using System;
using System.Linq;
using System.Windows.Forms;
using CivicConnectSA.Helpers;
using CivicConnectSA.Models;

namespace CivicConnectSA.Forms
{
    public partial class ServiceRequestStatusForm : Form
    {
        public ServiceRequestStatusForm()
        {
            InitializeComponent();

            ClearStatusInformation();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            string referenceNumber = txtReferenceNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(referenceNumber))
            {
                MessageBox.Show(
                    "Please enter your service request reference number.",
                    "Reference Number Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtReferenceNumber.Focus();
                return;
            }

            Issue issue = IssueDataStore.ReportedIssues
                .FirstOrDefault(i =>
                    i.ReferenceNumber.Equals(
                        referenceNumber,
                        StringComparison.OrdinalIgnoreCase));

            if (issue == null)
            {
                MessageBox.Show(
                    "No service request could be found with that reference number.",
                    "Request Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearStatusInformation();
                return;
            }

            lblStatus.Text = "Status: " + issue.Status;

            lblStatusLocation.Text =
                "Location: " + issue.Location;

            lblStatusCategory.Text =
                "Category: " + issue.Category;

            lblStatusDate.Text =
                "Date Reported: " +
                issue.DateReported.ToString("dd/MM/yyyy HH:mm");

            lblStatusDescription.Text =
                "Description: " + issue.Description;
        }

        private void ClearStatusInformation()
        {
            lblStatus.Text = "Status: -";
            lblStatusLocation.Text = "Location: -";
            lblStatusCategory.Text = "Category: -";
            lblStatusDate.Text = "Date Reported: -";
            lblStatusDescription.Text = "Description: -";
        }

        

        private void ServiceRequestStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}