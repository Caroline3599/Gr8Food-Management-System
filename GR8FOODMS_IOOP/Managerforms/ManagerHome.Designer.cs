using System.Windows.Forms;

namespace IOOP_Manager
{
    partial class ManagerHome
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
            this.components = new System.ComponentModel.Container();
            this.btnWallet = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMProfile = new System.Windows.Forms.Button();
            this.lbl1Title = new System.Windows.Forms.Label();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gr8Food_Group2DataSet = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.feedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMProfile = new System.Windows.Forms.DataGridView();
            this.ManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWalletReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackTableAdapter = new GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.FeedbackTableAdapter();
            this.managerTableAdapter = new GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.ManagerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWalletReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWallet
            // 
            this.btnWallet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnWallet.Location = new System.Drawing.Point(514, 385);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(441, 122);
            this.btnWallet.TabIndex = 24;
            this.btnWallet.Text = "View E-Wallet";
            this.btnWallet.UseVisualStyleBackColor = false;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFeedback.Location = new System.Drawing.Point(514, 249);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(441, 117);
            this.btnFeedback.TabIndex = 23;
            this.btnFeedback.Text = "Response to Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLogout.Location = new System.Drawing.Point(853, 535);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 47);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMProfile
            // 
            this.btnMProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMProfile.Location = new System.Drawing.Point(633, 33);
            this.btnMProfile.Name = "btnMProfile";
            this.btnMProfile.Size = new System.Drawing.Size(322, 44);
            this.btnMProfile.TabIndex = 26;
            this.btnMProfile.Text = "Update Profile";
            this.btnMProfile.UseVisualStyleBackColor = false;
            this.btnMProfile.Click += new System.EventHandler(this.btnMProfile_Click);
            // 
            // lbl1Title
            // 
            this.lbl1Title.AutoSize = true;
            this.lbl1Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1Title.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Title.Location = new System.Drawing.Point(50, 33);
            this.lbl1Title.Name = "lbl1Title";
            this.lbl1Title.Size = new System.Drawing.Size(207, 33);
            this.lbl1Title.TabIndex = 28;
            this.lbl1Title.Text = "Manager Page";
            this.lbl1Title.Click += new System.EventHandler(this.lbl1Title_Click);
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.AutoGenerateColumns = false;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvFeedback.DataSource = this.feedbackBindingSource1;
            this.dgvFeedback.Location = new System.Drawing.Point(46, 249);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 62;
            this.dgvFeedback.RowTemplate.Height = 30;
            this.dgvFeedback.Size = new System.Drawing.Size(437, 333);
            this.dgvFeedback.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FeedbackID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FeedbackID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn2.HeaderText = "Text";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ManagerID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ManagerID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Response";
            this.dataGridViewTextBoxColumn4.HeaderText = "Response";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ResponseDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "ResponseDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn6.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // feedbackBindingSource1
            // 
            this.feedbackBindingSource1.DataMember = "Feedback";
            this.feedbackBindingSource1.DataSource = this.gr8Food_Group2DataSet;
            // 
            // gr8Food_Group2DataSet
            // 
            this.gr8Food_Group2DataSet.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvMProfile
            // 
            this.dgvMProfile.AutoGenerateColumns = false;
            this.dgvMProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManagerID,
            this.UserID,
            this.nameDataGridViewTextBoxColumn,
            this.Email,
            this.Phone,
            this.Birthday,
            this.Address,
            this.Password});
            this.dgvMProfile.DataSource = this.managerBindingSource3;
            this.dgvMProfile.Location = new System.Drawing.Point(46, 103);
            this.dgvMProfile.Name = "dgvMProfile";
            this.dgvMProfile.RowHeadersWidth = 62;
            this.dgvMProfile.RowTemplate.Height = 30;
            this.dgvMProfile.Size = new System.Drawing.Size(909, 109);
            this.dgvMProfile.TabIndex = 30;
            // 
            // ManagerID
            // 
            this.ManagerID.DataPropertyName = "ManagerID";
            this.ManagerID.HeaderText = "ManagerID";
            this.ManagerID.MinimumWidth = 8;
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.ReadOnly = true;
            this.ManagerID.Width = 150;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 150;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.MinimumWidth = 8;
            this.Birthday.Name = "Birthday";
            this.Birthday.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // managerBindingSource3
            // 
            this.managerBindingSource3.DataMember = "Manager";
            this.managerBindingSource3.DataSource = this.gr8Food_Group2DataSet;
            // 
            // feedbackTableAdapter
            // 
            this.feedbackTableAdapter.ClearBeforeFill = true;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 618);
            this.Controls.Add(this.dgvMProfile);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.lbl1Title);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMProfile);
            this.Controls.Add(this.btnWallet);
            this.Controls.Add(this.btnFeedback);
            this.Name = "ManagerHome";
            this.Text = "ManagerHome";
            this.Load += new System.EventHandler(this.ManagerHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWalletReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMProfile;
        private System.Windows.Forms.Label lbl1Title;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.BindingSource feedbackBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvMProfile;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private System.Windows.Forms.BindingSource eWalletReportsBindingSource;
        private BindingSource balanceBindingSource;
        private BindingSource balanceBindingSource1;
        private BindingSource managerBindingSource2;
        private BindingSource managerBindingSource1;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSet gr8Food_Group2DataSet;
        private BindingSource feedbackBindingSource1;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.FeedbackTableAdapter feedbackTableAdapter;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.ManagerTableAdapter managerTableAdapter;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource managerBindingSource3;
        private DataGridViewTextBoxColumn ManagerID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Password;
    }
}