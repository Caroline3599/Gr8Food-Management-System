using GR8FOODMS_IOOP;

namespace Ioop_Group_Assignment_Cheif
{
    partial class Edit
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
            this.dgvEdit = new System.Windows.Forms.DataGridView();
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr8FoodGroup2AssignmentMain2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr8Food_Group2_AssignmentMain2 = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentMain2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentMain2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoGenerateColumns = false;
            this.dgvEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.chefIDDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.dgvEdit.DataMember = "Menu";
            this.dgvEdit.DataSource = this.gr8FoodGroup2AssignmentMain2BindingSource;
            this.dgvEdit.Location = new System.Drawing.Point(12, 12);
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.Size = new System.Drawing.Size(744, 409);
            this.dgvEdit.TabIndex = 0;
            this.dgvEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdit_CellContentClick);
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // chefIDDataGridViewTextBoxColumn
            // 
            this.chefIDDataGridViewTextBoxColumn.DataPropertyName = "ChefID";
            this.chefIDDataGridViewTextBoxColumn.HeaderText = "ChefID";
            this.chefIDDataGridViewTextBoxColumn.Name = "chefIDDataGridViewTextBoxColumn";
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            // 
            // gr8FoodGroup2AssignmentMain2BindingSource
            // 
            this.gr8FoodGroup2AssignmentMain2BindingSource.DataSource = this.gr8Food_Group2_AssignmentMain2;
            this.gr8FoodGroup2AssignmentMain2BindingSource.Position = 0;
            // 
            // gr8Food_Group2_AssignmentMain2
            // 
            this.gr8Food_Group2_AssignmentMain2.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2_AssignmentMain2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(12, 427);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(149, 42);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(607, 427);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(149, 42);
            this.btnHomePage.TabIndex = 3;
            this.btnHomePage.Text = "HomePage";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 479);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.dgvEdit);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentMain2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentMain2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEdit;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentMain2BindingSource;
        private Gr8Food_Group2DataSet gr8Food_Group2_AssignmentMain2;
    }
}