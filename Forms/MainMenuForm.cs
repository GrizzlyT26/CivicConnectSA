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
            using (LocalEventsForm eventsForm = new LocalEventsForm())
            {
                this.Hide();

                eventsForm.ShowDialog();

                this.Show();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
