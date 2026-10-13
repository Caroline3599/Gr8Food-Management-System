using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Gr8Food.Classes;

namespace Ioop_Group_Assignment_Cheif
{
    public partial class Menu : Form
    {
        private DataTable dt;
        private SqlDataAdapter adapter;

        public Menu()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            int padding = 20;
            int buttonAreaHeight = 60;

            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMenu.Left = padding;
            dgvMenu.Top = padding;
            dgvMenu.Width = this.ClientSize.Width - (padding * 2);
            dgvMenu.Height = this.ClientSize.Height - buttonAreaHeight - (padding * 2);

            dgvMenu.Anchor = AnchorStyles.Top |
                             AnchorStyles.Bottom |
                             AnchorStyles.Left |
                             AnchorStyles.Right;

            btnDashboard.Top = this.ClientSize.Height - buttonAreaHeight;
            btnDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            btnHomePage.Top = this.ClientSize.Height - buttonAreaHeight;
            btnHomePage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            LoadMenuData();
        }

        private void LoadMenuData()
        {
            try
            {
                dt = new DataTable();
                DBHelper db = new DBHelper();
                adapter = new SqlDataAdapter(
                    @"SELECT 
                        MenuID,
                        ItemName,
                        Price,
                        Category,
                        Status,
                        ChefID,
                        StockQuantity
                      FROM Menu",
                    db.GetConnection()
                );

                adapter.Fill(dt);

                dgvMenu.DataSource = null;
                dgvMenu.Columns.Clear();

                dgvMenu.AutoGenerateColumns = true;
                dgvMenu.DataSource = dt;

                dgvMenu.ReadOnly = true;
                dgvMenu.AllowUserToAddRows = false;
                dgvMenu.AllowUserToDeleteRows = false;

                dgvMenu.AutoResizeColumns();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error loading menu:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
