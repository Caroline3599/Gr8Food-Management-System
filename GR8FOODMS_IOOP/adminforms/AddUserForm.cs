using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace System_Admin_Assignment
{
    public partial class AddUserForm : Form
    {
        private int currentUserId;
        private string adminName;

        public AddUserForm(int userId, string name)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.adminName = name;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {;
            ToggleEWalletField();
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleEWalletField();
        }

        private void ToggleEWalletField()
        {
            if (cboRole.SelectedItem?.ToString() == "Customer")
            {
                txtEWallet.Enabled = true;
                txtEWallet.Text = "";
            }
            else
            {
                txtEWallet.Enabled = false;
                txtEWallet.Text = "N/A (Staff)";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // CHOOSE SELECTED ROLE
            if (cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a user role first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedRole = cboRole.SelectedItem.ToString();

            // TEXT VALIDATION
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Name, Email, Phone, and Password are strictly required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // PHONE NUMBER VALIDATION
            string phoneInput = txtPhone.Text.Trim();

            // Check  length
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

            // BIRTHDAY DATA PROCESSING
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

            //Duplicate phone and email validation
            try
            {
                string targetEmail = txtEmail.Text.Trim();
                string targetPhone = phoneInput;

                // call the classes
                Admin adminRef = new Admin(0);
                Manager managerRef = new Manager(0);
                Chef chefRef = new Chef(0);
                Customer customerRef = new Customer(0);

                // call readall methods
                DataTable[] allTables = new DataTable[]
                {
                    adminRef.ReadAllAdmins(),
                    managerRef.ReadAllManagers(),
                    chefRef.ReadAllChefs(),
                    customerRef.ReadAllCustomers()
                };

                // loop through every row of every table
                foreach (DataTable dt in allTables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // Safely pull string values out of the database cells
                        string existingEmail = row["Email"]?.ToString() ?? "";
                        string existingPhone = row["Phone"]?.ToString() ?? "";

                        // Check if email matches (ignoring capital letters) or phone matches exactly
                        if (existingEmail.Equals(targetEmail, StringComparison.OrdinalIgnoreCase) ||
                            existingPhone == targetPhone)
                        {
                            MessageBox.Show("Registration Failed:\n\nThe Email Address or Phone Number is already registered in the system.",
                                "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Stop the click event instantly
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Validation tracking failed:\n{ex.Message}", "Layer Isolation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // ROLE ID ASSIGNMENT
            int assignedUserId = 0;
            if (selectedRole == "Admin") assignedUserId = 1;
            else if (selectedRole == "Manager") assignedUserId = 2;
            else if (selectedRole == "Customer") assignedUserId = 3;
            else if (selectedRole == "Chef") assignedUserId = 4;

            // INPUT DATA
            try
            {
                switch (selectedRole)
                {
                    case "Admin":
                        Admin newAdmin = new Admin(
                            assignedUserId,
                            txtName.Text.Trim(),
                            txtEmail.Text.Trim(),
                            phoneInput,
                            databaseBirthdayValue,
                            txtAddress.Text.Trim(),
                            txtPassword.Text
                        );
                        newAdmin.AddAdmin();
                        break;

                    case "Manager":
                        Manager newManager = new Manager(
                            assignedUserId,
                            txtName.Text.Trim(),
                            txtEmail.Text.Trim(),
                            phoneInput,
                            databaseBirthdayValue,
                            txtAddress.Text.Trim(),
                            txtPassword.Text
                        );
                        newManager.AddManager();
                        break;

                    case "Chef":
                        Chef newChef = new Chef(
                            assignedUserId,
                            txtName.Text.Trim(),
                            txtEmail.Text.Trim(),
                            phoneInput,
                            databaseBirthdayValue,
                            txtAddress.Text.Trim(),
                            txtPassword.Text
                        );
                        newChef.AddChef();
                        break;

                    case "Customer":
                        Customer newCustomer = new Customer(
                            assignedUserId,
                            txtName.Text.Trim(),
                            txtEmail.Text.Trim(),
                            phoneInput,
                            databaseBirthdayValue,
                            txtAddress.Text.Trim(),
                            txtPassword.Text
                        );
                        newCustomer.AddCustomer();
                        break;
                }

                MessageBox.Show($"New {selectedRole} added successfully into the system!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add User Failed:\n{ex.Message}", "OOP Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
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
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtBirthday.Clear();
            cboRole.SelectedIndex = 1;
            ToggleEWalletField();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboard dashboard = new AdminDashboard(currentUserId, adminName);
            dashboard.Show();
            this.Close();
        }

        private void txtBirthday_TextChanged(object sender, EventArgs e)
        {

        }
    }
}