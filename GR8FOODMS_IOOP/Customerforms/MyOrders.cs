using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Gr8Food.Classes;

namespace GR8FOODMS_IOOP
{
    public partial class MyOrders : Form
    {
        private int customerID;
        private string customerName;

        public MyOrders(int customerID, string customerName)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.customerName = customerName;
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            LoadWalletBalance();
            LoadOrders();
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

        private void LoadOrders()
        {
            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                string query = "SELECT OrderID, OrderDate, OrderStatus, OrderRemarks " +
                               "FROM [Order] WHERE CustomerID = @CustomerID " +
                               "ORDER BY OrderDate DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrders.DataSource = dt;
                conn.Close();

                // color code the status
                foreach (DataGridViewRow row in dgvOrders.Rows)
                {
                    if (row.Cells["OrderStatus"].Value != null)
                    {
                        string status = row.Cells["OrderStatus"].Value.ToString();
                        if (status == "In progress")
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                        else if (status == "Complete")
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else if (status == "Cancel")
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadOrderDetails(int orderID)
        {
            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                string query = "SELECT m.ItemName, od.Quantity, m.Price, " +
                               "(od.Quantity * m.Price) AS Subtotal " +
                               "FROM OrderDetails od " +
                               "JOIN Menu m ON od.MenuID = m.MenuID " +
                               "WHERE od.OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderDetails.DataSource = dt;

                // calculate total
                int total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToInt32(row["Subtotal"]);
                }
                lblOrderTotal.Text = "Order Total: RM " + total.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value);
                LoadOrderDetails(orderID);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to cancel!");
                return;
            }

            string status = dgvOrders.SelectedRows[0].Cells["OrderStatus"].Value.ToString();

            if (status == "Complete")
            {
                MessageBox.Show("This order cannot be cancelled as it is already completed!");
                return;
            }

            if (status == "Cancel")
            {
                MessageBox.Show("This order is already cancelled!");
                return;
            }

            // confirm cancellation
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this order?",
                                                  "Cancel Order", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderID"].Value);

                    DBHelper db = new DBHelper();
                    SqlConnection conn = db.GetConnection();
                    conn.Open();

                    // get order total from Menu price
                    string totalQuery = "SELECT SUM(od.Quantity * m.Price) " +
                                        "FROM OrderDetails od " +
                                        "JOIN Menu m ON od.MenuID = m.MenuID " +
                                        "WHERE od.OrderID = @OrderID";
                    SqlCommand totalCmd = new SqlCommand(totalQuery, conn);
                    totalCmd.Parameters.AddWithValue("@OrderID", orderID);
                    int orderTotal = Convert.ToInt32(totalCmd.ExecuteScalar());

                    // update order status to Cancel
                    string cancelQuery = "UPDATE [Order] SET OrderStatus = 'Cancel' WHERE OrderID = @OrderID";
                    SqlCommand cancelCmd = new SqlCommand(cancelQuery, conn);
                    cancelCmd.Parameters.AddWithValue("@OrderID", orderID);
                    cancelCmd.ExecuteNonQuery();

                    // refund wallet balance
                    string refundQuery = "UPDATE Customer SET EWallet = EWallet + @Amount WHERE CustomerID = @CustomerID";
                    SqlCommand refundCmd = new SqlCommand(refundQuery, conn);
                    refundCmd.Parameters.AddWithValue("@Amount", orderTotal);
                    refundCmd.Parameters.AddWithValue("@CustomerID", customerID);
                    refundCmd.ExecuteNonQuery();

                    // get next BalanceID
                    string maxBalanceQuery = "SELECT ISNULL(MAX(BalanceID), 0) + 1 FROM Balance";
                    SqlCommand maxBalanceCmd = new SqlCommand(maxBalanceQuery, conn);
                    int newBalanceID = Convert.ToInt32(maxBalanceCmd.ExecuteScalar());

                    // insert into Balance table
                    string balanceQuery = "INSERT INTO Balance (BalanceID, CustomerID, Type, Amount, date, RelatedOrderID) " +
                                          "VALUES (@BalanceID, @CustomerID, @Type, @Amount, @Date, @RelatedOrderID)";
                    SqlCommand balanceCmd = new SqlCommand(balanceQuery, conn);
                    balanceCmd.Parameters.AddWithValue("@BalanceID", newBalanceID);
                    balanceCmd.Parameters.AddWithValue("@CustomerID", customerID);
                    balanceCmd.Parameters.AddWithValue("@Type", "Cancel");
                    balanceCmd.Parameters.AddWithValue("@Amount", orderTotal);
                    balanceCmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    balanceCmd.Parameters.AddWithValue("@RelatedOrderID", orderID);
                    balanceCmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Order cancelled and refund of RM " + orderTotal.ToString() + " has been processed!");

                    // refresh
                    LoadOrders();
                    LoadWalletBalance();
                    dgvOrderDetails.DataSource = null;
                    lblOrderTotal.Text = "Order Total: RM 0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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
