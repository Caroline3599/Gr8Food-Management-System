namespace IOOP_Manager
{
    partial class ViewEWallet
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
            this.lbl4Title = new System.Windows.Forms.Label();
            this.dtpRDate = new System.Windows.Forms.DateTimePicker();
            this.btnM4Back = new System.Windows.Forms.Button();
            this.lblRDate = new System.Windows.Forms.Label();
            this.dgvR = new System.Windows.Forms.DataGridView();
            this.balanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relatedOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbRType = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRType = new System.Windows.Forms.Label();
            this.lblTR = new System.Windows.Forms.Label();
            this.lblDeduction = new System.Windows.Forms.Label();
            this.RM1 = new System.Windows.Forms.Label();
            this.RM2 = new System.Windows.Forms.Label();
            this.labelTR = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl4Title
            // 
            this.lbl4Title.AutoSize = true;
            this.lbl4Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl4Title.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl4Title.Location = new System.Drawing.Point(60, 48);
            this.lbl4Title.Name = "lbl4Title";
            this.lbl4Title.Size = new System.Drawing.Size(143, 33);
            this.lbl4Title.TabIndex = 61;
            this.lbl4Title.Text = "E-Wallet";
            // 
            // dtpRDate
            // 
            this.dtpRDate.CustomFormat = "yyyy-MM";
            this.dtpRDate.Location = new System.Drawing.Point(407, 53);
            this.dtpRDate.Name = "dtpRDate";
            this.dtpRDate.Size = new System.Drawing.Size(212, 28);
            this.dtpRDate.TabIndex = 60;
            this.dtpRDate.ValueChanged += new System.EventHandler(this.dtpRDate_ValueChanged);
            // 
            // btnM4Back
            // 
            this.btnM4Back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnM4Back.Location = new System.Drawing.Point(829, 455);
            this.btnM4Back.Name = "btnM4Back";
            this.btnM4Back.Size = new System.Drawing.Size(212, 127);
            this.btnM4Back.TabIndex = 59;
            this.btnM4Back.Text = "Back";
            this.btnM4Back.UseVisualStyleBackColor = false;
            this.btnM4Back.Click += new System.EventHandler(this.btnM4Back_Click);
            // 
            // lblRDate
            // 
            this.lblRDate.AutoSize = true;
            this.lblRDate.Location = new System.Drawing.Point(255, 58);
            this.lblRDate.Name = "lblRDate";
            this.lblRDate.Size = new System.Drawing.Size(125, 18);
            this.lblRDate.TabIndex = 53;
            this.lblRDate.Text = "Filter by M/Y";
            // 
            // dgvR
            // 
            this.dgvR.AllowUserToAddRows = false;
            this.dgvR.AllowUserToDeleteRows = false;
            this.dgvR.AutoGenerateColumns = false;
            this.dgvR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.balanceIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.relatedOrderIDDataGridViewTextBoxColumn});
            this.dgvR.DataSource = this.balanceBindingSource;
            this.dgvR.Location = new System.Drawing.Point(66, 127);
            this.dgvR.Name = "dgvR";
            this.dgvR.ReadOnly = true;
            this.dgvR.RowHeadersWidth = 62;
            this.dgvR.RowTemplate.Height = 30;
            this.dgvR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvR.Size = new System.Drawing.Size(712, 455);
            this.dgvR.TabIndex = 62;
            // 
            // balanceIDDataGridViewTextBoxColumn
            // 
            this.balanceIDDataGridViewTextBoxColumn.DataPropertyName = "BalanceID";
            this.balanceIDDataGridViewTextBoxColumn.HeaderText = "BalanceID";
            this.balanceIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.balanceIDDataGridViewTextBoxColumn.Name = "balanceIDDataGridViewTextBoxColumn";
            this.balanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // relatedOrderIDDataGridViewTextBoxColumn
            // 
            this.relatedOrderIDDataGridViewTextBoxColumn.DataPropertyName = "RelatedOrderID";
            this.relatedOrderIDDataGridViewTextBoxColumn.HeaderText = "RelatedOrderID";
            this.relatedOrderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.relatedOrderIDDataGridViewTextBoxColumn.Name = "relatedOrderIDDataGridViewTextBoxColumn";
            this.relatedOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.relatedOrderIDDataGridViewTextBoxColumn.Width = 150;

            // 
            // cbRType
            // 
            this.cbRType.DataSource = this.customerBindingSource1;
            this.cbRType.DisplayMember = "Name";
            this.cbRType.FormattingEnabled = true;
            this.cbRType.Location = new System.Drawing.Point(829, 53);
            this.cbRType.Name = "cbRType";
            this.cbRType.Size = new System.Drawing.Size(212, 26);
            this.cbRType.TabIndex = 63;
            this.cbRType.ValueMember = "Name";
            this.cbRType.SelectedIndexChanged += new System.EventHandler(this.cbRType_SelectedIndexChanged);

            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Location = new System.Drawing.Point(639, 56);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(170, 18);
            this.lblRType.TabIndex = 64;
            this.lblRType.Text = "Filter by Customer";
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(826, 139);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(143, 18);
            this.lblTR.TabIndex = 65;
            this.lblTR.Text = "Total Revenue: ";
            // 
            // lblDeduction
            // 
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Location = new System.Drawing.Point(826, 277);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Size = new System.Drawing.Size(107, 18);
            this.lblDeduction.TabIndex = 66;
            this.lblDeduction.Text = "Deduction: ";
            // 
            // RM1
            // 
            this.RM1.AutoSize = true;
            this.RM1.Font = new System.Drawing.Font("YouYuan", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RM1.Location = new System.Drawing.Point(824, 181);
            this.RM1.Name = "RM1";
            this.RM1.Size = new System.Drawing.Size(40, 28);
            this.RM1.TabIndex = 68;
            this.RM1.Text = "RM";
            // 
            // RM2
            // 
            this.RM2.AutoSize = true;
            this.RM2.Font = new System.Drawing.Font("YouYuan", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RM2.Location = new System.Drawing.Point(824, 326);
            this.RM2.Name = "RM2";
            this.RM2.Size = new System.Drawing.Size(40, 28);
            this.RM2.TabIndex = 69;
            this.RM2.Text = "RM";
            // 
            // labelTR
            // 
            this.labelTR.AutoSize = true;
            this.labelTR.Font = new System.Drawing.Font("YouYuan", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTR.Location = new System.Drawing.Point(893, 181);
            this.labelTR.Name = "labelTR";
            this.labelTR.Size = new System.Drawing.Size(40, 28);
            this.labelTR.TabIndex = 71;
            this.labelTR.Text = "--";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("YouYuan", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelD.Location = new System.Drawing.Point(893, 326);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(40, 28);
            this.labelD.TabIndex = 72;
            this.labelD.Text = "--";
            // 
            // ViewEWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 647);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelTR);
            this.Controls.Add(this.RM2);
            this.Controls.Add(this.RM1);
            this.Controls.Add(this.lblDeduction);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.cbRType);
            this.Controls.Add(this.dgvR);
            this.Controls.Add(this.lbl4Title);
            this.Controls.Add(this.dtpRDate);
            this.Controls.Add(this.btnM4Back);
            this.Controls.Add(this.lblRDate);
            this.Name = "ViewEWallet";
            this.Text = "ViewEWallet";
            this.Load += new System.EventHandler(this.ViewEWallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl4Title;
        private System.Windows.Forms.DateTimePicker dtpRDate;
        private System.Windows.Forms.Button btnM4Back;
        private System.Windows.Forms.Label lblRDate;
        private System.Windows.Forms.DataGridView dgvR;
        private System.Windows.Forms.BindingSource balanceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relatedOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbRType;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.Label lblDeduction;
        private System.Windows.Forms.Label RM1;
        private System.Windows.Forms.Label RM2;
        private System.Windows.Forms.Label labelTR;
        private System.Windows.Forms.Label labelD;
    }
}