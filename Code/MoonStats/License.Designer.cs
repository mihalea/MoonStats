namespace MoonStats
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.rtLicense = new System.Windows.Forms.RichTextBox();
            this.lbGNU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtLicense
            // 
            this.rtLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtLicense.Location = new System.Drawing.Point(12, 36);
            this.rtLicense.Name = "rtLicense";
            this.rtLicense.ReadOnly = true;
            this.rtLicense.Size = new System.Drawing.Size(366, 369);
            this.rtLicense.TabIndex = 0;
            this.rtLicense.Text = resources.GetString("rtLicense.Text");
            // 
            // lbGNU
            // 
            this.lbGNU.AutoSize = true;
            this.lbGNU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbGNU.Location = new System.Drawing.Point(129, 9);
            this.lbGNU.Name = "lbGNU";
            this.lbGNU.Size = new System.Drawing.Size(113, 24);
            this.lbGNU.TabIndex = 1;
            this.lbGNU.Text = "MIT License";
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 417);
            this.Controls.Add(this.lbGNU);
            this.Controls.Add(this.rtLicense);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License";
            this.Load += new System.EventHandler(this.License_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtLicense;
        private System.Windows.Forms.Label lbGNU;
    }
}