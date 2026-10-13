using System;
using System.Windows.Forms;

namespace System_Admin_Assignment
{
    public partial class RemoveUserForm : Form
    {
        private int currentUserId;
        private string adminName;

        public RemoveUserForm(int userId, string name)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.adminName = name;
        }

        private void RemoveUserForm_Load(object sender, EventArgs e)
        {
            ResetDisplayControls();
        }

        //LOCK CONTROLS BEFORE A SUCCESSFUL SEARCH
        private void ResetDisplayControls()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtBirthday.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtEWallet.Clear();

            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtBirthday.Enabled = false;
            txtAddress.Enabled = false;
            txtPassword.Enabled = false;
            txtEWallet.Enabled = false;

            txtName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtBirthday.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtEWallet.ReadOnly = false;

            btnDelete.Enabled = false;
        }

        // METHOD TO ENABLE CONTROLS ONCE RECORD IS FOUND
        private void EnableControlsAsReadOnly()
        {
            // Enable textboxes and lock them down using ReadOnly
            txtName.Enabled = true;
            txtName.ReadOnly = true;

            txtEmail.Enabled = true;
            txtEmail.ReadOnly = true;

            txtPhone.Enabled = true;
            txtPhone.ReadOnly = true;

            txtBirthday.Enabled = true;
            txtBirthday.ReadOnly = true;

            txtAddress.Enabled = true;
            txtAddress.ReadOnly = true;

            txtPassword.Enabled = true;
            txtPassword.ReadOnly = true;

            txtEWallet.Enabled = true;
            txtEWallet.ReadOnly = true;

            btnDelete.Enabled = true;
        }

        // Search Profile
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate Role Selection
            if (cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Numeric ID Input
            if (!int.TryParse(txtSearchID.Text.Trim(), out int targetId))
            {
                MessageBox.Show("Please enter a valid numeric Target ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRole = cboRole.SelectedItem.ToString();

            try
            {
                bool recordFound = false;
                object birthdayValue = DBNull.Value;

                // Route lookup to static class engines and map properties to fields
                switch (selectedRole)
                {
                    case "Admin":
                        Admin adminsearcher = new Admin(targetId);

                        Admin admin = adminsearcher.ReadAdmin();
                        if (admin != null)
                        {
                            recordFound = true;
                            txtName.Text = admin.AdminName;
                            txtEmail.Text = admin.Email;
                            txtPhone.Text = admin.Phone;
                            txtAddress.Text = admin.Address?.ToString();
                            txtPassword.Text = admin.Password;
                            birthdayValue = admin.Birthday;
                            txtEWallet.Text = "N/A (Staff)";
                        }
                        break;

                    case "Manager":
                        Manager managersearcher = new Manager(targetId);

                        Manager manager = managersearcher.ReadManager();
                        if (manager != null)
                        {
                            recordFound = true;
                            txtName.Text = manager.ManagerName;
                            txtEmail.Text = manager.Email;
                            txtPhone.Text = manager.Phone;
                            txtAddress.Text = manager.Address?.ToString();
                            txtPassword.Text = manager.Password;
                            birthdayValue = manager.Birthday;
                            txtEWallet.Text = "N/A (Staff)";
                        }
                        break;

                    case "Chef":
                        Chef chefsearcher = new Chef(targetId);

                        Chef chef = chefsearcher.ReadChef();
                        if (chef != null)
                        {
                            recordFound = true;
                            txtName.Text = chef.ChefName;
                            txtEmail.Text = chef.Email;
                            txtPhone.Text = chef.Phone;
                            txtAddress.Text = chef.Address?.ToString();
                            txtPassword.Text = chef.Password;
                            birthdayValue = chef.Birthday;
                            txtEWallet.Text = "N/A (Staff)";
                        }
                        break;

                    case "Customer":
                        Customer customersearcher = new Customer(targetId);

                        Customer customer = customersearcher.ReadCustomer();
                        if (customer != null)
                        {
                            recordFound = true;
                            txtName.Text = customer.CustomerName;
                            txtEmail.Text = customer.Email;
                            txtPhone.Text = customer.Phone;
                            txtAddress.Text = customer.Address?.ToString();
                            txtPassword.Text = customer.Password;
                            birthdayValue = customer.Birthday;
                            txtEWallet.Text = customer.EWallet.ToString();
                        }
                        break;
                }

                // UI Processing Response
                if (recordFound)
                {
                    // Handle Birthday formatting cleanly if it exists
                    if (birthdayValue != null && birthdayValue != DBNull.Value)
                    {
                        DateTime dbDate = Convert.ToDateTime(birthdayValue);
                        txtBirthday.Text = dbDate.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        txtBirthday.Clear();
                    }
                    EnableControlsAsReadOnly();
                    MessageBox.Show($"Successfully loaded {selectedRole} profile data into textboxes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No profile found for ID {targetId} registered under the role '{selectedRole}'.", "Profile Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed inside OOP class layer:\n{ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DELETING PROFILE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate Inputs
            if (cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please select the user role first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedRole = cboRole.SelectedItem.ToString();

            if (!int.TryParse(txtSearchID.Text.Trim(), out int targetId))
            {
                MessageBox.Show("Please select or type a valid Target ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Double Check Guard Pop-up
            DialogResult doubleCheck = MessageBox.Show(
                $"Are you absolutely sure you want to permanently delete {selectedRole} ID {targetId} from the database?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (doubleCheck == DialogResult.No)
            {
                return; // Gracefully exit and do nothing
            }

            // Route to target instance deletion methods
            try
            {
                switch (selectedRole)
                {
                    case "Admin":
                        Admin adminToDelete = new Admin(targetId);
                        adminToDelete.DeleteAdmin();
                        break;

                    case "Manager":
                        Manager managerToDelete = new Manager(targetId);
                        managerToDelete.DeleteManager();
                        break;

                    case "Chef":
                        Chef chefToDelete = new Chef(targetId);
                        chefToDelete.DeleteChef();
                        break;

                    case "Customer":
                        Customer customerToDelete = new Customer(targetId);
                        customerToDelete.DeleteCustomer();
                        break;
                }

                MessageBox.Show($"{selectedRole} record with ID {targetId} has been successfully deleted.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetDisplayControls();
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The deletion encountered an error:\n{ex.Message}", "OOP Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            txtSearchID.Clear();
            cboRole.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetDisplayControls();
            txtSearchID.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboard dashboard = new AdminDashboard(currentUserId, adminName);
            dashboard.Show();
            this.Close();
        }

    }
}