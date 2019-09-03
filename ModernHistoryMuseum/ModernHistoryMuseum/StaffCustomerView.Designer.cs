namespace ModernHistoryMuseum
{
    partial class StaffCustomerView
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
            this.dgvStaffEventView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffEventView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffEventView
            // 
            this.dgvStaffEventView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffEventView.Location = new System.Drawing.Point(12, 12);
            this.dgvStaffEventView.Name = "dgvStaffEventView";
            this.dgvStaffEventView.Size = new System.Drawing.Size(776, 413);
            this.dgvStaffEventView.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(693, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // StaffCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 463);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvStaffEventView);
            this.Name = "StaffCustomerView";
            this.Text = "StaffEventView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffEventView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffEventView;
        private System.Windows.Forms.Button btnBack;
    }
}