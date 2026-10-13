using System;
using System.Data;
using System.Windows.Forms;

namespace System_Admin_Assignment
{
    public partial class ViewSalesReportForm : Form
    {
        // Connectionstring to database
        private int currentUserId;
        private string adminName;

        public ViewSalesReportForm(int userId, string name)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.adminName = name;
        }

        private void ViewSalesReportForm_Load(object sender, EventArgs e)
        {
            SetupFilterDefaults();
            LoadChefsIntoComboBox();
            LoadSalesReport();
        }

        // INITIALIZE DEFAULT CONTROL VALUES
        private void SetupFilterDefaults()
        {
            txtMonth.Text = "All";
            txtYear.Text = "All";

            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new string[] { "All", "Breakfast", "Lunch", "Dinner", "Snacks", "Drinks" });
            cboCategory.SelectedIndex = 0;
        }

        // PULL CHEFS FROM DB TO COMBOBOX
        private void LoadChefsIntoComboBox()
        {
            cboChef.Items.Clear();
            cboChef.Items.Add("All");

            try
            {
                // We utilize the Menu class method developed earlier to safely pull combined chef lists
                Menu menuEngine = new Menu();
                DataTable menuData = menuEngine.GetMenuItemsWithChefDetails();

                System.Collections.Generic.HashSet<string> uniqueChefs = new System.Collections.Generic.HashSet<string>();

                foreach (DataRow row in menuData.Rows)
                {
                    if (row["CreatedByChef"] != DBNull.Value)
                    {
                        string name = row["CreatedByChef"].ToString();
                        if (uniqueChefs.Add(name))
                        {
                            cboChef.Items.Add(name);
                        }
                    }
                }
                cboChef.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error pulling system chef list: {ex.Message}", "Filter Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PARSE MONTH NAME TO INTEGERS
        private int ParseMonthNameToNumber(string monthInput)
        {
            string cleanInput = monthInput.Trim().ToLower();

            switch (cleanInput)
            {
                case "january": return 1;
                case "february": return 2;
                case "march": return 3;
                case "april": return 4;
                case "may": return 5;
                case "june": return 6;
                case "july": return 7;
                case "august": return 8;
                case "september": return 9;
                case "october": return 10;
                case "november": return 11;
                case "december": return 12;
                default: return -1; // Invalid month name indicator
            }
        }

        // LOAD & FILTER THE DATA
        private void LoadSalesReport()
        {
            object monthParam = null;
            object yearParam = null;

            // Process Month Box
            string monthText = txtMonth.Text.Trim();
            if (!string.IsNullOrEmpty(monthText) && !monthText.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                int monthNum = ParseMonthNameToNumber(monthText);
                if (monthNum == -1)
                {
                    MessageBox.Show("Please type a valid month name string configuration.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                monthParam = monthNum;
            }
            else
            {
                txtMonth.Text = "All";
            }

            // Process Year Box
            string yearText = txtYear.Text.Trim();
            if (!string.IsNullOrEmpty(yearText) && !yearText.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                if (!int.TryParse(yearText, out int yearNum) || yearNum < 2000 || yearNum > 2100)
                {
                    MessageBox.Show("Please type an accurate 4-digit numeric target calendar year value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                yearParam = yearNum;
            }
            else
            {
                txtYear.Text = "All";
            }

            string targetCategory = cboCategory.SelectedItem?.ToString() ?? "All";
            string targetChef = cboChef.SelectedItem?.ToString() ?? "All";

            try
            {
              
                Order reportingInstance = new Order();

                DataTable reportData = reportingInstance.GetFilteredSalesReport(monthParam, yearParam, targetCategory, targetChef);

                dgvSalesReport.DataSource = reportData;

                decimal revenueSum = 0;
                foreach (DataRow row in reportData.Rows)
                {
                    if (row["TotalPrice"] != DBNull.Value)
                    {
                        revenueSum += Convert.ToDecimal(row["TotalPrice"]);
                    }
                }

                lblTotalSales.Text = $"Total Revenue: RM {revenueSum:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to aggregate background report analytics:\n{ex.Message}", "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetupFilterDefaults();
            if (cboChef.Items.Count > 0) cboChef.SelectedIndex = 0;
            LoadSalesReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboard dashboard = new AdminDashboard(currentUserId, adminName);
            dashboard.Show();
            this.Close();
        }
    }
}