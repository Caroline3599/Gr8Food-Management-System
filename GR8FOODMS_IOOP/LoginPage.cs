using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gr8Food.Classes;
using TeamAdminDashboard = System_Admin_Assignment.AdminDashboard;
using TeamChefDashboard = Ioop_Group_Assignment_Cheif.Cheif;
using TeamManagerDashboard = IOOP_Manager.ManagerHome;

namespace GR8FOODMS_IOOP
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // get values from textboxes
            string userID = txtUserID.Text.Trim();
            string password = txtPassword.Text.Trim();

            // validate empty fields separately
            if (string.IsNullOrEmpty(userID))
            {
                lblError.Text = "Please enter your Role ID!";
                lblError.ForeColor = System.Drawing.Color.Red;
                txtUserID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter your Password!";
                lblError.ForeColor = System.Drawing.Color.Red;
                txtPassword.Focus();
                return;
            }

            // validate userID is a number
            int parsedUserID;
            if (!int.TryParse(userID, out parsedUserID))
            {
                lblError.Text = "Role ID must be a number!";
                lblError.ForeColor = System.Drawing.Color.Red;
                txtUserID.Focus();
                return;
            }

            // validate userID is positive
            if (parsedUserID <= 0)
            {
                lblError.Text = "Please enter a valid Role ID!";
                lblError.ForeColor = System.Drawing.Color.Red;
                txtUserID.Focus();
                return;
            }

            // clear any previous error
            lblError.Text = "";

            try
            {
                DBHelper db = new DBHelper();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // STEP 1: Find out what role this User ID belongs to
                    string findRoleQuery = "SELECT [Role] FROM [dbo].[Users] WHERE [UserID] = @UserID";
                    string role = "";

                    using (SqlCommand roleCmd = new SqlCommand(findRoleQuery, conn))
                    {
                        roleCmd.Parameters.AddWithValue("@UserID", parsedUserID);
                        object roleResult = roleCmd.ExecuteScalar();

                        // Fixes the logical bug: Extract the text string from the query result safely
                        if (roleResult != null && roleResult != DBNull.Value)
                        {
                            role = roleResult.ToString().Trim();
                        }
                        else
                        {
                            lblError.Text = "Invalid User ID. No profile found.";
                            lblError.ForeColor = System.Drawing.Color.Red;
                            return;
                        }
                    }

                    // STEP 2: Query the specific table for that role to validate the password
                    string authQuery = "";
                    switch (role)
                    {
                        case "Admin":
                            authQuery = "SELECT [AdminID], [Name] FROM [Admin] WHERE [UserID] = @UserID AND [Password] = @Password";
                            break;
                        case "Customer":
                            authQuery = "SELECT [CustomerID], [Name] FROM [Customer] WHERE [UserID] = @UserID AND [Password] = @Password";
                            break;
                        case "Chef":
                            authQuery = "SELECT [ChefID], [Name] FROM [Chef] WHERE [UserID] = @UserID AND [Password] = @Password";
                            break;
                        case "Manager":
                            authQuery = "SELECT [ManagerID], [Name] FROM [Manager] WHERE [UserID] = @UserID AND [Password] = @Password";
                            break;
                        default:
                            MessageBox.Show("Unknown system role detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    using (SqlCommand authCmd = new SqlCommand(authQuery, conn))
                    {
                        authCmd.Parameters.AddWithValue("@UserID", parsedUserID);
                        authCmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = authCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Successfully found matching row and validated password!
                                string name = reader["Name"].ToString();
                                int roleSpecificID = Convert.ToInt32(reader[0]); // Grabs AdminID, CustomerID, etc. depending on query

                                reader.Close();
                                conn.Close();

                                // STEP 3: Route directly to your team members' clean, combined forms
                                OpenRoleDashboard(role, roleSpecificID, name);
                            }
                            else
                            {
                                lblError.Text = "Invalid Password. No profile found.";
                                lblError.ForeColor = System.Drawing.Color.Red;
                                reader.Close();
                                conn.Close();

                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenRoleDashboard(string role, int id, string name)
        {
            switch (role)
            {
                case "Customer":
                    CustomerDashboard customerDash = new CustomerDashboard(id, name);
                    customerDash.Show();
                    break;

                case "Admin":
                    // Uses the alias pointing directly to their laptop form
                    TeamAdminDashboard adminDash = new TeamAdminDashboard(id, name);
                    adminDash.Show();
                    break;

                case "Chef":
                    // Uses the alias pointing directly to their laptop form
                    TeamChefDashboard chefDash = new TeamChefDashboard(id, name);
                    chefDash.Show();
                    break;

                case "Manager":
                    // Uses the alias pointing directly to their laptop form
                    TeamManagerDashboard managerDash = new TeamManagerDashboard(id, name);
                    managerDash.Show();
                    break;
            }
            this.Hide();
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}