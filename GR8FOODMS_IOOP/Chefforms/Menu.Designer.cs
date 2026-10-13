using GR8FOODMS_IOOP;

namespace Ioop_Group_Assignment_Cheif
{
    partial class Menu
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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.gr8FoodGroup2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr8Food_Group2DataSet = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.gr8FoodGroup2AssignmentDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gr8Food_Group2_AssignmentDataSet1 = new GR8FOODMS_IOOP.Gr8Food_Group2DataSet();
            this.gr8FoodGroup2AssignmentDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gr8FoodGroup2AssignmentDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gr8FoodGroup2AssignmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.MenuTableAdapter();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(12, 308);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(112, 43);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Back To Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(586, 308);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(88, 43);
            this.btnHomePage.TabIndex = 2;
            this.btnHomePage.Text = "HomePage";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.dgvMenu.DataSource = this.menuBindingSource;
            this.dgvMenu.Location = new System.Drawing.Point(10, 6);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowTemplate.Height = 33;
            this.dgvMenu.Size = new System.Drawing.Size(660, 298);
            this.dgvMenu.TabIndex = 3;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.gr8FoodGroup2DataSetBindingSource;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MenuID";
            this.dataGridViewTextBoxColumn7.HeaderText = "MenuID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn8.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn10.HeaderText = "Category";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn11.HeaderText = "Status";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ChefID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ChefID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 357);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnDashboard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "d";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8Food_Group2_AssignmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr8FoodGroup2AssignmentDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentDataSetBindingSource;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentDataSetBindingSource1;
        private Gr8Food_Group2DataSet gr8Food_Group2_AssignmentDataSet;
        private System.Windows.Forms.BindingSource gr8FoodGroup2AssignmentDataSet1BindingSource1;
        private Gr8Food_Group2DataSet gr8Food_Group2_AssignmentDataSet1;
        private System.Windows.Forms.BindingSource gr8FoodGroup2DataSetBindingSource;
        private Gr8Food_Group2DataSet gr8Food_Group2DataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private GR8FOODMS_IOOP.Gr8Food_Group2DataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
    }
}