using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Gr8Food.Classes;

namespace Ioop_Group_Assignment_Cheif
{
    public partial class Add_Items : Form
    {
        private DataTable dt;
        private SqlDataAdapter adapter;

        public Add_Items()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void Add_Items_Load(object sender, EventArgs e)
        {
            int padding = 20;
            int buttonAreaHeight = 60;

            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.Left = padding;
            dgvStock.Top = padding;
            dgvStock.Width = this.ClientSize.Width - (padding * 2);
            dgvStock.Height = this.ClientSize.Height - buttonAreaHeight - (padding * 2);
            dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            int buttonY = this.ClientSize.Height - buttonAreaHeight + 15;

            btnDashboard.Left = padding;
            btnDashboard.Top = buttonY;
            btnDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            btnSave.Left = (this.ClientSize.Width - btnSave.Width) / 2;
            btnSave.Top = buttonY;
            btnSave.Anchor = AnchorStyles.Bottom;

            btnHomePage.Left = this.ClientSize.Width - btnHomePage.Width - padding;
            btnHomePage.Top = buttonY;
            btnHomePage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            LoadData();
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

                dgvStock.DataSource = null;
                dgvStock.DataMember = null;
                dgvStock.AutoGenerateColumns = true;
                dgvStock.ReadOnly = false;
                dgvStock.AllowUserToAddRows = true;
                dgvStock.AllowUserToDeleteRows = false;
                dgvStock.DataSource = dt;

                LockExistingRows();
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

        private void LockExistingRows()
        {
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.ReadOnly = true;
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                }
            }
        }

        private void dgvStock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            LockExistingRows();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvStock.EndEdit();

            if (!ValidateNewRows(out string validationError))
            {
                MessageBox.Show("Cannot save:\n\n" + validationError, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasNewRows = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    hasNewRows = true;
                    break;
                }
            }

            if (!hasNewRows)
            {
                MessageBox.Show("No new rows to save.\n\nUse the blank row at the bottom to add a new item.",
                    "Nothing to Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int rowsAffected = adapter.Update(dt);
                dt.AcceptChanges();
                MessageBox.Show(rowsAffected + " new item(s) saved successfully!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            catch (SqlException ex)
            {
                dt.RejectChanges();
                MessageBox.Show("Database error while saving:\n\n" + ex.Message +
                    "\n\nAll changes have been rolled back.", "Save Error",
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
                MessageBox.Show("Unexpected error while saving:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateNewRows(out string error)
        {
            error = string.Empty;
            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState != DataRowState.Added) continue;

                if (string.IsNullOrWhiteSpace(row["ItemName"]?.ToString()))
                {
                    error = "ItemName cannot be empty.";
                    return false;
                }

                if (!decimal.TryParse(row["Price"]?.ToString(), out decimal price) || price < 0)
                {
                    error = $"Price is invalid for item '{row["ItemName"]}'. Must be a positive number.";
                    return false;
                }

                if (!int.TryParse(row["ChefID"]?.ToString(), out _))
                {
                    error = $"ChefID must be a whole number for item '{row["ItemName"]}'.";
                    return false;
                }
            }
            return true;
        }

        private void Save_Resize(object sender, EventArgs e) { }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
