namespace ModernHistoryMuseum
{
    partial class CustomerCustomerView
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvCustomerCustomerView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerCustomerView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(495, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerCustomerView
            // 
            this.dgvCustomerCustomerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerCustomerView.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomerCustomerView.Name = "dgvCustomerCustomerView";
            this.dgvCustomerCustomerView.Size = new System.Drawing.Size(558, 347);
            this.dgvCustomerCustomerView.TabIndex = 1;
            // 
            // CustomerCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 400);
            this.Controls.Add(this.dgvCustomerCustomerView);
            this.Controls.Add(this.btnBack);
            this.Name = "CustomerCustomerView";
            this.Text = "CustomerCustomerView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerCustomerView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCustomerCustomerView;
    }
}