
using System;
using System.Drawing;
using System.Windows.Forms;
using CivicConnectSA.Helpers;

namespace CivicConnectSA.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            ConfigureLoginForm();

            // Load CivicConnect SA logo.
            //LoadCivicConnectLogo();

            // Connect button events.
            btnLogin.Click += btnLogin_Click;
            btnExit.Click += btnExit_Click;
        }

        //private void LoadCivicConnectLogo()
        //{
        //    try
        //    {
        //        // Load the embedded logo resource.
        //        Image logoImage =
        //            Properties.Resources.CivicConnect_SA_Municipal_Services_Logo;

        //        if (logoImage == null)
        //        {
        //            MessageBox.Show(
        //                "The CivicConnect SA logo resource is empty.",
        //                "Logo Not Found",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Warning);

        //            return;
        //        }

        //        // Display the logo.
        //        picLogo.Image = new Bitmap(logoImage);

        //        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        //        picLogo.BackColor = Color.White;
        //        picLogo.BorderStyle = BorderStyle.None;
        //        picLogo.Visible = true;

        //        // Bring the logo to the front.
        //        picLogo.BringToFront();
        //        picLogo.Refresh();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            "Unable to load the CivicConnect SA logo.\n\n" +
        //            ex.Message,
        //            "Logo Loading Error",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //}

        private void ConfigureLoginForm()
        {
            Text = "CivicConnect SA - Login";

            StartPosition = FormStartPosition.CenterScreen;

            // Configure account roles.
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Administrator");
            cmbRole.Items.Add("Citizen");

            cmbRole.SelectedIndex = 1;

            // Hide password characters.
            txtPassword.UseSystemPasswordChar = true;

            // Clear login message.
            lblMessage.Text = "";

            // Form styling.
            BackColor = Color.FromArgb(243, 246, 250);
            Font = new Font("Segoe UI", 10F);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (cmbRole.SelectedItem == null)
            {
                lblMessage.Text =
                    "Please select an account type.";

                return;
            }

            string role = cmbRole.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text =
                    "Please enter your username and password.";

                return;
            }

            bool isValid = false;

            // Administrator authentication.
            if (role == "Administrator")
            {
                isValid =
                    username.Equals(
                        "admin",
                        StringComparison.OrdinalIgnoreCase)
                    && password == "Admin@123";
            }

            // Citizen authentication.
            else if (role == "Citizen")
            {
                isValid =
                    username.Equals(
                        "citizen",
                        StringComparison.OrdinalIgnoreCase)
                    && password == "Citizen@123";
            }

            if (!isValid)
            {
                lblMessage.Text =
                    "Invalid username, password or account type.";

                txtPassword.Clear();
                txtPassword.Focus();

                return;
            }

            // Create authenticated session.
            SessionContext.Username = username;
            SessionContext.UserRole = role;

            MessageBox.Show(
                "Welcome to CivicConnect SA, " + username + "!",
                "Login Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Hide login while the main menu is open.
            this.Hide();

            try
            {
                using (MainMenuForm mainMenu =
                    new MainMenuForm())
                {
                    mainMenu.ShowDialog();
                }
            }
            finally
            {
                // Clear authenticated session.
                SessionContext.Logout();
            }

            // Return to login if the form is still available.
            if (!this.IsDisposed && !this.Disposing)
            {
                txtUsername.Clear();
                txtPassword.Clear();

                lblMessage.Text = "";

                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SessionContext.Logout();

            Application.Exit();
        }

        
    }
}
