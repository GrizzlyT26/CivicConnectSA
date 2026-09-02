using CivicConnectSA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CivicConnectSA
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();

            this.Hide();

            reportIssuesForm.ShowDialog();

            this.Show();
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            ServiceRequestStatusForm statusForm =
                new ServiceRequestStatusForm();

            this.Hide();

            statusForm.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Oops! This functionality is currently under development.\n\n" +
                "Local Events & Announcements will be coming soon.",
                "Coming Soon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
