namespace System_Admin_Assignment
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnAddUserForm = new System.Windows.Forms.Button();
            this.btnUpdateUserForm = new System.Windows.Forms.Button();
            this.btnRemoveUserForm = new System.Windows.Forms.Button();
            this.btnViewSalesReportForm = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewTables = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(33, 26);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(176, 39);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome!";
            // 
            // btnAddUserForm
            // 
            this.btnAddUserForm.Location = new System.Drawing.Point(120, 113);
            this.btnAddUserForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUserForm.Name = "btnAddUserForm";
            this.btnAddUserForm.Size = new System.Drawing.Size(75, 41);
            this.btnAddUserForm.TabIndex = 1;
            this.btnAddUserForm.Text = "Add User";
            this.btnAddUserForm.UseVisualStyleBackColor = true;
            this.btnAddUserForm.Click += new System.EventHandler(this.btnAddUserForm_Click);
            // 
            // btnUpdateUserForm
            // 
            this.btnUpdateUserForm.Location = new System.Drawing.Point(372, 113);
            this.btnUpdateUserForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateUserForm.Name = "btnUpdateUserForm";
            this.btnUpdateUserForm.Size = new System.Drawing.Size(75, 41);
            this.btnUpdateUserForm.TabIndex = 2;
            this.btnUpdateUserForm.Text = "Update User";
            this.btnUpdateUserForm.UseVisualStyleBackColor = true;
            this.btnUpdateUserForm.Click += new System.EventHandler(this.btnUpdateUserForm_Click);
            // 
            // btnRemoveUserForm
            // 
            this.btnRemoveUserForm.Location = new System.Drawing.Point(120, 191);
            this.btnRemoveUserForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveUserForm.Name = "btnRemoveUserForm";
            this.btnRemoveUserForm.Size = new System.Drawing.Size(75, 41);
            this.btnRemoveUserForm.TabIndex = 3;
            this.btnRemoveUserForm.Text = "Remove User";
            this.btnRemoveUserForm.UseVisualStyleBackColor = true;
            this.btnRemoveUserForm.Click += new System.EventHandler(this.btnRemoveUserForm_Click);
            // 
            // btnViewSalesReportForm
            // 
            this.btnViewSalesReportForm.Location = new System.Drawing.Point(372, 191);
            this.btnViewSalesReportForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewSalesReportForm.Name = "btnViewSalesReportForm";
            this.btnViewSalesReportForm.Size = new System.Drawing.Size(75, 41);
            this.btnViewSalesReportForm.TabIndex = 4;
            this.btnViewSalesReportForm.Text = "View Sales Report";
            this.btnViewSalesReportForm.UseVisualStyleBackColor = true;
            this.btnViewSalesReportForm.Click += new System.EventHandler(this.btnViewSalesReportForm_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(245, 314);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 41);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewTables
            // 
            this.btnViewTables.Location = new System.Drawing.Point(120, 266);
            this.btnViewTables.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewTables.Name = "btnViewTables";
            this.btnViewTables.Size = new System.Drawing.Size(75, 41);
            this.btnViewTables.TabIndex = 6;
            this.btnViewTables.Text = "View User Tables";
            this.btnViewTables.UseVisualStyleBackColor = true;
            this.btnViewTables.Click += new System.EventHandler(this.btnViewTables_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(372, 266);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 41);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnViewTables);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewSalesReportForm);
            this.Controls.Add(this.btnRemoveUserForm);
            this.Controls.Add(this.btnUpdateUserForm);
            this.Controls.Add(this.btnAddUserForm);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnAddUserForm;
        private System.Windows.Forms.Button btnUpdateUserForm;
        private System.Windows.Forms.Button btnRemoveUserForm;
        private System.Windows.Forms.Button btnViewSalesReportForm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewTables;
        private System.Windows.Forms.Button btnProfile;
    }
}

