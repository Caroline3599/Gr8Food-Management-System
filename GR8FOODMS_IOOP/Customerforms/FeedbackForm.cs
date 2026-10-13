using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gr8Food.Classes;

namespace GR8FOODMS_IOOP
{
    public partial class FeedbackForm : Form
    {
        private int customerID;
        private string customerName;

        public FeedbackForm(int customerID, string customerName)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.customerName = customerName;
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            LoadCompletedOrders();
        }

        private void LoadCompletedOrders()
        {
            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                // load completed orders that don't have feedback yet
                string query = "SELECT o.OrderID, o.OrderDate " +
                               "FROM [Order] o " +
                               "WHERE o.CustomerID = @CustomerID " +
                               "AND o.OrderStatus = 'Complete' " +
                               "AND o.OrderID NOT IN " +
                               "(SELECT OrderID FROM Feedback WHERE CustomerID = @CustomerID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                SqlDataReader reader = cmd.ExecuteReader();

                cboCompletedOrders.Items.Clear();

                while (reader.Read())
                {
                    cboCompletedOrders.Items.Add(new ComboBoxItem(
                        Convert.ToInt32(reader["OrderID"]),
                        "Order #" + reader["OrderID"].ToString() + " - " +
                        Convert.ToDateTime(reader["OrderDate"]).ToString("dd/MM/yyyy")
                    ));
                }

                reader.Close();
                conn.Close();

                // check if there are completed orders
                if (cboCompletedOrders.Items.Count == 0)
                {
                    lblMessage.Text = "You have no completed orders to give feedback on!";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    btnSubmitFeedback.Enabled = false;
                    cboCompletedOrders.Enabled = false;
                    txtFeedback.Enabled = false;
                }
                else
                {
                    cboCompletedOrders.SelectedIndex = 0;
                    btnSubmitFeedback.Enabled = true;
                    cboCompletedOrders.Enabled = true;
                    txtFeedback.Enabled = true;
                    lblMessage.Text = "";
                }
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

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            // validate order selected
            if (cboCompletedOrders.SelectedItem == null)
            {
                lblMessage.Text = "Please select an order!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }
            // validate minimum length
            if (txtFeedback.Text.Trim().Length < 10)
            {
                lblMessage.Text = "Feedback must be at least 10 characters!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                txtFeedback.Focus();
                return;
            }

            // validate maximum length
            if (txtFeedback.Text.Trim().Length > 100)
            {
                lblMessage.Text = "Feedback must not exceed 100 characters!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                txtFeedback.Focus();
                return;
            }

            // validate feedback text
            if (txtFeedback.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter your feedback!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                txtFeedback.Focus();
                return;
            }

            try
            {
                int orderID = ((ComboBoxItem)cboCompletedOrders.SelectedItem).OrderID;

                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                // double check feedback doesn't already exist
                string checkQuery = "SELECT COUNT(*) FROM Feedback WHERE OrderID = @OrderID AND CustomerID = @CustomerID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@OrderID", orderID);
                checkCmd.Parameters.AddWithValue("@CustomerID", customerID);
                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    lblMessage.Text = "You have already submitted feedback for this order!";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    conn.Close();
                    LoadCompletedOrders();
                    return;
                }

                // get next FeedbackID
                string maxFeedbackQuery = "SELECT ISNULL(MAX(FeedbackID), 0) + 1 FROM Feedback";
                SqlCommand maxFeedbackCmd = new SqlCommand(maxFeedbackQuery, conn);
                int newFeedbackID = Convert.ToInt32(maxFeedbackCmd.ExecuteScalar());

                // insert feedback
                string query = "INSERT INTO Feedback (FeedbackID, Text, OrderID, CustomerID) " +
                               "VALUES (@FeedbackID, @Text, @OrderID, @CustomerID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FeedbackID", newFeedbackID);
                cmd.Parameters.AddWithValue("@Text", txtFeedback.Text.Trim());
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.ExecuteNonQuery();

                conn.Close();

                lblMessage.Text = "Feedback submitted successfully!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Feedback submitted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFeedback.Text = "";

                // reload to remove submitted order from list
                LoadCompletedOrders();
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

        // helper class for combobox
        public class ComboBoxItem
        {
            public int OrderID { get; set; }
            public string DisplayText { get; set; }

            public ComboBoxItem(int orderID, string displayText)
            {
                OrderID = orderID;
                DisplayText = displayText;
            }

            public override string ToString()
            {
                return DisplayText;
            }

        }
    }
}


