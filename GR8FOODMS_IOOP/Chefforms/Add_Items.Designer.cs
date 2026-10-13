using System.Drawing;
using GR8FOODMS_IOOP;

namespace Ioop_Group_Assignment_Cheif
{
    partial class Add_Items
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr8FoodGroup2AssignmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr8Food_Group2_AssignmentDataSet = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(12, 564);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(144, 43);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DashBoard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(837, 564);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(150, 43);
            this.btnHomePage.TabIndex = 2;
            this.btnHomePage.Text = "HomePage";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.chefIDDataGridViewTextBoxColumn});
            this.dgvStock.DataMember = "Menu";
            this.dgvStock.DataSource = this.gr8FoodGroup2AssignmentDataSetBindingSource;
            this.dgvStock.Location = new System.Drawing.Point(9, 8);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 72;
            this.dgvStock.RowTemplate.Height = 33;
            this.dgvStock.Size = new System.Drawing.Size(976, 536);
            this.dgvStock.TabIndex = 22;
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
            // gr8FoodGroup2AssignmentDataSetBindingSource
            // 
            this.gr8FoodGroup2AssignmentDataSetBindingSource.DataSource = this.gr8Food_Group2_AssignmentDataSet;
            this.gr8FoodGroup2AssignmentDataSetBindingSource.Position = 0;
            // 
            // gr8Food_Group2_AssignmentDataSet
            // 
            this.gr8Food_Group2_AssignmentDataSet.DataSetName = "Gr8Food_Group2DataSet";
            this.gr8Food_Group2_AssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 43);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Add_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 611);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnDashboard);
            this.Name = "Add_Items";
            this.Text = "Add_Items";
            this.Load += new System.EventHandler(this.Add_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet)).EndInit();
            this.ResumeLayout(false);

        }






        #endregion
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentDataSetBindingSource;
        private Gr8Food_Group2DataSet gr8Food_Group2_AssignmentDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
    }
}