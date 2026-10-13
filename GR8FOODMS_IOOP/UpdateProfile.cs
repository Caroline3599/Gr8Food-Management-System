using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System_Admin_Assignment;

namespace IOOP_Manager
{
    public partial class UpdateProfile : Form
    {
        private string currentRole;
        private int currentRecordId;
        private int currentUserId;

        // Default Constructor
        public UpdateProfile()
        {
            InitializeComponent();
            btnM2Up.Text = "Update";
            AttachValidationEvents();
        }

        public UpdateProfile(string role, int recordId)
        {
            InitializeComponent();
            this.currentRole = role;
            this.currentRecordId = recordId;

            btnM2Up.Text = "Update " + role;

            AttachValidationEvents();
        }

        private void ManagerProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void AttachValidationEvents()
        {
            tbMPhone.KeyPress += TbMPhone_KeyPress;
            tbMPhone.Validating += TbMPhone_Validating;
            tbMBirth.Validating += TbMBirth_Validating;
        }

        /// Reads database
        private void LoadProfileData()
        {
            try
            {
                switch (currentRole)
                {
                    case "Admin":
                        System_Admin_Assignment.Admin adminsearcher = new System_Admin_Assignment.Admin(currentRecordId);
                        System_Admin_Assignment.Admin admin = adminsearcher.ReadAdmin();
                        if (admin != null)
                        {
                            this.currentUserId = admin.UserID;
                            lblUID.Text = currentRecordId.ToString();

                            tbMName.Text = admin.AdminName;
                            tbMEmail.Text = admin.Email;
                            tbMPhone.Text = admin.Phone;
                            tbMAddress.Text = admin.Address?.ToString() ?? "";
                            tbMPw.Text = admin.Password;
                            AssignBirthdayFallback(admin.Birthday);
                        }
                        else
                        {
                            MessageBox.Show("Admin record could not be located.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        break;

                    case "Chef":
                        System_Admin_Assignment.Chef chefsearcher = new System_Admin_Assignment.Chef(currentRecordId);
                        System_Admin_Assignment.Chef chef = chefsearcher.ReadChef();
                        if (chef != null)
                        {
                            this.currentUserId = chef.UserID;

                            lblUID.Text = currentRecordId.ToString();

                            tbMName.Text = chef.ChefName;
                            tbMEmail.Text = chef.Email;
                            tbMPhone.Text = chef.Phone;
                            tbMAddress.Text = chef.Address?.ToString() ?? "";
                            tbMPw.Text = chef.Password;
                            AssignBirthdayFallback(chef.Birthday);
                        }
                        else
                        {
                            MessageBox.Show("Chef profile record could not be found in the database.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        break;

                    case "Customer":
                        System_Admin_Assignment.Customer customersearcher = new System_Admin_Assignment.Customer(currentRecordId);
                        System_Admin_Assignment.Customer customer = customersearcher.ReadCustomer();
                        if (customer != null)
                        {
                            this.currentUserId = customer.UserID;
                            lblUID.Text = currentRecordId.ToString();

                            tbMName.Text = customer.CustomerName;
                            tbMEmail.Text = customer.Email;
                            tbMPhone.Text = customer.Phone;
                            tbMAddress.Text = customer.Address?.ToString() ?? "";
                            tbMPw.Text = customer.Password;
                            AssignBirthdayFallback(customer.Birthday);
                        }
                        else
                        {
                            MessageBox.Show("Customer profile record could not be found.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        break;

                    case "Manager":
                        System_Admin_Assignment.Manager managersearcher = new System_Admin_Assignment.Manager(currentRecordId);
                        System_Admin_Assignment.Manager manager = managersearcher.ReadManager();
                        if (manager != null)
                        {
                            this.currentUserId = manager.UserID;
                            lblUID.Text = currentRecordId.ToString();

                            tbMName.Text = manager.ManagerName;
                            tbMEmail.Text = manager.Email;
                            tbMPhone.Text = manager.Phone;
                            tbMAddress.Text = manager.Address?.ToString() ?? "";
                            tbMPw.Text = manager.Password;
                            AssignBirthdayFallback(manager.Birthday);
                        }
                        else
                        {
                            MessageBox.Show("Manager record could not be located.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        break;

                    default:
                        MessageBox.Show("Unknown profile role context specified.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mapping record properties onto components:\n\n" + ex.Message, "Fetch Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AssignBirthdayFallback(object rawBirthday)
        {
            if (rawBirthday != null && DateTime.TryParse(rawBirthday.ToString(), out DateTime dateVal))
            {
                // Format the database DateTime into the explicit string pattern yyyy-MM-dd
                tbMBirth.Text = dateVal.ToString("yyyy-MM-dd");
            }
            else
            {
                tbMBirth.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        private void TbMPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbMPhone_Validating(object sender, CancelEventArgs e)
        {
            string phone = tbMPhone.Text.Trim();
            string email = tbMEmail.Text.Trim();

            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 11 digits long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            char expectedStart = ' ';
            switch (currentRole)
            {
                case "Admin": expectedStart = '1'; break;
                case "Customer": expectedStart = '2'; break;
                case "Chef": expectedStart = '3'; break;
                case "Manager": expectedStart = '4'; break;
            }

            if (phone[0] != expectedStart)
            {
                MessageBox.Show($"{currentRole} phone numbers must start with the digit '{expectedStart}'!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        /// Strict Validation rule keeping user entry completely constrained to yyyy-mm-dd format
        private void TbMBirth_Validating(object sender, CancelEventArgs e)
        {
            string inputDate = tbMBirth.Text.Trim();

            if (!DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime validatedDate))
            {
                MessageBox.Show("Birthday format must be exactly yyyy-mm-dd! (Example: 2005-12-31)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            // Ensure they can't save a date that is set in the future
            if (validatedDate.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Birthday cannot be a date in the future!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void btnM2Up_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Please fix structural validation issues before continuing.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbMEmail.Text) || !tbMEmail.Text.Contains("@") || !tbMEmail.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    string targetEmail = tbMEmail.Text.Trim();
                    string targetPhone = tbMPhone.Text.Trim();

                    // Call the classes
                    System_Admin_Assignment.Admin adminRef = new System_Admin_Assignment.Admin(0);
                    System_Admin_Assignment.Manager managerRef = new System_Admin_Assignment.Manager(0);
                    System_Admin_Assignment.Chef chefRef = new System_Admin_Assignment.Chef(0);
                    System_Admin_Assignment.Customer customerRef = new System_Admin_Assignment.Customer(0);

                    // Call readall methods
                    DataTable[] allTables = new DataTable[]
                    {
                        adminRef.ReadAllAdmins(),
                        managerRef.ReadAllManagers(),
                        chefRef.ReadAllChefs(),
                        customerRef.ReadAllCustomers()
                    };

                    allTables[0].TableName = "Admin";
                    allTables[1].TableName = "Manager";
                    allTables[2].TableName = "Chef";
                    allTables[3].TableName = "Customer";

                    // Loop through every row of every table
                    foreach (DataTable dt in allTables)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            // Skip the validation check if this row belongs to the active profile being updated
                            bool isCurrentEditingRecord = false;

                            if (dt.TableName == "Admin" && currentRole == "Admin" && dt.Columns.Contains("AdminID"))
                            {
                                if (Convert.ToInt32(row["AdminID"]) == currentRecordId) isCurrentEditingRecord = true;
                            }
                            else if (dt.TableName == "Manager" && currentRole == "Manager" && dt.Columns.Contains("ManagerID"))
                            {
                                if (Convert.ToInt32(row["ManagerID"]) == currentRecordId) isCurrentEditingRecord = true;
                            }
                            else if (dt.TableName == "Chef" && currentRole == "Chef" && dt.Columns.Contains("ChefID"))
                            {
                                if (Convert.ToInt32(row["ChefID"]) == currentRecordId) isCurrentEditingRecord = true;
                            }
                            else if (dt.TableName == "Customer" && currentRole == "Customer" && dt.Columns.Contains("CustomerID"))
                            {
                                if (Convert.ToInt32(row["CustomerID"]) == currentRecordId) isCurrentEditingRecord = true;
                            }

                            // If this matches the logged-in profile, skip it
                            if (isCurrentEditingRecord)
                            {
                                continue;
                            }

                            string existingEmail = row["Email"]?.ToString() ?? "";
                            string existingPhone = row["Phone"]?.ToString() ?? "";

                            // Check if email or phone matches someone else's record
                            if (existingEmail.Equals(targetEmail, StringComparison.OrdinalIgnoreCase) ||
                                existingPhone == targetPhone)
                            {
                                MessageBox.Show("Update Failed:\n\nThe Email Address or Phone Number is already registered to another user profile.",
                                    "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"System uniqueness tracking verification failed:\n{ex.Message}", "Layer Isolation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string passedAddress = tbMAddress.Text;
                string formattedBirthday = tbMBirth.Text.Trim();

                switch (currentRole)
                {
                    case "Admin":
                        System_Admin_Assignment.Admin targetAdmin = new System_Admin_Assignment.Admin(this.currentUserId, tbMName.Text, tbMEmail.Text, tbMPhone.Text, formattedBirthday, passedAddress, tbMPw.Text);

                        typeof(System_Admin_Assignment.Admin).GetField("_AdminID", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(targetAdmin, currentRecordId);
                        typeof(System_Admin_Assignment.Admin).GetField("_UserID", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(targetAdmin, this.currentUserId);

                        targetAdmin.UpdateAdmin();
                        break;

                    case "Chef":
                        System_Admin_Assignment.Chef targetChef = new System_Admin_Assignment.Chef(this.currentUserId, tbMName.Text, tbMEmail.Text, tbMPhone.Text, formattedBirthday, passedAddress, tbMPw.Text);

                        typeof(System_Admin_Assignment.Chef).GetField("_ChefID", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(targetChef, currentRecordId);
                        typeof(System_Admin_Assignment.Chef).GetField("_UserID", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(targetChef, this.currentUserId);

                        targetChef.UpdateChef();
                        break;

                    case "Customer":
                        System_Admin_Assignment.Customer targetCustomer = new System_Admin_Assignment.Customer(this.currentUserId, tbMName.Text, tbMEmail.Text, tbMPhone.Text, formattedBirthday, passedAddress, tbMPw.Text);

                        typeof(System_Admin_Assignment.Customer).GetField("_CustomerID", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(targetCustomer, currentRecordId);
                        typeof(System_Admin_Assignment.Customer).GetField("_UserID", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(targetCustomer, this.currentUserId);

                        targetCustomer.UpdateCustomerForOwnProfile();
                        break;

                    case "Manager":
                        System_Admin_Assignment.Manager targetManager = new System_Admin_Assignment.Manager(this.currentUserId, tbMName.Text, tbMEmail.Text, tbMPhone.Text, formattedBirthday, passedAddress, tbMPw.Text);

                        typeof(System_Admin_Assignment.Manager).GetField("_ManagerID", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(targetManager, currentRecordId);
                        typeof(System_Admin_Assignment.Manager).GetField("_UserID", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(targetManager, this.currentUserId);

                        targetManager.UpdateManager();
                        break;
                }

                MessageBox.Show($"{currentRole} Profile Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Execution pipeline encountered an issue: " + ex.Message, "Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnM2Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}