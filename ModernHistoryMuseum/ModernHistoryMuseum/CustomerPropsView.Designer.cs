namespace ModernHistoryMuseum
{
    partial class CustomerPropsView
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
            this.lsbDisplayProps = new System.Windows.Forms.ListBox();
            this.rtbPropDescription = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbDisplayProps
            // 
            this.lsbDisplayProps.FormattingEnabled = true;
            this.lsbDisplayProps.Location = new System.Drawing.Point(12, 12);
            this.lsbDisplayProps.Name = "lsbDisplayProps";
            this.lsbDisplayProps.Size = new System.Drawing.Size(158, 212);
            this.lsbDisplayProps.TabIndex = 0;
            // 
            // rtbPropDescription
            // 
            this.rtbPropDescription.Location = new System.Drawing.Point(185, 12);
            this.rtbPropDescription.Name = "rtbPropDescription";
            this.rtbPropDescription.Size = new System.Drawing.Size(405, 354);
            this.rtbPropDescription.TabIndex = 1;
            this.rtbPropDescription.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(469, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Exhibit";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // CustomerPropsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rtbPropDescription);
            this.Controls.Add(this.lsbDisplayProps);
            this.Name = "CustomerPropsView";
            this.Text = "CustomerPropsView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbDisplayProps;
        private System.Windows.Forms.RichTextBox rtbPropDescription;
        private System.Windows.Forms.Button btnBack;
    }
}