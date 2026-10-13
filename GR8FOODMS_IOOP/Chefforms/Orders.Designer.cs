namespace Ioop_Group_Assignment_Cheif
{
    partial class Orders
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderRemarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr8FoodGroup2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr8FoodGroup2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gr8Food_Group2DataSet = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.gr8FoodGroup2AssignmentDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr8Food_Group2_AssignmentDataSet1 = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.gr8Food_Group2_AssignmentDataSet = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.OrderTableAdapter();
            this.orderTableAdapter = new GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.OrderTableAdapter();
            this.gr8FoodGroup2DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.orderRemarksDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.orderBindingSource;
            this.dgvOrders.Location = new System.Drawing.Point(6, 6);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(469, 306);
            this.dgvOrders.TabIndex = 4;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            // 
            // orderRemarksDataGridViewTextBoxColumn
            // 
            this.orderRemarksDataGridViewTextBoxColumn.DataPropertyName = "OrderRemarks";
            this.orderRemarksDataGridViewTextBoxColumn.HeaderText = "OrderRemarks";
            this.orderRemarksDataGridViewTextBoxColumn.Name = "orderRemarksDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.gr8FoodGroup2DataSetBindingSource;
            // 
            // gr8Food_Group2DataSet
            // 
            this.gr8Food_Group2DataSet.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gr8Food_Group2_AssignmentDataSet1
            // 
            this.gr8Food_Group2_AssignmentDataSet1.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2_AssignmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gr8Food_Group2_AssignmentDataSet
            // 
            this.gr8Food_Group2_AssignmentDataSet.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2_AssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(6, 330);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(86, 32);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DashBoard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(200, 330);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(393, 330);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(86, 32);
            this.btnHomePage.TabIndex = 3;
            this.btnHomePage.Text = "HomePage";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.gr8FoodGroup2AssignmentDataSet1BindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // gr8FoodGroup2DataSetBindingSource2
            // 
            this.gr8FoodGroup2DataSetBindingSource2.DataSource = this.gr8Food_Group2DataSet;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 364);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.dgvOrders);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSet gr8Food_Group2_AssignmentDataSet;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentDataSet1BindingSource;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSet gr8Food_Group2_AssignmentDataSet1;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.BindingSource gr8FoodGroup2DataSetBindingSource;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSet gr8Food_Group2DataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.OrderTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource gr8FoodGroup2DataSetBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderRemarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gr8FoodGroup2DataSetBindingSource2;
    }
}