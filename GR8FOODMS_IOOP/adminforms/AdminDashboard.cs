using GR8FOODMS_IOOP;
using System;
using System.Windows.Forms;

namespace System_Admin_Assignment
{
    public partial class AdminDashboard : Form
    {
        // Declare Variables
        private int currentUserId;
        private string adminName;

        // Constructor
        public AdminDashboard(int userId, string adminName)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.adminName = adminName;

            labelWelcome.Text = "Welcome back, " + adminName + "!";
        }

        // 1. Button to the Add User Form
        private void btnAddUserForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm addUserForm = new AddUserForm(currentUserId, adminName);
            addUserForm.ShowDialog();
        }

        // 2. Button to the Update User Form
        private void btnUpdateUserForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateUserForm updateUserForm = new UpdateUserForm(currentUserId, adminName);
            updateUserForm.ShowDialog();
        }

        // 3. Button to the Remove User Form
        private void btnRemoveUserForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveUserForm removeUserForm = new RemoveUserForm(currentUserId, adminName);
            removeUserForm.ShowDialog();
        }

        // 4. Button to the View Sales Report Form
        private void btnViewSalesReportForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSalesReportForm salesReportForm = new ViewSalesReportForm(currentUserId, adminName);
            salesReportForm.ShowDialog();
        }

        // 5. Button to the View Tables Form
        private void btnViewTables_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ViewTablesForm viewTablesForm = new ViewTablesForm(currentUserId, adminName);
                viewTablesForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the View Tables form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Safe Logout Handling
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                  "Logout Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginPage login = new LoginPage();
                login.Show();
                this.Close();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
            {
            IOOP_Manager.UpdateProfile profileForm = new IOOP_Manager.UpdateProfile("Admin", currentUserId);
            this.Hide();
            profileForm.ShowDialog();
            this.Show();
        }

    }
}