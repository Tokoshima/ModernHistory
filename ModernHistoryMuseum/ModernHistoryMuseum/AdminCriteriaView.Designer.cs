﻿namespace ModernHistoryMuseum
{
    partial class AdminCriteriaView
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
            this.dgvAdminCriteria = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCriteria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminCriteria
            // 
            this.dgvAdminCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminCriteria.Location = new System.Drawing.Point(62, 35);
            this.dgvAdminCriteria.Name = "dgvAdminCriteria";
            this.dgvAdminCriteria.RowTemplate.Height = 24;
            this.dgvAdminCriteria.Size = new System.Drawing.Size(695, 324);
            this.dgvAdminCriteria.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(663, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // AdminCriteriaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAdminCriteria);
            this.Name = "AdminCriteriaView";
            this.Text = "AdminCriteriaView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCriteria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminCriteria;
        private System.Windows.Forms.Button btnBack;
    }
}