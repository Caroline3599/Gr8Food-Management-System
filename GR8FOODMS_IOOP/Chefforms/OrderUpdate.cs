using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Gr8Food.Classes;

namespace Ioop_Group_Assignment_Cheif
{
    public partial class OrderUpdate : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable ordersTable;

        public OrderUpdate()
        {
            InitializeComponent();

            ordersTable = new DataTable();

            this.Load += OrderUpdate_Load;
            this.Resize += OrderUpdate_Resize;
        }

        private void OrderUpdate_Load(object sender, EventArgs e)
        {
            LayoutControls();
            LoadOrdersData();
        }

        private void OrderUpdate_Resize(object sender, EventArgs e)
        {
            LayoutControls();
        }

        private void LayoutControls()
        {
            const int padding = 20;
            const int buttonHeight = 35;
            const int buttonWidth = 120;
            const int buttonAreaHeight = buttonHeight + (padding * 2);

            if (dgvOrderUpdate == null) return;

            dgvOrderUpdate.Left = padding;
            dgvOrderUpdate.Top = padding;
            dgvOrderUpdate.Width = ClientSize.Width - (padding * 2);
            dgvOrderUpdate.Height = ClientSize.Height - buttonAreaHeight - padding;

            dgvOrderUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            int buttonY = ClientSize.Height - buttonHeight - padding;

            btnOrders.Width = buttonWidth;
            btnOrders.Height = buttonHeight;
            btnOrders.Left = padding;
            btnOrders.Top = buttonY;

            btnSave.Width = buttonWidth;
            btnSave.Height = buttonHeight;
            btnSave.Left = (ClientSize.Width - buttonWidth) / 2;
            btnSave.Top = buttonY;

            btnHomePage.Width = buttonWidth;
            btnHomePage.Height = buttonHeight;
            btnHomePage.Left = ClientSize.Width - buttonWidth - padding;
            btnHomePage.Top = buttonY;
        }

        private void LoadOrdersData()
        {
            try
            {
                string query = "SELECT * FROM [Order]";

                ordersTable.Clear();

                DBHelper db = new DBHelper();
                SqlConnection conn = db.GetConnection();

                dataAdapter = new SqlDataAdapter(query, conn);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Fill(ordersTable);

                BindGrid(ordersTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading orders:\n\n" + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BindGrid(DataTable dt)
        {
            dgvOrderUpdate.DataSource = null;
            dgvOrderUpdate.AutoGenerateColumns = true;
            dgvOrderUpdate.DataSource = dt;

            dgvOrderUpdate.ReadOnly = false;
            dgvOrderUpdate.AllowUserToAddRows = false;
            dgvOrderUpdate.AllowUserToDeleteRows = false;

            dgvOrderUpdate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderUpdate.MultiSelect = false;
            dgvOrderUpdate.RowHeadersVisible = true;
            dgvOrderUpdate.AllowUserToResizeRows = false;
            dgvOrderUpdate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvOrderUpdate.Columns.Contains("OrderID"))
                dgvOrderUpdate.Columns["OrderID"].ReadOnly = true;

            if (dgvOrderUpdate.Columns.Contains("CustomerID"))
                dgvOrderUpdate.Columns["CustomerID"].ReadOnly = true;

            if (dgvOrderUpdate.Columns.Contains("OrderDate"))
                dgvOrderUpdate.Columns["OrderDate"].ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dgvOrderUpdate.EndEdit();

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Update(ordersTable);

                MessageBox.Show(
                    "Order updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadOrdersData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving changes:\n\n" + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders frm = new Orders();
            frm.Show();
            this.Close();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOrderUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
