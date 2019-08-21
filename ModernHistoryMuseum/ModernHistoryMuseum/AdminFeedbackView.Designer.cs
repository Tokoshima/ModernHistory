namespace ModernHistoryMuseum
{
    partial class AdminFeedbackView
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
            this.dgvAdminFeedback = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminFeedback
            // 
            this.dgvAdminFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminFeedback.Location = new System.Drawing.Point(153, 92);
            this.dgvAdminFeedback.Name = "dgvAdminFeedback";
            this.dgvAdminFeedback.RowTemplate.Height = 24;
            this.dgvAdminFeedback.Size = new System.Drawing.Size(572, 312);
            this.dgvAdminFeedback.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(644, 421);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 46);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // AdminFeedbackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAdminFeedback);
            this.Name = "AdminFeedbackView";
            this.Text = "AdminFeedbackView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminFeedback;
        private System.Windows.Forms.Button btnBack;
    }
}