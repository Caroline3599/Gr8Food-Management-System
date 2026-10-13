using GR8FOODMS_IOOP;

namespace Ioop_Group_Assignment_Cheif
{
    partial class Delete
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
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gr8Food_Group2_AssignmentDataSet = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.gr8FoodGroup2AssignmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoGenerateColumns = false;
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.chefIDDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.dgvDelete.DataMember = "Menu";
            this.dgvDelete.DataSource = this.gr8FoodGroup2AssignmentDataSetBindingSource;
            this.dgvDelete.Location = new System.Drawing.Point(12, 12);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.RowHeadersWidth = 72;
            this.dgvDelete.RowTemplate.Height = 33;
            this.dgvDelete.Size = new System.Drawing.Size(1303, 704);
            this.dgvDelete.TabIndex = 0;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(12, 722);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(187, 69);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(1102, 722);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(213, 69);
            this.btnHomePage.TabIndex = 2;
            this.btnHomePage.Text = "Back To HomePage";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(575, 722);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 69);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gr8Food_Group2_AssignmentDataSet
            // 
            this.gr8Food_Group2_AssignmentDataSet.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2_AssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gr8FoodGroup2AssignmentDataSetBindingSource
            // 
            this.gr8FoodGroup2AssignmentDataSetBindingSource.DataSource = this.gr8Food_Group2_AssignmentDataSet;
            this.gr8FoodGroup2AssignmentDataSetBindingSource.Position = 0;
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            this.menuIDDataGridViewTextBoxColumn.Width = 175;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 175;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 175;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 175;
            // 
            // chefIDDataGridViewTextBoxColumn
            // 
            this.chefIDDataGridViewTextBoxColumn.DataPropertyName = "ChefID";
            this.chefIDDataGridViewTextBoxColumn.HeaderText = "ChefID";
            this.chefIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.chefIDDataGridViewTextBoxColumn.Name = "chefIDDataGridViewTextBoxColumn";
            this.chefIDDataGridViewTextBoxColumn.Width = 175;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            this.stockQuantityDataGridViewTextBoxColumn.Width = 175;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 795);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.dgvDelete);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDelete;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentDataSetBindingSource;
        private Gr8Food_Group2DataSet gr8Food_Group2_AssignmentDataSet;
    }
}