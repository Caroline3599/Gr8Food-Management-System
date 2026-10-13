using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Gr8Food.Classes;

namespace Ioop_Group_Assignment_Cheif
{
    public partial class Orders : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable ordersTable;

        public Orders()
        {
            InitializeComponent();

            ordersTable = new DataTable();

            this.Load += Orders_Load;
            this.Resize += Orders_Resize;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            LayoutControls();
            LoadOrdersData();
        }

        private void Orders_Resize(object sender, EventArgs e)
        {
            LayoutControls();
        }

        private void LoadOrdersData()
        {
            try
            {
                DBHelper db = new DBHelper();
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = "SELECT * FROM [Order]";

                    ordersTable.Clear();

                    dataAdapter = new SqlDataAdapter(query, conn);
                    dataAdapter.Fill(ordersTable);

                    if (ordersTable.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "The Order table is empty in the database.",
                            "No Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    BindGrid(ordersTable);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error loading orders:\n\n" + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error:\n\n" + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BindGrid(DataTable dt)
        {
            dgvOrders.DataSource = null;
            dgvOrders.AutoGenerateColumns = true;
            dgvOrders.DataSource = dt;

            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeRows = false;

            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;
            dgvOrders.RowHeadersVisible = true;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LayoutControls()
        {
            const int padding = 20;
            const int buttonHeight = 35;
            const int buttonWidth = 120;
            const int buttonAreaHeight = buttonHeight + (padding * 2);

            if (dgvOrders == null || btnDashboard == null ||
                btnUpdate == null || btnHomePage == null)
                return;

            dgvOrders.Left = padding;
            dgvOrders.Top = padding;
            dgvOrders.Width = ClientSize.Width - (padding * 2);
            dgvOrders.Height = ClientSize.Height - buttonAreaHeight - padding;

            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            int buttonY = ClientSize.Height - buttonHeight - padding;

            btnDashboard.Width = buttonWidth;
            btnDashboard.Height = buttonHeight;
            btnDashboard.Left = padding;
            btnDashboard.Top = buttonY;

            btnUpdate.Width = buttonWidth;
            btnUpdate.Height = buttonHeight;
            btnUpdate.Left = (ClientSize.Width - buttonWidth) / 2;
            btnUpdate.Top = buttonY;

            btnHomePage.Width = buttonWidth;
            btnHomePage.Height = buttonHeight;
            btnHomePage.Left = ClientSize.Width - buttonWidth - padding;
            btnHomePage.Top = buttonY;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OrderUpdate updateForm = new OrderUpdate();
            updateForm.ShowDialog();
            LoadOrdersData();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
