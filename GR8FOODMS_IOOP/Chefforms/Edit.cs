using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Gr8Food.Classes;

namespace Ioop_Group_Assignment_Cheif
{
    public partial class Edit : Form
    {
        private DataTable dt;
        private SqlDataAdapter adapter;

        public Edit()
        {
            InitializeComponent();
            LoadMenuData();
            this.Load += Edit_Load;
        }

        private void LoadMenuData()
        {
            DBHelper db = new DBHelper();
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT MenuID, ItemName, Price, Category, Status, ChefID, StockQuantity FROM Menu";
                    adapter = new SqlDataAdapter(query, conn);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    dgvEdit.DataSource = null;
                    dgvEdit.Columns.Clear();
                    dgvEdit.DataSource = dt;

                    dgvEdit.AutoGenerateColumns = true;
                    dgvEdit.AutoResizeColumns();

                    dgvEdit.ReadOnly = false;
                    dgvEdit.AllowUserToAddRows = false;
                    dgvEdit.AllowUserToDeleteRows = false;

                    dgvEdit.Columns["MenuID"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            int padding = 20;
            int buttonAreaHeight = 60;

            dgvEdit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEdit.Left = padding;
            dgvEdit.Top = padding;
            dgvEdit.Width = this.ClientSize.Width - (padding * 2);
            dgvEdit.Height = this.ClientSize.Height - buttonAreaHeight - (padding * 2);

            dgvEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            btnDashBoard.Top = this.ClientSize.Height - buttonAreaHeight;
            btnDashBoard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            btnSave.Top = this.ClientSize.Height - buttonAreaHeight;
            btnSave.Left = (this.ClientSize.Width - btnSave.Width) / 2;
            btnSave.Anchor = AnchorStyles.Bottom;

            btnHomePage.Top = this.ClientSize.Height - buttonAreaHeight;
            btnHomePage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEdit.EndEdit();
                
                DataTable changes = dt.GetChanges();
                if (changes == null || changes.Rows.Count == 0)
                    return;
                DBHelper db = new DBHelper();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    adapter.SelectCommand.Connection = conn;
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dt);
                }

                dt.AcceptChanges();

                MessageBox.Show("Changes saved successfully.", "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvEdit_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void Edit_Load_1(object sender, EventArgs e) { }
    }
}
