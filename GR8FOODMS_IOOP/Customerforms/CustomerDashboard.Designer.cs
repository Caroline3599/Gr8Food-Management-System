namespace GR8FOODMS_IOOP
{
    partial class CustomerDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWalletBalance = new System.Windows.Forms.Label();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBrowseMenu = new System.Windows.Forms.Button();
            this.btnTopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(107, 72);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(129, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblWalletBalance
            // 
            this.lblWalletBalance.AutoSize = true;
            this.lblWalletBalance.Location = new System.Drawing.Point(108, 126);
            this.lblWalletBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWalletBalance.Name = "lblWalletBalance";
            this.lblWalletBalance.Size = new System.Drawing.Size(106, 15);
            this.lblWalletBalance.TabIndex = 1;
            this.lblWalletBalance.Text = "E-Wallet: RM 0.00";
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.Location = new System.Drawing.Point(359, 203);
            this.btnMyOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(122, 32);
            this.btnMyOrders.TabIndex = 2;
            this.btnMyOrders.Text = "My Orders";
            this.btnMyOrders.UseVisualStyleBackColor = true;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(110, 291);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(122, 32);
            this.btnFeedback.TabIndex = 3;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Location = new System.Drawing.Point(359, 291);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(122, 32);
            this.btnMyProfile.TabIndex = 4;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(359, 370);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 32);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBrowseMenu
            // 
            this.btnBrowseMenu.Location = new System.Drawing.Point(110, 203);
            this.btnBrowseMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseMenu.Name = "btnBrowseMenu";
            this.btnBrowseMenu.Size = new System.Drawing.Size(122, 32);
            this.btnBrowseMenu.TabIndex = 6;
            this.btnBrowseMenu.Text = "Browse Menu";
            this.btnBrowseMenu.UseVisualStyleBackColor = true;
            this.btnBrowseMenu.Click += new System.EventHandler(this.btnBrowseMenu_Click);
            // 
            // btnTopup
            // 
            this.btnTopup.Location = new System.Drawing.Point(110, 370);
            this.btnTopup.Margin = new System.Windows.Forms.Padding(2);
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.Size = new System.Drawing.Size(122, 32);
            this.btnTopup.TabIndex = 7;
            this.btnTopup.Text = "Top Up";
            this.btnTopup.UseVisualStyleBackColor = true;
            this.btnTopup.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 413);
            this.Controls.Add(this.btnTopup);
            this.Controls.Add(this.btnBrowseMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyProfile);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnMyOrders);
            this.Controls.Add(this.lblWalletBalance);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWalletBalance;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBrowseMenu;
        private System.Windows.Forms.Button btnTopup;
    }
}