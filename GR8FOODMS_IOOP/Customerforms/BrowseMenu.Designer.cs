namespace GR8FOODMS_IOOP
{
    partial class BrowseMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWalletBalance = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSelectedItem = new System.Windows.Forms.GroupBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblSelectedPrice = new System.Windows.Forms.Label();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lvCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.grpSelectedItem.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWalletBalance);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 53);
            this.panel1.TabIndex = 0;
            // 
            // lblWalletBalance
            // 
            this.lblWalletBalance.AutoSize = true;
            this.lblWalletBalance.Location = new System.Drawing.Point(899, 20);
            this.lblWalletBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWalletBalance.Name = "lblWalletBalance";
            this.lblWalletBalance.Size = new System.Drawing.Size(89, 15);
            this.lblWalletBalance.TabIndex = 1;
            this.lblWalletBalance.Text = "E-Wallet: RM 0";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Browse Menu";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.dgvMenu);
            this.grpMenu.Controls.Add(this.cboCategory);
            this.grpMenu.Controls.Add(this.label1);
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(9, 73);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpMenu.Size = new System.Drawing.Size(662, 543);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu";
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(45, 104);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 72;
            this.dgvMenu.RowTemplate.Height = 31;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(578, 393);
            this.dgvMenu.TabIndex = 2;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(243, 42);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(352, 28);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter by Category:\r\n";
            // 
            // grpSelectedItem
            // 
            this.grpSelectedItem.Controls.Add(this.btnAddToCart);
            this.grpSelectedItem.Controls.Add(this.txtQuantity);
            this.grpSelectedItem.Controls.Add(this.lblQty);
            this.grpSelectedItem.Controls.Add(this.lblSelectedPrice);
            this.grpSelectedItem.Controls.Add(this.lblSelectedItem);
            this.grpSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectedItem.Location = new System.Drawing.Point(675, 73);
            this.grpSelectedItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSelectedItem.Name = "grpSelectedItem";
            this.grpSelectedItem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSelectedItem.Size = new System.Drawing.Size(357, 223);
            this.grpSelectedItem.TabIndex = 3;
            this.grpSelectedItem.TabStop = false;
            this.grpSelectedItem.Text = "Selected Item";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(113, 174);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(145, 34);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(100, 134);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(88, 26);
            this.txtQuantity.TabIndex = 3;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(18, 136);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(76, 20);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Quantity:";
            // 
            // lblSelectedPrice
            // 
            this.lblSelectedPrice.AutoSize = true;
            this.lblSelectedPrice.Location = new System.Drawing.Point(18, 89);
            this.lblSelectedPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedPrice.Name = "lblSelectedPrice";
            this.lblSelectedPrice.Size = new System.Drawing.Size(69, 20);
            this.lblSelectedPrice.TabIndex = 1;
            this.lblSelectedPrice.Text = "Price: - ";
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Location = new System.Drawing.Point(18, 42);
            this.lblSelectedItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(135, 20);
            this.lblSelectedItem.TabIndex = 0;
            this.lblSelectedItem.Text = "No item selected";
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.btnBack);
            this.grpCart.Controls.Add(this.lblRemarks);
            this.grpCart.Controls.Add(this.txtRemarks);
            this.grpCart.Controls.Add(this.btnConfirmOrder);
            this.grpCart.Controls.Add(this.btnRemoveItem);
            this.grpCart.Controls.Add(this.lblTotal);
            this.grpCart.Controls.Add(this.lvCart);
            this.grpCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCart.Location = new System.Drawing.Point(675, 295);
            this.grpCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCart.Name = "grpCart";
            this.grpCart.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCart.Size = new System.Drawing.Size(359, 321);
            this.grpCart.TabIndex = 5;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Order Cart";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(247, 222);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(4, 160);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(132, 17);
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "Remarks (optional):";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(141, 160);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(209, 21);
            this.txtRemarks.TabIndex = 4;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(128, 191);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(103, 60);
            this.btnConfirmOrder.TabIndex = 3;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(8, 191);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(103, 60);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove Selected";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(4, 131);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: RM 0";
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCart.FullRowSelect = true;
            this.lvCart.GridLines = true;
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(4, 28);
            this.lvCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(346, 95);
            this.lvCart.TabIndex = 0;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subtotal";
            this.columnHeader4.Width = 116;
            // 
            // BrowseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 625);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpSelectedItem);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "BrowseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Menu";
            this.Load += new System.EventHandler(this.BrowseMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.grpSelectedItem.ResumeLayout(false);
            this.grpSelectedItem.PerformLayout();
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWalletBalance;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSelectedItem;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblSelectedPrice;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBack;
    }
}