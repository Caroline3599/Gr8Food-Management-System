namespace GR8FOODMS_IOOP
{
    partial class FeedbackForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpFeedback = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.cboCompletedOrders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 63);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Send Feedback";
            // 
            // grpFeedback
            // 
            this.grpFeedback.Controls.Add(this.lblMessage);
            this.grpFeedback.Controls.Add(this.txtFeedback);
            this.grpFeedback.Controls.Add(this.cboCompletedOrders);
            this.grpFeedback.Controls.Add(this.label2);
            this.grpFeedback.Controls.Add(this.label1);
            this.grpFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFeedback.Location = new System.Drawing.Point(9, 89);
            this.grpFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFeedback.Name = "grpFeedback";
            this.grpFeedback.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFeedback.Size = new System.Drawing.Size(1081, 275);
            this.grpFeedback.TabIndex = 1;
            this.grpFeedback.TabStop = false;
            this.grpFeedback.Text = "Feedback";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(33, 204);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 4;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(252, 117);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeedback.Size = new System.Drawing.Size(424, 21);
            this.txtFeedback.TabIndex = 3;
            // 
            // cboCompletedOrders
            // 
            this.cboCompletedOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompletedOrders.FormattingEnabled = true;
            this.cboCompletedOrders.Location = new System.Drawing.Point(252, 59);
            this.cboCompletedOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCompletedOrders.Name = "cboCompletedOrders";
            this.cboCompletedOrders.Size = new System.Drawing.Size(424, 28);
            this.cboCompletedOrders.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Feedback:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Completed Order:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(959, 476);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 43);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitFeedback.Location = new System.Drawing.Point(429, 444);
            this.btnSubmitFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(223, 75);
            this.btnSubmitFeedback.TabIndex = 3;
            this.btnSubmitFeedback.Text = "Submit Feedback";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 544);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpFeedback);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback Form";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpFeedback.ResumeLayout(false);
            this.grpFeedback.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFeedback;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.ComboBox cboCompletedOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmitFeedback;
    }
}