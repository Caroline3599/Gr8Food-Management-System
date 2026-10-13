using System;
using System.Windows.Forms;
using GR8FOODMS_IOOP;

namespace Ioop_Group_Assignment_Cheif
{
    public partial class Cheif : Form
    {
        private int ID;
        private string name;
        public Cheif(int chefID, string chefName)
            {
                InitializeComponent();
            this.ID = chefID;
            this.name = chefName;
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblChefTitle = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelTop.Controls.Add(this.lblChefTitle);
            this.panelTop.Controls.Add(this.btnUpdateProfile);
            this.panelTop.Controls.Add(this.btnHomePage);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1220, 110);
            this.panelTop.TabIndex = 1;
            // 
            // lblChefTitle
            // 
            this.lblChefTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblChefTitle.ForeColor = System.Drawing.Color.White;
            this.lblChefTitle.Location = new System.Drawing.Point(360, 28);
            this.lblChefTitle.Name = "lblChefTitle";
            this.lblChefTitle.Size = new System.Drawing.Size(500, 50);
            this.lblChefTitle.TabIndex = 0;
            this.lblChefTitle.Text = "CHEF MANAGEMENT";
            this.lblChefTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnUpdateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProfile.FlatAppearance.BorderSize = 0;
            this.btnUpdateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(160)))), ((int)(((byte)(45)))));
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(25, 30);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(160, 48);
            this.btnUpdateProfile.TabIndex = 1;
            this.btnUpdateProfile.Text = "Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(160)))), ((int)(((byte)(45)))));
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHomePage.ForeColor = System.Drawing.Color.White;
            this.btnHomePage.Location = new System.Drawing.Point(980, 30);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(200, 48);
            this.btnHomePage.TabIndex = 2;
            this.btnHomePage.Text = "Back To Homepage";
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.panelCards.Controls.Add(this.btnItemAdd);
            this.panelCards.Controls.Add(this.btnViewMenu);
            this.panelCards.Controls.Add(this.btnOrders);
            this.panelCards.Controls.Add(this.btnDelete);
            this.panelCards.Controls.Add(this.btnEdit);
            this.panelCards.Controls.Add(this.btnLogout);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCards.AutoScroll = true;
            this.panelCards.Location = new System.Drawing.Point(0, 110);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(1220, 610);
            this.panelCards.TabIndex = 0;

            // 
            // btnItemAdd
            // 
            this.btnItemAdd.BackColor = System.Drawing.Color.White;
            this.btnItemAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemAdd.FlatAppearance.BorderSize = 0;
            this.btnItemAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnItemAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnItemAdd.Location = new System.Drawing.Point(120, 90);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(240, 110);
            this.btnItemAdd.TabIndex = 0;
            this.btnItemAdd.Text = "Add Item";
            this.btnItemAdd.UseVisualStyleBackColor = false;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.BackColor = System.Drawing.Color.White;
            this.btnViewMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMenu.FlatAppearance.BorderSize = 0;
            this.btnViewMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnViewMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnViewMenu.Location = new System.Drawing.Point(860, 90);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(240, 110);
            this.btnViewMenu.TabIndex = 1;
            this.btnViewMenu.Text = "View Menu";
            this.btnViewMenu.UseVisualStyleBackColor = false;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(460, 250);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(300, 140);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDelete.Location = new System.Drawing.Point(120, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 110);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEdit.Location = new System.Drawing.Point(860, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(240, 110);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Menu";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(45)))), ((int)(((byte)(35)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(25, 580);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 48);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Cheif
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1220, 760);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cheif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chef Management";
            this.Load += new System.EventHandler(this.Cheif_Load);
            this.panelTop.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        // =========================================================
        // NEW CONTROL DECLARATIONS
        // =========================================================

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCards;

        private System.Windows.Forms.Label lblChefTitle;

        private System.Windows.Forms.Button btnLogout;






        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }    
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }
    
        private void btnHomePage_Click(object sender, EventArgs e)
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

        private void lblCheifTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.ShowDialog();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFoodItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Cheif_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            Add_Items addForm = new Add_Items();
            addForm.ShowDialog();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Delete addForm = new Delete();
            addForm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders addForm = new Orders();
            addForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit addForm = new Edit();
            addForm.ShowDialog();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            IOOP_Manager.UpdateProfile profileForm = new IOOP_Manager.UpdateProfile("Chef", ID);
            this.Hide();
            profileForm.ShowDialog();
            this.Show();
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
    }
}

