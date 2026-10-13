using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace System_Admin_Assignment
{
    public partial class ViewTablesForm : Form
    {
        private int currentUserId;
        private string adminName;

        public ViewTablesForm(int userId, string name)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.adminName = name;
        }

        private void ViewTablesForm_Load(object sender, EventArgs e)
        {
            // Populate the dropdown with your target user tables
            cboSelectTable.Items.Clear();
            cboSelectTable.Items.Add("Admin");
            cboSelectTable.Items.Add("Manager");
            cboSelectTable.Items.Add("Chef");
            cboSelectTable.Items.Add("Customer");

            // Default selection to Admin tables
            cboSelectTable.SelectedIndex = 0;

            // Load the initial table data
            LoadSelectedTableData();
        }

        // DISPLAY DATA FROM SELECTED TABLES
        private void LoadSelectedTableData()
        {
            if (cboSelectTable.SelectedItem == null) return;

            string selectedTable = cboSelectTable.SelectedItem.ToString();
            DataTable dt = null;

            try
            {
                // Call the specific class methods to grab the data tables
                if (selectedTable == "Admin")
                {
                    Admin adminReadAll = new Admin(0);
                    dt = adminReadAll.ReadAllAdmins();
                }
                else if (selectedTable == "Manager")
                {
                    Manager managerReadAll = new Manager(0);
                    dt = managerReadAll.ReadAllManagers();
                }
                else if (selectedTable == "Chef")
                {
                    Chef chefReadAll = new Chef(0);
                    dt = chefReadAll.ReadAllChefs();
                }
                else if (selectedTable == "Customer")
                {
                    Customer customerReadAll = new Customer(0);
                    dt = customerReadAll.ReadAllCustomers();
                }

                // Bind the data results straight into your DataGridView grid
                dgvUserTables.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving records from the {selectedTable} layer:\n{ex.Message}",
                                "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //change datagridview data according to the role
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LoadSelectedTableData();
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