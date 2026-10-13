using System;
using System.Collections.Generic;
using System.Data;

using System.Windows.Forms;

namespace IOOP_Manager
{
    public partial class ViewEWallet : Form
    {
        private ManagerWalletReportRepository walletRepo = new ManagerWalletReportRepository();
        private bool isLoadingComboBox = false;
        public ViewEWallet()
        {
            InitializeComponent();
        }


        private void ViewEWallet_Load(object sender, EventArgs e)
        {
            SetupDateTimePicker();
            SetupDataGridView();
            LoadCustomerComboBox();
            LoadWalletReport();
        }

        private void SetupDateTimePicker()
        {
            dtpRDate.Format = DateTimePickerFormat.Custom;
            dtpRDate.CustomFormat = "yyyy-MM";
            dtpRDate.ShowUpDown = true;
        }

        private void SetupDataGridView()
        {
            dgvR.ReadOnly = true;
            dgvR.AllowUserToAddRows = false;
            dgvR.AllowUserToDeleteRows = false;
            dgvR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCustomerComboBox()
        {

            try
            {
                isLoadingComboBox = true;

                DataTable customerTable = walletRepo.GetCustomers();

                DataRow allRow = customerTable.NewRow();
                allRow["CustomerID"] = 0;
                allRow["Name"] = "All Customers";
                customerTable.Rows.InsertAt(allRow, 0);

                cbRType.DataSource = null;
                cbRType.DisplayMember = "Name";
                cbRType.ValueMember = "CustomerID";
                cbRType.DataSource = customerTable;
                cbRType.SelectedIndex = 0;

                isLoadingComboBox = false;
            }
            catch (Exception ex)
            {
                isLoadingComboBox = false;
                MessageBox.Show("Failed to load customers: " + ex.Message);
            }

        }

        private void LoadWalletReport()
        {
            try
            {
                if (cbRType.SelectedValue == null)
                {
                    return;
                }

                if (cbRType.SelectedValue is DataRowView)
                {
                    return;
                }


                int selectedCustomerId = Convert.ToInt32(cbRType.SelectedValue);
                int selectedYear = dtpRDate.Value.Year;
                int selectedMonth = dtpRDate.Value.Month;

                DataTable reportTable = walletRepo.GetWalletReport(
                    selectedCustomerId,
                    selectedYear,
                    selectedMonth
                );

                dgvR.DataSource = reportTable;

                RenameGridHeaders();

                decimal totalTopUp = 0;
                decimal totalDeduction = 0;

                var cancelOrderIds = new HashSet<int>();
                foreach (DataRow row in reportTable.Rows)
                {
                    string type = row["Type"].ToString().Trim().ToLower();
                    if (type == "cancel" && row["RelatedOrderID"] != DBNull.Value)
                    {
                        cancelOrderIds.Add(Convert.ToInt32(row["RelatedOrderID"]));
                    }
                }

                foreach (DataRow row in reportTable.Rows)
                {
                    string type = row["Type"].ToString().ToLower();
                    decimal amount = Convert.ToDecimal(row["Amount"]);
                    int relatedOrderId = row["RelatedOrderID"] == DBNull.Value ? 0 : Convert.ToInt32(row["RelatedOrderID"]);

                    if (cancelOrderIds.Contains(row.Field<int>("BalanceID")) || cancelOrderIds.Contains(relatedOrderId))
                    {
                        continue;
                    }

                    if (type == "top up")
                    {
                        totalTopUp += amount;
                    }
                    else if (type == "dedection")
                    {
                        totalDeduction += amount;
                    }
                }


                labelTR.Text = totalTopUp.ToString("F2");
                labelD.Text = totalDeduction.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load wallet report: " + ex.Message);
            }
        }

        private void RenameGridHeaders()
        {
            if (dgvR.Columns.Contains("BalanceID"))
                dgvR.Columns["BalanceID"].HeaderText = "Balance ID";

            if (dgvR.Columns.Contains("CustomerID"))
                dgvR.Columns["CustomerID"].HeaderText = "Customer ID";

            if (dgvR.Columns.Contains("CustomerName"))
                dgvR.Columns["CustomerName"].HeaderText = "Customer Name";

            if (dgvR.Columns.Contains("Type"))
                dgvR.Columns["Type"].HeaderText = "Transaction Type";

            if (dgvR.Columns.Contains("Amount"))
                dgvR.Columns["Amount"].HeaderText = "Amount";

            if (dgvR.Columns.Contains("Date"))
                dgvR.Columns["Date"].HeaderText = "Date";

            if (dgvR.Columns.Contains("RelatedOrderID"))
                dgvR.Columns["RelatedOrderID"].HeaderText = "Related Order ID";
        }

        private void cbRType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isLoadingComboBox)
            {
                return;
            }

            LoadWalletReport();
        }

        private void dtpRDate_ValueChanged(object sender, EventArgs e)
        {
            LoadWalletReport();
        }



        private void btnM4Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnM4Up_Click(object sender, EventArgs e)
        {
            LoadWalletReport();
        }
    }
}
