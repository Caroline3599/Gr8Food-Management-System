using Gr8Food.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GR8FOODMS_IOOP
{
    public partial class TopUpWallet : Form
    {
        private int customerID;
        private string customerName;


        public TopUpWallet(int customerID, string customerName)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.customerName = customerName;
        }

        private void TopUpWallet_Load(object sender, EventArgs e)
        {
            LoadCurrentBalance();
        }
        private void LoadCurrentBalance()
        {
            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                string query = "SELECT EWallet FROM Customer WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                object result = cmd.ExecuteScalar();
                if (result != null)
                    lblCurrentBalance.Text = "Current Balance: RM " + Convert.ToInt32(result).ToString();
                else
                    lblCurrentBalance.Text = "Current Balance: RM 0";

                conn.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmTopUp_Click(object sender, EventArgs e)
        {
            // validate empty
            if (txtAmount.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter a top up amount!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                txtAmount.Focus();
                return;
            }

            // validate is a number
            int amount;
            if (!int.TryParse(txtAmount.Text.Trim(), out amount))
            {
                lblMessage.Text = "Top up amount must be a number!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                txtAmount.Focus();
                txtAmount.SelectAll();
                return;
            }

            // validate greater than 0
            if (amount <= 0)
            {
                lblMessage.Text = "Top up amount must be greater than 0!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                txtAmount.Focus();
                txtAmount.SelectAll();
                return;
            }

            // validate minimum top up
            if (amount < 10)
            {
                lblMessage.Text = "Minimum top up amount is RM 10!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                txtAmount.Focus();
                txtAmount.SelectAll();
                return;
            }

            // validate maximum top up
            if (amount > 500)
            {
                lblMessage.Text = "Maximum top up amount is RM 500!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                txtAmount.Focus();
                txtAmount.SelectAll();
                return;
            }

            // confirm top up
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to top up RM " + amount.ToString() + " to your e-wallet?",
                "Confirm Top Up", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                // 1. update Customer.EWallet
                // Admin sees this in ViewTablesForm → Customer table
                string updateQuery = "UPDATE Customer SET EWallet = EWallet + @Amount WHERE CustomerID = @CustomerID";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@Amount", amount);
                updateCmd.Parameters.AddWithValue("@CustomerID", customerID);
                updateCmd.ExecuteNonQuery();

                // 2. get next BalanceID
                string maxBalanceQuery = "SELECT ISNULL(MAX(BalanceID), 0) + 1 FROM Balance";
                SqlCommand maxBalanceCmd = new SqlCommand(maxBalanceQuery, conn);
                int newBalanceID = Convert.ToInt32(maxBalanceCmd.ExecuteScalar());

                // 3. insert into Balance table with Type = 'Top Up'
                // Manager sees this in ViewEWallet → ManagerWalletReportRepository
                // which filters Balance table by CustomerID, Year, Month
                string balanceQuery = "INSERT INTO Balance (BalanceID, CustomerID, Type, Amount, date, RelatedOrderID) " +
                                      "VALUES (@BalanceID, @CustomerID, @Type, @Amount, @Date, @RelatedOrderID)";
                SqlCommand balanceCmd = new SqlCommand(balanceQuery, conn);
                balanceCmd.Parameters.AddWithValue("@BalanceID", newBalanceID);
                balanceCmd.Parameters.AddWithValue("@CustomerID", customerID);
                balanceCmd.Parameters.AddWithValue("@Type", "Top Up");
                balanceCmd.Parameters.AddWithValue("@Amount", amount);
                balanceCmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                balanceCmd.Parameters.AddWithValue("@RelatedOrderID", DBNull.Value);
                balanceCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Successfully topped up RM " + amount.ToString() + " to your e-wallet!",
                    "Top Up Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // refresh balance display
                LoadCurrentBalance();
                txtAmount.Text = "";
                lblMessage.Text = "";
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard(customerID, customerName);
            dashboard.Show();
            this.Close();
        }
    }
}
