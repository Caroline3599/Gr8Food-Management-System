using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gr8Food.Classes;
using GR8FOODMS_IOOP;
using System_Admin_Assignment;

namespace IOOP_Manager
{
    public partial class ManagerHome : Form
    {
        private int managerID;
        private string managerName;

        public ManagerHome(int id, string name)
        {
            InitializeComponent();
            this.managerID = id;
            this.managerName = name;
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {
            this.managerBindingSource.DataSource = this.gr8Food_Group2DataSet;
            this.managerBindingSource.DataMember = "Manager";

            try
            {
                // 1. Create a specific instance object of the Manager class using the logged-in ID
                Manager currentManager = new Manager(this.managerID);

                // 2. Call the non-static method from that object instance
                DataTable dt = currentManager.ReadManagerData();

                // 3. Bind the data results straight into your DataGridView grid
                dgvMProfile.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying home profile setup: " + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // TODO: This line of code loads data into the 'manager.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.gr8Food_Group2DataSet.Feedback);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginPage login = new LoginPage();
                login.Show();
                this.Close();
            }
        }

        private void btnMProfile_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMProfile.CurrentRow;
            if (row == null) return;

            DateTime? birthday = null;
            if (row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
            {
                DateTime temp;
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out temp))
                    birthday = temp;
            }

            Manager manager = new Manager(
                Convert.ToInt32(row.Cells[0].Value),       // ManagerID
                Convert.ToInt32(row.Cells[1].Value),       // UserID
                row.Cells[2].Value?.ToString(),            // Name
                row.Cells[3].Value?.ToString(),            // Email
                row.Cells[4].Value?.ToString(),            // Phone
                birthday,                                  // Birthday (安全转换)
                row.Cells[6].Value?.ToString(),            // Address
                row.Cells[7].Value?.ToString()             // Password
            );

            UpdateProfile form2 = new UpdateProfile("Manager", managerID);
            form2.ShowDialog();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFeedback.CurrentRow;
            if (row == null) return;

            Feedback feedback = new Feedback(
                Convert.ToInt32(row.Cells[0].Value),                 // FeedbackID
                row.Cells[1].Value?.ToString(),                      // Text
                row.Cells[2].Value == DBNull.Value ? (int?)null : Convert.ToInt32(row.Cells[2].Value), // ManagerID
                row.Cells[3].Value?.ToString(),                      // Response
                row.Cells[4].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row.Cells[4].Value), // ResponseDate
                row.Cells[5].Value == DBNull.Value ? (int?)null : Convert.ToInt32(row.Cells[5].Value) // OrderID
            );


            FeedbackResponse feedbackResponse = new FeedbackResponse(feedback);

            //if (feedbackResponse.ShowDialog() == DialogResult.OK)
            //{
            //    this.manager.Feedback.Clear();
            //    this.feedbackTableAdapter.Fill(this.manager.Feedback);
            //    dgvFeedback.Refresh();
            //}

            feedbackResponse.ShowDialog();

            this.feedbackTableAdapter.Fill(this.gr8Food_Group2DataSet.Feedback);
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            ViewEWallet walletForm = new ViewEWallet();
            walletForm.ShowDialog();
        }

        private void lbl1Title_Click(object sender, EventArgs e)
        {

        }
    }
}
