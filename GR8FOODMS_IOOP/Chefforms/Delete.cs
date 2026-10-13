using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Gr8Food.Classes;

namespace Ioop_Group_Assignment_Cheif
{
    public partial class Delete : Form
    {
        private DataTable dt;
        private SqlDataAdapter adapter;

        public Delete()
        {
            InitializeComponent();
            this.Resize += Delete_Resize;
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            LayoutControls();
            LoadData();
        }

        private void Delete_Resize(object sender, EventArgs e)
        {
            LayoutControls();
        }

        private void LayoutControls()
        {
            const int padding = 12;
            const int buttonHeight = 69;
            const int buttonWidth = 187;
            const int buttonArea = buttonHeight + (padding * 2);

            if (dgvDelete == null || btnDashBoard == null ||
                btnSave == null || btnHomePage == null) return;

            dgvDelete.Left = padding;
            dgvDelete.Top = padding;
            dgvDelete.Width = ClientSize.Width - padding * 2;
            dgvDelete.Height = ClientSize.Height - buttonArea - padding;
            dgvDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                               AnchorStyles.Left | AnchorStyles.Right;

            int buttonY = ClientSize.Height - buttonHeight - padding;

            btnDashBoard.Width = buttonWidth;
            btnDashBoard.Height = buttonHeight;
            btnDashBoard.Left = padding;
            btnDashBoard.Top = buttonY;
            btnDashBoard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            btnSave.Width = buttonWidth;
            btnSave.Height = buttonHeight;
            btnSave.Left = (ClientSize.Width - buttonWidth) / 2;
            btnSave.Top = buttonY;
            btnSave.Anchor = AnchorStyles.Bottom;

            btnHomePage.Width = 213;
            btnHomePage.Height = buttonHeight;
            btnHomePage.Left = ClientSize.Width - 213 - padding;
            btnHomePage.Top = buttonY;
            btnHomePage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void LoadData()
        {
            try
            {
                DBHelper db = new DBHelper();
                dt = new DataTable();
                adapter = new SqlDataAdapter(
                    "SELECT MenuID, ItemName, Price, Category, Status, ChefID, StockQuantity FROM Menu",
                    db.GetConnection()
                );

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dt);

                dgvDelete.DataSource = null;
                dgvDelete.DataMember = null;
                dgvDelete.AutoGenerateColumns = true;
                dgvDelete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDelete.ReadOnly = false;
                dgvDelete.AllowUserToAddRows = false;
                dgvDelete.AllowUserToDeleteRows = true;
                dgvDelete.MultiSelect = true;
                dgvDelete.DataSource = dt;

                foreach (DataGridViewColumn col in dgvDelete.Columns)
                    col.ReadOnly = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error loading data:\n\n" + ex.Message, "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasDeletions = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    hasDeletions = true;
                    break;
                }
            }

            if (!hasDeletions)
            {
                MessageBox.Show("No rows have been deleted.\n\nSelect a row and press the Delete key to remove it.",
                    "Nothing to Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int deleteCount = 0;
            foreach (DataRow row in dt.Rows)
                if (row.RowState == DataRowState.Deleted) deleteCount++;

            var confirm = MessageBox.Show(
                "You are about to permanently delete " + deleteCount + " row(s).\n\nThis cannot be undone. Continue?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
            {
                dt.RejectChanges();
                return;
            }

            try
            {
                int rowsAffected = adapter.Update(dt);
                dt.AcceptChanges();
                MessageBox.Show(rowsAffected + " row(s) deleted successfully!", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            catch (SqlException ex)
            {
                dt.RejectChanges();
                MessageBox.Show("Database error while deleting:\n\n" + ex.Message +
                    "\n\nNo rows were deleted.", "Delete Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
            }
            catch (DBConcurrencyException)
            {
                dt.RejectChanges();
                MessageBox.Show("Another user modified this record at the same time.\n\nReloading latest data.",
                    "Concurrency Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
            }
            catch (Exception ex)
            {
                dt.RejectChanges();
                MessageBox.Show("Unexpected error while deleting:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dgvDelete.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dgvDelete.Rows.Remove(row);
                }
                e.Handled = true;
            }
        }
    }
}
