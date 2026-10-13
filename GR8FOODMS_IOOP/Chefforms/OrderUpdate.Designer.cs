namespace Ioop_Group_Assignment_Cheif
{
    partial class OrderUpdate
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
            this.dgvOrderUpdate = new System.Windows.Forms.DataGridView();
            this.gr8Food_Group2_AssignmentMain2 = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.gr8Food_Group2DataSet = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.gr8FoodGroup2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentMain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderUpdate
            // 
            this.dgvOrderUpdate.AutoGenerateColumns = false;
            this.dgvOrderUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvOrderUpdate.DataMember = "Order";
            this.dgvOrderUpdate.DataSource = this.gr8FoodGroup2DataSetBindingSource;
            this.dgvOrderUpdate.Location = new System.Drawing.Point(10, 6);
            this.dgvOrderUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderUpdate.Name = "dgvOrderUpdate";
            this.dgvOrderUpdate.RowHeadersWidth = 72;
            this.dgvOrderUpdate.RowTemplate.Height = 33;
            this.dgvOrderUpdate.Size = new System.Drawing.Size(576, 307);
            this.dgvOrderUpdate.TabIndex = 0;
            this.dgvOrderUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderUpdate_CellContentClick);
            // 
            // gr8Food_Group2_AssignmentMain2
            // 
            this.gr8Food_Group2_AssignmentMain2.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2_AssignmentMain2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(471, 317);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(106, 37);
            this.btnHomePage.TabIndex = 1;
            this.btnHomePage.Text = "HomePage";
            this.btnHomePage.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 317);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(10, 317);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(84, 37);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // gr8Food_Group2DataSet
            // 
            this.gr8Food_Group2DataSet.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gr8FoodGroup2DataSetBindingSource
            // 
            this.gr8FoodGroup2DataSetBindingSource.DataSource = this.gr8Food_Group2DataSet;
            this.gr8FoodGroup2DataSetBindingSource.Position = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderStatus";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderStatus";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderRemarks";
            this.dataGridViewTextBoxColumn5.HeaderText = "OrderRemarks";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // OrderUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 356);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.dgvOrderUpdate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderUpdate";
            this.Text = "OrderUpdate";
            this.Load += new System.EventHandler(this.OrderUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentMain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderUpdate;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOrders;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSet gr8Food_Group2_AssignmentMain2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderRemarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentDataSetBindingSource;
        // removed old dataset field
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource gr8FoodGroup2DataSetBindingSource;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSet gr8Food_Group2DataSet;
    }
}