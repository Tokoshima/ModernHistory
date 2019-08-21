namespace ModernHistoryMuseum
{
    partial class AdminCustomerView
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
            this.dgvAdminCustomer = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminCustomer
            // 
            this.dgvAdminCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminCustomer.Location = new System.Drawing.Point(132, 65);
            this.dgvAdminCustomer.Name = "dgvAdminCustomer";
            this.dgvAdminCustomer.RowTemplate.Height = 24;
            this.dgvAdminCustomer.Size = new System.Drawing.Size(586, 316);
            this.dgvAdminCustomer.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(613, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // AdminCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAdminCustomer);
            this.Name = "AdminCustomerView";
            this.Text = "AdminCustomerView";
            this.Load += new System.EventHandler(this.AdminCustomerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminCustomer;
        private System.Windows.Forms.Button btnBack;
    }
}