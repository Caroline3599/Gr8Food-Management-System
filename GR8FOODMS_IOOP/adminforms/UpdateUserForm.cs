using System;
using System.Data;
using System.Windows.Forms;

namespace System_Admin_Assignment
{
    public partial class UpdateUserForm : Form
    {
        private int currentUserId;
        private string adminName;

        public UpdateUserForm(int userId, string name)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.adminName = name;
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            ToggleInputControls(false);
        }

        // Toggle the textbox, datepickers, and update/clear buttons
        private void ToggleInputControls(bool enabler)
        {
            txtName.Enabled = enabler;
            txtEmail.Enabled = enabler;
            txtPhone.Enabled = enabler;
            txtBirthday.Enabled = enabler;
            txtAddress.Enabled = enabler;
            txtPassword.Enabled = enabler;
            btnUpdate.Enabled = enabler; 

            if (enabler == false)
            {
                txtEWallet.Enabled = false;
            }
        }

        // Search of the data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // VALIDATE UI CONTROLS
            if (cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a target role to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSearchID.Text.Trim(), out int targetId))
            {
                MessageBox.Show("Please enter a valid numeric Target ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ToggleInputControls(false);
                return;
            }

            string selectedRole = cboRole.SelectedItem.ToString();

            try
            {
                bool recordFound = false;
                object birthdayValue = DBNull.Value;

                // OOP ROUTING ROUTINE
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

                            txtEWallet.Enabled = false;
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

                            txtEWallet.Enabled = false;
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

                            txtEWallet.Enabled = false;
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

                            txtEWallet.Enabled = true;
                            txtEWallet.Text = customer.EWallet.ToString();
                        }
                        break;
                }

                // UI RESPONSE UPDATE HANDLERS
                if (recordFound)
                {
                    ToggleInputControls(true);

                    // Handle Birthday formatting smoothly
                    if (birthdayValue != null && birthdayValue != DBNull.Value)
                    {
                        DateTime dbDate = Convert.ToDateTime(birthdayValue);
                        txtBirthday.Text = dbDate.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        txtBirthday.Clear();
                    }

                    MessageBox.Show($"Successfully loaded {selectedRole} profile data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No profile found for ID {targetId} registered under the role '{selectedRole}'.", "Profile Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToggleInputControls(false);
                    ClearFields(); // Assuming ClearFields handles erasing textboxes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OOP Retrieval engine encountered an issue:\n{ex.Message}", "System Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToggleInputControls(false);
            }
        }

        // Update Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. CHOOSE SELECTED ROLE
            if (cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please select the user role first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedRole = cboRole.SelectedItem.ToString();

            //CHECK TARGET SELECTION ID
            if (string.IsNullOrWhiteSpace(txtSearchID.Text))
            {
                MessageBox.Show("Please provide or search for a valid Target Role ID to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int targetRoleId = int.Parse(txtSearchID.Text.Trim());

            // BASE REQUIRED TEXT VALIDATION
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Name, Email, Phone, and Password fields cannot be left blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  PHONE NUMBER VALIDATION
            string phoneInput = txtPhone.Text.Trim();

            // Check total length
            if (phoneInput.Length != 11)
            {
                MessageBox.Show("The phone number must be exactly 11 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check characters are digits only
            foreach (char c in phoneInput)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("The phone number must contain numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Enforce role-specific validation
            if (selectedRole == "Admin" && !phoneInput.StartsWith("1"))
            {
                MessageBox.Show("Admin phone numbers must start with the number 1.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (selectedRole == "Customer" && !phoneInput.StartsWith("2"))
            {
                MessageBox.Show("Customer phone numbers must start with the number 2.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (selectedRole == "Chef" && !phoneInput.StartsWith("3"))
            {
                MessageBox.Show("Chef phone numbers must start with the number 3.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (selectedRole == "Manager" && !phoneInput.StartsWith("4"))
            {
                MessageBox.Show("Manager phone numbers must start with the number 4.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string targetEmail = txtEmail.Text.Trim();
                string targetPhone = phoneInput;

                // Call the classes
                Admin adminRef = new Admin(0);
                Manager managerRef = new Manager(0);
                Chef chefRef = new Chef(0);
                Customer customerRef = new Customer(0);

                // Call readall methods
                DataTable[] allTables = new DataTable[]
                {
                    adminRef.ReadAllAdmins(),
                    managerRef.ReadAllManagers(),
                    chefRef.ReadAllChefs(),
                    customerRef.ReadAllCustomers()
                };

                // Explicitly set TableNames so we can identify them reliably during the loop
                allTables[0].TableName = "Admin";
                allTables[1].TableName = "Manager";
                allTables[2].TableName = "Chef";
                allTables[3].TableName = "Customer";

                // Loop through every row of every table
                foreach (DataTable dt in allTables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // check to see if this row is the account being edited
                        bool isCurrentEditingRecord = false;

                        if (dt.TableName == "Admin" && selectedRole == "Admin" && dt.Columns.Contains("AdminID"))
                        {
                            if (Convert.ToInt32(row["AdminID"]) == targetRoleId) 
                                isCurrentEditingRecord = true;
                        }
                        else if (dt.TableName == "Manager" && selectedRole == "Manager" && dt.Columns.Contains("ManagerID"))
                        {
                            if (Convert.ToInt32(row["ManagerID"]) == targetRoleId) 
                                isCurrentEditingRecord = true;
                        }
                        else if (dt.TableName == "Chef" && selectedRole == "Chef" && dt.Columns.Contains("ChefID"))
                        {
                            if (Convert.ToInt32(row["ChefID"]) == targetRoleId) 
                                isCurrentEditingRecord = true;
                        }
                        else if (dt.TableName == "Customer" && selectedRole == "Customer" && dt.Columns.Contains("CustomerID"))
                        {
                            if (Convert.ToInt32(row["CustomerID"]) == targetRoleId) 
                                isCurrentEditingRecord = true;
                        }

                        // If it matches skip the duplicate checks
                        if (isCurrentEditingRecord)
                        {
                            continue;
                        }

                        // Safely pull string values
                        string existingEmail = row["Email"]?.ToString() ?? "";
                        string existingPhone = row["Phone"]?.ToString() ?? "";

                        // Check if email matches or phone matches exactly on other account
                        if (existingEmail.Equals(targetEmail, StringComparison.OrdinalIgnoreCase) ||
                            existingPhone == targetPhone)
                        {
                            MessageBox.Show("Update Failed:\n\nThe Email Address or Phone Number is already assigned to another registered user account.",
                                "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Validation tracking failed:\n{ex.Message}", "Layer Isolation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // BIRTHDAY  DATE PROCESSING
            object databaseBirthdayValue = DBNull.Value;
            string dateInput = txtBirthday.Text.Trim();

            if (!string.IsNullOrWhiteSpace(dateInput))
            {
                DateTime parsedBirthday = DateTime.MinValue;
                bool isValidDate = DateTime.TryParseExact(dateInput,
                                                         "yyyy-MM-dd",
                                                         System.Globalization.CultureInfo.InvariantCulture,
                                                         System.Globalization.DateTimeStyles.None,
                                                         out parsedBirthday);
                if (!isValidDate)
                {
                    MessageBox.Show("Please enter the birthday format accurately as: YYYY-MM-DD", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                databaseBirthdayValue = parsedBirthday;
            }

            int assignedUserId = 0;
            if (selectedRole == "Admin") assignedUserId = 1;
            else if (selectedRole == "Manager") assignedUserId = 2;
            else if (selectedRole == "Customer") assignedUserId = 3;
            else if (selectedRole == "Chef") assignedUserId = 4;

            // OOP UPDATE ROUTING
            try
            {
                switch (selectedRole)
                {
                    case "Admin":
                        Admin targetAdmin = new Admin(
                            targetRoleId,
                            assignedUserId,
                            txtName.Text.Trim(),
                            txtEmail.Text.Trim(),
                            phoneInput,
                            databaseBirthdayValue,
                            txtAddress.Text.Trim(),
                            txtPassword.Text
                        );
                        targetAdmin.UpdateAdmin();
                        break;

                    case "Manager":
                        Manager targetManager = new Manager(
                            targetRoleId,
                            assignedUserId,
                            txtName.Text.Trim(),
                            txtEmail.Text.Trim(),
                            phoneInput,
                            databaseBirthdayValue,
                            txtAddress.Text.Trim(),
                            txtPassword.Text
                        );
                        targetManager.UpdateManager();
                        break;

                    case "Chef":
                        Chef targetChef = new Chef(
                            targetRoleId,
                            assignedUserId,
                            txtName.Text.Trim(),
                            txtEmail.Text.Trim(),
                            phoneInput,
                            databaseBirthdayValue,
                            txtAddress.Text.Trim(),
                            txtPassword.Text
                        );
                        targetChef.UpdateChef();
                        break;

                    case "Customer":
                        int structuralCurrentWalletBalance = 0;

                        Customer targetCustomer = new Customer(
                            targetRoleId,
                            assignedUserId,
                            txtName.Text.Trim(),
                            txtEmail.Text.Trim(),
                            phoneInput,
                            databaseBirthdayValue,
                            txtAddress.Text.Trim(),
                            txtPassword.Text,
                            structuralCurrentWalletBalance
                        );
                        targetCustomer.UpdateCustomer();
                        break;
                }

                MessageBox.Show($"{selectedRole} record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Failed:\n{ex.Message}", "OOP Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            txtSearchID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtBirthday.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            cboRole.SelectedIndex = -1;
        }


        private void ClearFields()
        {
            txtSearchID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtBirthday.Clear();
            txtEWallet.Text = "0";
            cboRole.SelectedIndex = -1;

            ToggleInputControls(false);
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