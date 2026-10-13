using Gr8Food.Classes;
using Ioop_Group_Assignment_Cheif;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GR8FOODMS_IOOP
{
    public partial class CustomerDashboard : Form
    {
        // declare variables
        private int customerID;
        private string customerName;

        // constructor
        public CustomerDashboard(int customerID, string customerName)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.customerName = customerName;
        }

        private void btnBrowseMenu_Click(object sender, EventArgs e)
        {
            BrowseMenu browseMenu = new BrowseMenu(customerID, customerName);
            browseMenu.Show();
            this.Hide();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            MyOrders myOrders = new MyOrders(customerID, customerName);
            myOrders.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm(customerID, customerName);
            feedback.Show();
            this.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            IOOP_Manager.UpdateProfile myProfile = new IOOP_Manager.UpdateProfile("Customer", this.customerID);
            this.Hide();
            myProfile.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginPage login = new LoginPage();
                login.Show();
                this.Close();
            }
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            // display welcome message
            lblWelcome.Text = "Welcome, " + customerName + "!";

            // load wallet balance
            LoadWalletBalance();
        }
        private void LoadWalletBalance()
        {
            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                string query = "SELECT EWallet FROM Customer WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                int balance = Convert.ToInt32(cmd.ExecuteScalar());
                lblWalletBalance.Text = "E-Wallet: RM " + balance.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            TopUpWallet topUp = new TopUpWallet(customerID, customerName);
            topUp.Show();
            this.Hide();
        }
    }
}
