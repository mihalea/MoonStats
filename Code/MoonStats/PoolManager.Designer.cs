namespace MoonStats
{
    partial class PoolManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoolManager));
            this.lbPool = new System.Windows.Forms.Label();
            this.tboxURL = new System.Windows.Forms.TextBox();
            this.tboxKey = new System.Windows.Forms.TextBox();
            this.tboxRefresh = new System.Windows.Forms.TextBox();
            this.lbRefresh = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tboxPool = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPool
            // 
            this.lbPool.AutoSize = true;
            this.lbPool.Location = new System.Drawing.Point(12, 15);
            this.lbPool.Name = "lbPool";
            this.lbPool.Size = new System.Drawing.Size(31, 13);
            this.lbPool.TabIndex = 10;
            this.lbPool.Text = "Pool:";
            // 
            // tboxURL
            // 
            this.tboxURL.BackColor = System.Drawing.SystemColors.Window;
            this.tboxURL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxURL.Location = new System.Drawing.Point(100, 39);
            this.tboxURL.Name = "tboxURL";
            this.tboxURL.Size = new System.Drawing.Size(290, 20);
            this.tboxURL.TabIndex = 2;
            this.tboxURL.TextChanged += new System.EventHandler(this.tboxURL_TextChanged);
            // 
            // tboxKey
            // 
            this.tboxKey.Location = new System.Drawing.Point(100, 65);
            this.tboxKey.Name = "tboxKey";
            this.tboxKey.Size = new System.Drawing.Size(290, 20);
            this.tboxKey.TabIndex = 3;
            this.tboxKey.TextChanged += new System.EventHandler(this.tboxKey_TextChanged);
            // 
            // tboxRefresh
            // 
            this.tboxRefresh.Location = new System.Drawing.Point(100, 91);
            this.tboxRefresh.Name = "tboxRefresh";
            this.tboxRefresh.Size = new System.Drawing.Size(290, 20);
            this.tboxRefresh.TabIndex = 4;
            this.tboxRefresh.TextChanged += new System.EventHandler(this.tboxRefresh_TextChanged);
            this.tboxRefresh.Validating += new System.ComponentModel.CancelEventHandler(this.tboxRefresh_Validating);
            // 
            // lbRefresh
            // 
            this.lbRefresh.AutoSize = true;
            this.lbRefresh.Location = new System.Drawing.Point(12, 94);
            this.lbRefresh.Name = "lbRefresh";
            this.lbRefresh.Size = new System.Drawing.Size(82, 13);
            this.lbRefresh.TabIndex = 6;
            this.lbRefresh.Text = "Refresh rate (s):";
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(12, 68);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(48, 13);
            this.lbKey.TabIndex = 4;
            this.lbKey.Text = "API Key:";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(12, 42);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(32, 13);
            this.lbURL.TabIndex = 2;
            this.lbURL.Text = "URL:";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(168, 134);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tboxPool
            // 
            this.tboxPool.Location = new System.Drawing.Point(100, 12);
            this.tboxPool.Name = "tboxPool";
            this.tboxPool.Size = new System.Drawing.Size(290, 20);
            this.tboxPool.TabIndex = 1;
            this.tboxPool.TextChanged += new System.EventHandler(this.tboxPool_TextChanged);
            // 
            // PoolManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 171);
            this.Controls.Add(this.tboxPool);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbPool);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.tboxURL);
            this.Controls.Add(this.lbRefresh);
            this.Controls.Add(this.tboxKey);
            this.Controls.Add(this.tboxRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PoolManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage pools";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPool;
        private System.Windows.Forms.TextBox tboxURL;
        private System.Windows.Forms.TextBox tboxKey;
        private System.Windows.Forms.TextBox tboxRefresh;
        private System.Windows.Forms.Label lbRefresh;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tboxPool;

    }
}