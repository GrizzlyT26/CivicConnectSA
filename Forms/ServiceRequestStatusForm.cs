
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CivicConnectSA.Helpers;
using CivicConnectSA.Models;

namespace CivicConnectSA.Forms
{
    public partial class ServiceRequestStatusForm : Form
    {
        private readonly string[] availableStatuses =
        {
            "Submitted",
            "Under Review",
            "In Progress",
            "Resolved"
        };

        public ServiceRequestStatusForm()
        {
            InitializeComponent();

            ConfigureDashboard();

            // Connect the new dashboard controls.
            cmbStatusFilter.SelectedIndexChanged +=
                cmbStatusFilter_SelectedIndexChanged;

            dgvRequests.SelectionChanged +=
                dgvRequests_SelectionChanged;

            btnUpdateStatus.Click +=
                btnUpdateStatus_Click;

            // Load incidents and statistics.
            if (SessionContext.IsAuthenticated)
            {
                LoadRequests();
            }
        }

        // --------------------------------------------------
        // 1. CONFIGURE DASHBOARD
        // --------------------------------------------------

        private void ConfigureDashboard()
        {
            Text = "CivicConnect SA - Service Request Status";

            StartPosition = FormStartPosition.CenterScreen;

            if (!SessionContext.IsAuthenticated)
            {
                MessageBox.Show(
                    "Please log in to access service requests.",
                    "Authentication Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                BeginInvoke(new Action(() => Close()));
                return;
            }

            // Configure the DataGridView.
            dgvRequests.AutoGenerateColumns = true;
            dgvRequests.ReadOnly = true;
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.MultiSelect = false;
            dgvRequests.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRequests.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvRequests.RowHeadersVisible = false;
            dgvRequests.BackgroundColor =
                System.Drawing.Color.White;

            // Configure status filter.
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All Statuses");

            foreach (string status in availableStatuses)
            {
                cmbStatusFilter.Items.Add(status);
            }

            cmbStatusFilter.SelectedIndex = 0;

            // Configure administrator status options.
            cmbNewStatus.Items.Clear();

            foreach (string status in availableStatuses)
            {
                cmbNewStatus.Items.Add(status);
            }

            cmbNewStatus.SelectedIndex = 0;

            bool isAdmin =
                SessionContext.UserRole == "Administrator";

            if (isAdmin)
            {
                txtUpdateNote.Text =
                    "Administrator - Service Request Management";

                lblUpdateStatus.Visible = true;
                cmbNewStatus.Visible = true;
                btnUpdateStatus.Visible = true;
            }
            else if (SessionContext.UserRole == "Citizen")
            {
                txtUpdateNote.Text =
                    "My Municipal Service Requests";

                lblUpdateStatus.Visible = false;
                cmbNewStatus.Visible = false;
                btnUpdateStatus.Visible = false;
            }
            else
            {
                MessageBox.Show(
                    "You do not have permission to access this page.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                BeginInvoke(new Action(() => Close()));
            }

            ClearStatusInformation();
        }

        // --------------------------------------------------
        // 2. LOAD SERVICE REQUESTS
        // --------------------------------------------------

        private void LoadRequests()
        {
            if (!SessionContext.IsAuthenticated)
                return;

            IEnumerable<Issue> requests =
                IssueDataStore.ReportedIssues;

            // Citizens can only see their own incidents.
            if (SessionContext.UserRole == "Citizen")
            {
                requests = requests.Where(i =>
                    string.Equals(
                        i.SubmittedBy,
                        SessionContext.Username,
                        StringComparison.OrdinalIgnoreCase));
            }

            // Apply status filter.
            if (cmbStatusFilter.SelectedItem != null)
            {
                string selectedStatus =
                    cmbStatusFilter.SelectedItem.ToString();

                if (selectedStatus != "All Statuses")
                {
                    requests = requests.Where(i =>
                        string.Equals(
                            i.Status,
                            selectedStatus,
                            StringComparison.OrdinalIgnoreCase));
                }
            }

            List<Issue> requestList = requests
                .OrderByDescending(i => i.DateReported)
                .ToList();

            dgvRequests.DataSource = null;
            dgvRequests.DataSource = requestList;

            // Configure displayed columns.
            if (dgvRequests.Columns["ReferenceNumber"] != null)
            {
                dgvRequests.Columns["ReferenceNumber"].HeaderText =
                    "Reference Number";
            }

            if (dgvRequests.Columns["Location"] != null)
            {
                dgvRequests.Columns["Location"].HeaderText =
                    "Location";
            }

            if (dgvRequests.Columns["Category"] != null)
            {
                dgvRequests.Columns["Category"].HeaderText =
                    "Category";
            }

            if (dgvRequests.Columns["Status"] != null)
            {
                dgvRequests.Columns["Status"].HeaderText =
                    "Status";
            }

            if (dgvRequests.Columns["DateReported"] != null)
            {
                dgvRequests.Columns["DateReported"].HeaderText =
                    "Date Reported";
            }

            if (dgvRequests.Columns["SubmittedBy"] != null)
            {
                dgvRequests.Columns["SubmittedBy"].HeaderText =
                    "Submitted By";
            }

            if (dgvRequests.Columns["LastUpdatedBy"] != null)
            {
                dgvRequests.Columns["LastUpdatedBy"].HeaderText =
                    "Last Updated By";
            }

            // Hide lengthy or internal fields from the table.
            if (dgvRequests.Columns["AttachmentPath"] != null)
                dgvRequests.Columns["AttachmentPath"].Visible = false;

            if (dgvRequests.Columns["Description"] != null)
                dgvRequests.Columns["Description"].Visible = false;

            if (dgvRequests.Columns["LastUpdatedDate"] != null)
            {
                dgvRequests.Columns["LastUpdatedDate"].HeaderText =
                    "Last Updated";
            }

            // Refresh dashboard statistics.
            UpdateSummaryCards();

            // Clear old details if no records are available.
            if (requestList.Count == 0)
            {
                ClearStatusInformation();
            }
        }

        // --------------------------------------------------
        // 3. UPDATE SUMMARY CARDS
        // --------------------------------------------------

        private void UpdateSummaryCards()
        {
            IEnumerable<Issue> requests =
                IssueDataStore.ReportedIssues;

            // Citizens only see their own statistics.
            if (SessionContext.UserRole == "Citizen")
            {
                requests = requests.Where(i =>
                    string.Equals(
                        i.SubmittedBy,
                        SessionContext.Username,
                        StringComparison.OrdinalIgnoreCase));
            }

            List<Issue> allRequests = requests.ToList();

            lblTotalCount.Text =
                allRequests.Count.ToString();

            lblSubmittedCount.Text =
                allRequests.Count(i =>
                    string.Equals(
                        i.Status,
                        "Submitted",
                        StringComparison.OrdinalIgnoreCase))
                .ToString();

            lblInProgressCount.Text =
                allRequests.Count(i =>
                    string.Equals(
                        i.Status,
                        "In Progress",
                        StringComparison.OrdinalIgnoreCase))
                .ToString();

            lblResolvedCount.Text =
                allRequests.Count(i =>
                    string.Equals(
                        i.Status,
                        "Resolved",
                        StringComparison.OrdinalIgnoreCase))
                .ToString();
        }

        // --------------------------------------------------
        // 4. SEARCH BY REFERENCE NUMBER
        // --------------------------------------------------

        private void btnCheckStatus_Click(
            object sender, EventArgs e)
        {
            string referenceNumber =
                txtReferenceNumber.Text.Trim();

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

            // Search all records accessible to the current user.
            Issue issue = IssueDataStore.ReportedIssues
                .FirstOrDefault(i =>
                    string.Equals(
                        i.ReferenceNumber,
                        referenceNumber,
                        StringComparison.OrdinalIgnoreCase)
                    &&
                    (
                        SessionContext.UserRole == "Administrator"
                        ||
                        string.Equals(
                            i.SubmittedBy,
                            SessionContext.Username,
                            StringComparison.OrdinalIgnoreCase)
                    ));

            if (issue == null)
            {
                MessageBox.Show(
                    "No service request could be found for your account.",
                    "Request Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearStatusInformation();
                return;
            }

            DisplayIssueDetails(issue);

            // Select the matching incident in the table.
            foreach (DataGridViewRow row in dgvRequests.Rows)
            {
                Issue rowIssue =
                    row.DataBoundItem as Issue;

                if (rowIssue != null &&
                    string.Equals(
                        rowIssue.ReferenceNumber,
                        issue.ReferenceNumber,
                        StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;

                    if (row.Cells.Count > 0)
                    {
                        dgvRequests.CurrentCell = row.Cells[0];
                    }

                    break;
                }
            }
        }

        // --------------------------------------------------
        // 5. DISPLAY INCIDENT DETAILS
        // --------------------------------------------------

        private void DisplayIssueDetails(Issue issue)
        {
            if (issue == null)
                return;

            lblStatus.Text =
                "Status: " + issue.Status;

            lblStatusLocation.Text =
                "Location: " + issue.Location;

            lblStatusCategory.Text =
                "Category: " + issue.Category;

            lblStatusDate.Text =
                "Date Reported: " +
                issue.DateReported.ToString("dd/MM/yyyy HH:mm");

            lblStatusDescription.Text =
                "Description: " + issue.Description;

            // Show the selected incident's current status
            // in the administrator update ComboBox.
            if (SessionContext.UserRole == "Administrator")
            {
                int statusIndex =
                    cmbNewStatus.Items.IndexOf(issue.Status);

                if (statusIndex >= 0)
                    cmbNewStatus.SelectedIndex = statusIndex;
            }
        }

        // --------------------------------------------------
        // 6. SELECT INCIDENT FROM DATAGRIDVIEW
        // --------------------------------------------------

        private void dgvRequests_SelectionChanged(
            object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null)
                return;

            Issue selectedIssue =
                dgvRequests.CurrentRow.DataBoundItem as Issue;

            if (selectedIssue != null)
            {
                DisplayIssueDetails(selectedIssue);
            }
        }

        // --------------------------------------------------
        // 7. FILTER REQUESTS BY STATUS
        // --------------------------------------------------

        private void cmbStatusFilter_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            LoadRequests();
        }

        // --------------------------------------------------
        // 8. ADMINISTRATOR STATUS UPDATE
        // --------------------------------------------------

        private void btnUpdateStatus_Click(
            object sender, EventArgs e)
        {
            // Only administrators can update incidents.
            if (SessionContext.UserRole != "Administrator")
            {
                MessageBox.Show(
                    "You are not authorised to update service request statuses.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvRequests.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a service request first.",
                    "No Request Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Issue selectedIssue =
                dgvRequests.CurrentRow.DataBoundItem as Issue;

            if (selectedIssue == null)
                return;

            if (cmbNewStatus.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a new status.",
                    "Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string newStatus =
                cmbNewStatus.SelectedItem.ToString();

            if (string.Equals(
                selectedIssue.Status,
                newStatus,
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "The selected request already has this status.",
                    "No Changes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Update request " +
                selectedIssue.ReferenceNumber +
                " to '" + newStatus + "'?",
                "Confirm Status Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            // Update the shared incident record.
            selectedIssue.Status = newStatus;

            selectedIssue.LastUpdatedBy =
                SessionContext.Username;

            selectedIssue.LastUpdatedDate =
                DateTime.Now;

            MessageBox.Show(
                "Service request status updated successfully.\n\n" +
                "Reference: " + selectedIssue.ReferenceNumber +
                "\nNew Status: " + newStatus,
                "Update Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Refresh the table and statistics.
            LoadRequests();

            // Display the updated incident details.
            DisplayIssueDetails(selectedIssue);
        }

        // --------------------------------------------------
        // 9. CLEAR INCIDENT DETAILS
        // --------------------------------------------------

        private void ClearStatusInformation()
        {
            lblStatus.Text = "Status: -";

            lblStatusLocation.Text = "Location: -";

            lblStatusCategory.Text = "Category: -";

            lblStatusDate.Text = "Date Reported: -";

            lblStatusDescription.Text = "Description: -";
        }

        // --------------------------------------------------
        // 10. BACK TO MAIN MENU
        // --------------------------------------------------

        private void btnBack_Click_1(
            object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
