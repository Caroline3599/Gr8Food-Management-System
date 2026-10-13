using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Gr8Food.Classes;

namespace GR8FOODMS_IOOP
{
    public partial class BrowseMenu : Form
    {
        private int customerID;
        private string customerName;
        private int totalAmount = 0;
        private int selectedMenuID = -1;
        private int selectedPrice = 0;

        public BrowseMenu(int customerID, string customerName)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.customerName = customerName;
        }

        private void BrowseMenu_Load(object sender, EventArgs e)
        {
            // populate category combobox
            cboCategory.Items.Clear();
            cboCategory.Items.Add("All");
            cboCategory.Items.Add("Breakfast");
            cboCategory.Items.Add("Lunch");
            cboCategory.Items.Add("Dinner");
            cboCategory.Items.Add("Snacks");
            cboCategory.Items.Add("Drinks");
            cboCategory.SelectedIndex = 0;

            LoadWalletBalance();
            LoadMenu("All");
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

                object result = cmd.ExecuteScalar();
                if (result != null)
                    lblWalletBalance.Text = "E-Wallet: RM " + Convert.ToInt32(result).ToString();
                else
                    lblWalletBalance.Text = "E-Wallet: RM 0";

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

        private void LoadMenu(string category)
        {
            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                string query;
                SqlCommand cmd;

                if (category == "All")
                {
                    query = "SELECT MenuID, ItemName, Category, Price FROM Menu WHERE Status = 'Available'";
                    cmd = new SqlCommand(query, conn);
                }
                else
                {
                    query = "SELECT MenuID, ItemName, Category, Price FROM Menu WHERE Status = 'Available' AND Category = @Category";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Category", category);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvMenu.DataSource = dt;
                conn.Close();

                // check if no menu items available
                if (dgvMenu.Rows.Count == 0)
                {
                    lblSelectedItem.Text = "No items available in this category";
                    lblSelectedPrice.Text = "Price: -";
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

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reset selected item when category changes
            selectedMenuID = -1;
            selectedPrice = 0;
            lblSelectedItem.Text = "No item selected";
            lblSelectedPrice.Text = "Price: -";
            LoadMenu(cboCategory.SelectedItem.ToString());
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // validate row has valid data
                if (dgvMenu.Rows[e.RowIndex].Cells[0].Value == null) return;

                // store selected item details
                selectedMenuID = Convert.ToInt32(dgvMenu.Rows[e.RowIndex].Cells[0].Value);
                lblSelectedItem.Text = dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
                selectedPrice = Convert.ToInt32(dgvMenu.Rows[e.RowIndex].Cells[3].Value);
                lblSelectedPrice.Text = "Price: RM " + selectedPrice.ToString();

                // clear quantity when new item selected
                txtQuantity.Text = "";
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // validate item selected
            if (selectedMenuID == -1)
            {
                MessageBox.Show("Please select an item from the menu first!", "No Item Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validate quantity not empty
            if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a quantity!", "No Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // validate quantity is a number
            int quantity;
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity))
            {
                MessageBox.Show("Quantity must be a number!", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                txtQuantity.SelectAll();
                return;
            }

            // validate quantity is greater than 0
            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0!", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                txtQuantity.SelectAll();
                return;
            }

            // validate quantity does not exceed 99
            if (quantity > 99)
            {
                MessageBox.Show("Quantity cannot exceed 99!", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                txtQuantity.SelectAll();
                return;
            }

            int subtotal = selectedPrice * quantity;

            // add to cart listview
            ListViewItem item = new ListViewItem(lblSelectedItem.Text);
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add("RM " + selectedPrice.ToString());
            item.SubItems.Add("RM " + subtotal.ToString());
            item.Tag = selectedMenuID;

            lvCart.Items.Add(item);

            // update total
            totalAmount += subtotal;
            lblTotal.Text = "Total: RM " + totalAmount.ToString();

            // clear quantity
            txtQuantity.Text = "";
            txtQuantity.Focus();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item from the cart to remove!", "No Item Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // confirm removal
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove " + lvCart.SelectedItems[0].Text + " from the cart?",
                "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // deduct from total
                int subtotal = Convert.ToInt32(lvCart.SelectedItems[0].SubItems[3].Text.Replace("RM ", ""));
                totalAmount -= subtotal;
                lblTotal.Text = "Total: RM " + totalAmount.ToString();

                lvCart.Items.Remove(lvCart.SelectedItems[0]);
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            // validate cart not empty
            if (lvCart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty! Please add items before confirming.",
                    "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // confirm order
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to place this order?\nTotal: RM " + totalAmount.ToString(),
                "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();
                conn.Open();

                // check wallet balance
                string balanceQuery = "SELECT EWallet FROM Customer WHERE CustomerID = @CustomerID";
                SqlCommand balanceCmd = new SqlCommand(balanceQuery, conn);
                balanceCmd.Parameters.AddWithValue("@CustomerID", customerID);
                int walletBalance = Convert.ToInt32(balanceCmd.ExecuteScalar());

                if (totalAmount > walletBalance)
                {
                    MessageBox.Show("Insufficient wallet balance!\nYour balance: RM " + walletBalance.ToString() +
                                    "\nOrder total: RM " + totalAmount.ToString(),
                                    "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // get next OrderID
                string maxOrderQuery = "SELECT ISNULL(MAX(OrderID), 0) + 1 FROM [Order]";
                SqlCommand maxOrderCmd = new SqlCommand(maxOrderQuery, conn);
                int newOrderID = Convert.ToInt32(maxOrderCmd.ExecuteScalar());

                // insert into Order table
                string orderQuery = "INSERT INTO [Order] (OrderID, CustomerID, OrderDate, OrderStatus, OrderRemarks) " +
                                    "VALUES (@OrderID, @CustomerID, @OrderDate, @OrderStatus, @OrderRemarks)";
                SqlCommand orderCmd = new SqlCommand(orderQuery, conn);
                orderCmd.Parameters.AddWithValue("@OrderID", newOrderID);
                orderCmd.Parameters.AddWithValue("@CustomerID", customerID);
                orderCmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.Date);
                orderCmd.Parameters.AddWithValue("@OrderStatus", "In progress");
                orderCmd.Parameters.AddWithValue("@OrderRemarks", txtRemarks.Text.Trim());
                orderCmd.ExecuteNonQuery();

                // get next OrderDetailID
                string maxDetailQuery = "SELECT ISNULL(MAX(OrderDetailID), 0) + 1 FROM OrderDetails";
                SqlCommand maxDetailCmd = new SqlCommand(maxDetailQuery, conn);
                int newDetailID = Convert.ToInt32(maxDetailCmd.ExecuteScalar());

                // insert into OrderDetails table
                foreach (ListViewItem item in lvCart.Items)
                {
                    int menuID = Convert.ToInt32(item.Tag);
                    int quantity = Convert.ToInt32(item.SubItems[1].Text);

                    string detailsQuery = "INSERT INTO OrderDetails (OrderDetailID, OrderID, MenuID, Quantity) " +
                                          "VALUES (@OrderDetailID, @OrderID, @MenuID, @Quantity)";
                    SqlCommand detailsCmd = new SqlCommand(detailsQuery, conn);
                    detailsCmd.Parameters.AddWithValue("@OrderDetailID", newDetailID);
                    detailsCmd.Parameters.AddWithValue("@OrderID", newOrderID);
                    detailsCmd.Parameters.AddWithValue("@MenuID", menuID);
                    detailsCmd.Parameters.AddWithValue("@Quantity", quantity);
                    detailsCmd.ExecuteNonQuery();

                    newDetailID++;
                }

                // deduct wallet balance
                string deductQuery = "UPDATE Customer SET EWallet = EWallet - @Amount WHERE CustomerID = @CustomerID";
                SqlCommand deductCmd = new SqlCommand(deductQuery, conn);
                deductCmd.Parameters.AddWithValue("@Amount", totalAmount);
                deductCmd.Parameters.AddWithValue("@CustomerID", customerID);
                deductCmd.ExecuteNonQuery();

                // get next BalanceID
                string maxBalanceQuery = "SELECT ISNULL(MAX(BalanceID), 0) + 1 FROM Balance";
                SqlCommand maxBalanceCmd = new SqlCommand(maxBalanceQuery, conn);
                int newBalanceID = Convert.ToInt32(maxBalanceCmd.ExecuteScalar());

                // insert into Balance table
                string balanceInsertQuery = "INSERT INTO Balance (BalanceID, CustomerID, Type, Amount, date, RelatedOrderID) " +
                                            "VALUES (@BalanceID, @CustomerID, @Type, @Amount, @Date, @RelatedOrderID)";
                SqlCommand balanceInsertCmd = new SqlCommand(balanceInsertQuery, conn);
                balanceInsertCmd.Parameters.AddWithValue("@BalanceID", newBalanceID);
                balanceInsertCmd.Parameters.AddWithValue("@CustomerID", customerID);
                balanceInsertCmd.Parameters.AddWithValue("@Type", "Dedection");
                balanceInsertCmd.Parameters.AddWithValue("@Amount", totalAmount);
                balanceInsertCmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                balanceInsertCmd.Parameters.AddWithValue("@RelatedOrderID", newOrderID);
                balanceInsertCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Order placed successfully!\nRM " + totalAmount.ToString() +
                                " has been deducted from your e-wallet.",
                                "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // clear cart
                lvCart.Items.Clear();
                totalAmount = 0;
                lblTotal.Text = "Total: RM 0";
                txtRemarks.Text = "";
                selectedMenuID = -1;
                lblSelectedItem.Text = "No item selected";
                lblSelectedPrice.Text = "Price: -";

                // refresh wallet balance
                LoadWalletBalance();
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
            // confirm if cart is not empty
            if (lvCart.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "You have items in your cart. Are you sure you want to go back?\nYour cart will be cleared.",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;
            }

            CustomerDashboard dashboard = new CustomerDashboard(customerID, customerName);
            dashboard.Show();
            this.Close();
        }
    }
}