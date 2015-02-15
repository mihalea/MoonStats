namespace MoonStats
{
    partial class MoonStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoonStats));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbDogeToUsd = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbxWorkers = new System.Windows.Forms.GroupBox();
            this.cbxPools = new System.Windows.Forms.ComboBox();
            this.varValid = new System.Windows.Forms.Label();
            this.varInvalid = new System.Windows.Forms.Label();
            this.varUserSharerate = new System.Windows.Forms.Label();
            this.varUserHashrate = new System.Windows.Forms.Label();
            this.lbValid = new System.Windows.Forms.Label();
            this.lbInvalid = new System.Windows.Forms.Label();
            this.lbSharerate = new System.Windows.Forms.Label();
            this.lbHashrate = new System.Windows.Forms.Label();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHashrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxNetwork = new System.Windows.Forms.GroupBox();
            this.varPoolHashrate = new System.Windows.Forms.Label();
            this.varNetworkHashrate = new System.Windows.Forms.Label();
            this.varTimeSince = new System.Windows.Forms.Label();
            this.varTimeTo = new System.Windows.Forms.Label();
            this.varDifficulty = new System.Windows.Forms.Label();
            this.varBlock = new System.Windows.Forms.Label();
            this.lbTimeTo = new System.Windows.Forms.Label();
            this.lbTimeSince = new System.Windows.Forms.Label();
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.lbBlock = new System.Windows.Forms.Label();
            this.lbPoolHashrate = new System.Windows.Forms.Label();
            this.lbNetworkHashrate = new System.Windows.Forms.Label();
            this.gbxBalance = new System.Windows.Forms.GroupBox();
            this.varUsd = new System.Windows.Forms.Label();
            this.lbUsd = new System.Windows.Forms.Label();
            this.varDoge = new System.Windows.Forms.Label();
            this.lbDoges = new System.Windows.Forms.Label();
            this.varUnconfirmed = new System.Windows.Forms.Label();
            this.varConfirmed = new System.Windows.Forms.Label();
            this.dgvWallet = new System.Windows.Forms.DataGridView();
            this.lbUnconfirmed = new System.Windows.Forms.Label();
            this.lbConfirmed = new System.Windows.Forms.Label();
            this.poolTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.ofdWallet = new System.Windows.Forms.OpenFileDialog();
            this.exchangeTimer = new System.Windows.Forms.Timer(this.components);
            this.gbxTransactions = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.varMax = new System.Windows.Forms.Label();
            this.varMin = new System.Windows.Forms.Label();
            this.varAvg = new System.Windows.Forms.Label();
            this.varTotalFees = new System.Windows.Forms.Label();
            this.varTotalMined = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbMaxBlock = new System.Windows.Forms.Label();
            this.lbMinBlock = new System.Windows.Forms.Label();
            this.lbAvgBlock = new System.Windows.Forms.Label();
            this.lbTotalMined = new System.Windows.Forms.Label();
            this.bgwExchange = new System.ComponentModel.BackgroundWorker();
            this.bgwWallet = new System.ComponentModel.BackgroundWorker();
            this.bgwPool = new System.ComponentModel.BackgroundWorker();
            this.bgwWrite = new System.ComponentModel.BackgroundWorker();
            this.bgwRead = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gbxWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.gbxNetwork.SuspendLayout();
            this.gbxBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallet)).BeginInit();
            this.gbxTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(776, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importWalletToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importWalletToolStripMenuItem
            // 
            this.importWalletToolStripMenuItem.Name = "importWalletToolStripMenuItem";
            this.importWalletToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.importWalletToolStripMenuItem.Text = "Import wallet";
            this.importWalletToolStripMenuItem.Click += new System.EventHandler(this.importWalletToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.lbSeparator,
            this.lbDogeToUsd});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(776, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(89, 17);
            this.lbStatus.Text = "Status: Stopped";
            // 
            // lbSeparator
            // 
            this.lbSeparator.Name = "lbSeparator";
            this.lbSeparator.Size = new System.Drawing.Size(577, 17);
            this.lbSeparator.Spring = true;
            // 
            // lbDogeToUsd
            // 
            this.lbDogeToUsd.Name = "lbDogeToUsd";
            this.lbDogeToUsd.Size = new System.Drawing.Size(95, 17);
            this.lbDogeToUsd.Text = "1 Doge = 1 Doge";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Location = new System.Drawing.Point(12, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 29);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start monitoring";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbxWorkers
            // 
            this.gbxWorkers.Controls.Add(this.cbxPools);
            this.gbxWorkers.Controls.Add(this.varValid);
            this.gbxWorkers.Controls.Add(this.varInvalid);
            this.gbxWorkers.Controls.Add(this.varUserSharerate);
            this.gbxWorkers.Controls.Add(this.varUserHashrate);
            this.gbxWorkers.Controls.Add(this.lbValid);
            this.gbxWorkers.Controls.Add(this.lbInvalid);
            this.gbxWorkers.Controls.Add(this.lbSharerate);
            this.gbxWorkers.Controls.Add(this.lbHashrate);
            this.gbxWorkers.Controls.Add(this.dgvWorkers);
            this.gbxWorkers.Location = new System.Drawing.Point(12, 62);
            this.gbxWorkers.Name = "gbxWorkers";
            this.gbxWorkers.Size = new System.Drawing.Size(374, 228);
            this.gbxWorkers.TabIndex = 19;
            this.gbxWorkers.TabStop = false;
            this.gbxWorkers.Text = "Workers:";
            // 
            // cbxPools
            // 
            this.cbxPools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPools.FormattingEnabled = true;
            this.cbxPools.Location = new System.Drawing.Point(6, 19);
            this.cbxPools.Name = "cbxPools";
            this.cbxPools.Size = new System.Drawing.Size(362, 21);
            this.cbxPools.TabIndex = 24;
            this.cbxPools.SelectedIndexChanged += new System.EventHandler(this.cbxPools_SelectedIndexChanged);
            // 
            // varValid
            // 
            this.varValid.Location = new System.Drawing.Point(281, 183);
            this.varValid.Name = "varValid";
            this.varValid.Size = new System.Drawing.Size(87, 13);
            this.varValid.TabIndex = 23;
            this.varValid.Text = "N/A";
            this.varValid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varInvalid
            // 
            this.varInvalid.Location = new System.Drawing.Point(281, 205);
            this.varInvalid.Name = "varInvalid";
            this.varInvalid.Size = new System.Drawing.Size(87, 13);
            this.varInvalid.TabIndex = 22;
            this.varInvalid.Text = "N/A";
            this.varInvalid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varUserSharerate
            // 
            this.varUserSharerate.Location = new System.Drawing.Point(71, 205);
            this.varUserSharerate.Name = "varUserSharerate";
            this.varUserSharerate.Size = new System.Drawing.Size(99, 13);
            this.varUserSharerate.TabIndex = 21;
            this.varUserSharerate.Text = "N/A shares/s";
            this.varUserSharerate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varUserHashrate
            // 
            this.varUserHashrate.Location = new System.Drawing.Point(68, 183);
            this.varUserHashrate.Name = "varUserHashrate";
            this.varUserHashrate.Size = new System.Drawing.Size(102, 13);
            this.varUserHashrate.TabIndex = 20;
            this.varUserHashrate.Text = "N/A MHz/s";
            this.varUserHashrate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbValid
            // 
            this.lbValid.AutoSize = true;
            this.lbValid.Location = new System.Drawing.Point(200, 183);
            this.lbValid.Name = "lbValid";
            this.lbValid.Size = new System.Drawing.Size(67, 13);
            this.lbValid.TabIndex = 5;
            this.lbValid.Text = "Valid shares:";
            // 
            // lbInvalid
            // 
            this.lbInvalid.AutoSize = true;
            this.lbInvalid.Location = new System.Drawing.Point(200, 205);
            this.lbInvalid.Name = "lbInvalid";
            this.lbInvalid.Size = new System.Drawing.Size(75, 13);
            this.lbInvalid.TabIndex = 4;
            this.lbInvalid.Text = "Invalid shares:";
            // 
            // lbSharerate
            // 
            this.lbSharerate.AutoSize = true;
            this.lbSharerate.Location = new System.Drawing.Point(6, 205);
            this.lbSharerate.Name = "lbSharerate";
            this.lbSharerate.Size = new System.Drawing.Size(59, 13);
            this.lbSharerate.TabIndex = 3;
            this.lbSharerate.Text = "Sharerate: ";
            // 
            // lbHashrate
            // 
            this.lbHashrate.AutoSize = true;
            this.lbHashrate.Location = new System.Drawing.Point(6, 183);
            this.lbHashrate.Name = "lbHashrate";
            this.lbHashrate.Size = new System.Drawing.Size(56, 13);
            this.lbHashrate.TabIndex = 2;
            this.lbHashrate.Text = "Hashrate: ";
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.AllowUserToResizeRows = false;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmHashrate,
            this.clmDifficulty});
            this.dgvWorkers.Location = new System.Drawing.Point(6, 46);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.ReadOnly = true;
            this.dgvWorkers.RowHeadersVisible = false;
            this.dgvWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkers.Size = new System.Drawing.Size(362, 123);
            this.dgvWorkers.TabIndex = 0;
            this.dgvWorkers.SelectionChanged += new System.EventHandler(this.dgvWorkers_SelectionChanged);
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.HeaderText = "Username";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmHashrate
            // 
            this.clmHashrate.FillWeight = 25F;
            this.clmHashrate.HeaderText = "Hashrate";
            this.clmHashrate.Name = "clmHashrate";
            this.clmHashrate.ReadOnly = true;
            this.clmHashrate.Width = 75;
            // 
            // clmDifficulty
            // 
            this.clmDifficulty.FillWeight = 25F;
            this.clmDifficulty.HeaderText = "Difficulty";
            this.clmDifficulty.Name = "clmDifficulty";
            this.clmDifficulty.ReadOnly = true;
            this.clmDifficulty.Width = 75;
            // 
            // gbxNetwork
            // 
            this.gbxNetwork.Controls.Add(this.varPoolHashrate);
            this.gbxNetwork.Controls.Add(this.varNetworkHashrate);
            this.gbxNetwork.Controls.Add(this.varTimeSince);
            this.gbxNetwork.Controls.Add(this.varTimeTo);
            this.gbxNetwork.Controls.Add(this.varDifficulty);
            this.gbxNetwork.Controls.Add(this.varBlock);
            this.gbxNetwork.Controls.Add(this.lbTimeTo);
            this.gbxNetwork.Controls.Add(this.lbTimeSince);
            this.gbxNetwork.Controls.Add(this.lbDifficulty);
            this.gbxNetwork.Controls.Add(this.lbBlock);
            this.gbxNetwork.Controls.Add(this.lbPoolHashrate);
            this.gbxNetwork.Controls.Add(this.lbNetworkHashrate);
            this.gbxNetwork.Location = new System.Drawing.Point(12, 296);
            this.gbxNetwork.Name = "gbxNetwork";
            this.gbxNetwork.Size = new System.Drawing.Size(374, 104);
            this.gbxNetwork.TabIndex = 20;
            this.gbxNetwork.TabStop = false;
            this.gbxNetwork.Text = "Network:";
            // 
            // varPoolHashrate
            // 
            this.varPoolHashrate.Location = new System.Drawing.Point(86, 48);
            this.varPoolHashrate.Name = "varPoolHashrate";
            this.varPoolHashrate.Size = new System.Drawing.Size(84, 13);
            this.varPoolHashrate.TabIndex = 18;
            this.varPoolHashrate.Text = "N/A Hz/s";
            this.varPoolHashrate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varNetworkHashrate
            // 
            this.varNetworkHashrate.Location = new System.Drawing.Point(83, 26);
            this.varNetworkHashrate.Name = "varNetworkHashrate";
            this.varNetworkHashrate.Size = new System.Drawing.Size(87, 13);
            this.varNetworkHashrate.TabIndex = 17;
            this.varNetworkHashrate.Text = "N/A GHz/s";
            this.varNetworkHashrate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varTimeSince
            // 
            this.varTimeSince.Location = new System.Drawing.Point(117, 70);
            this.varTimeSince.Name = "varTimeSince";
            this.varTimeSince.Size = new System.Drawing.Size(53, 13);
            this.varTimeSince.TabIndex = 16;
            this.varTimeSince.Text = "h:m:s";
            this.varTimeSince.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varTimeTo
            // 
            this.varTimeTo.Location = new System.Drawing.Point(303, 70);
            this.varTimeTo.Name = "varTimeTo";
            this.varTimeTo.Size = new System.Drawing.Size(65, 13);
            this.varTimeTo.TabIndex = 15;
            this.varTimeTo.Text = "h:m:s";
            this.varTimeTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varDifficulty
            // 
            this.varDifficulty.Location = new System.Drawing.Point(252, 48);
            this.varDifficulty.Name = "varDifficulty";
            this.varDifficulty.Size = new System.Drawing.Size(116, 13);
            this.varDifficulty.TabIndex = 14;
            this.varDifficulty.Text = "N/A";
            this.varDifficulty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varBlock
            // 
            this.varBlock.Location = new System.Drawing.Point(252, 26);
            this.varBlock.Name = "varBlock";
            this.varBlock.Size = new System.Drawing.Size(116, 13);
            this.varBlock.TabIndex = 13;
            this.varBlock.Text = "N/A";
            this.varBlock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTimeTo
            // 
            this.lbTimeTo.AutoSize = true;
            this.lbTimeTo.Location = new System.Drawing.Point(200, 70);
            this.lbTimeTo.Name = "lbTimeTo";
            this.lbTimeTo.Size = new System.Drawing.Size(97, 13);
            this.lbTimeTo.TabIndex = 12;
            this.lbTimeTo.Text = "Time to next block:";
            // 
            // lbTimeSince
            // 
            this.lbTimeSince.AutoSize = true;
            this.lbTimeSince.Location = new System.Drawing.Point(3, 70);
            this.lbTimeSince.Name = "lbTimeSince";
            this.lbTimeSince.Size = new System.Drawing.Size(109, 13);
            this.lbTimeSince.TabIndex = 11;
            this.lbTimeSince.Text = "Time since last block:";
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Location = new System.Drawing.Point(200, 48);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lbDifficulty.TabIndex = 10;
            this.lbDifficulty.Text = "Difficulty:";
            // 
            // lbBlock
            // 
            this.lbBlock.AutoSize = true;
            this.lbBlock.Location = new System.Drawing.Point(200, 26);
            this.lbBlock.Name = "lbBlock";
            this.lbBlock.Size = new System.Drawing.Size(37, 13);
            this.lbBlock.TabIndex = 9;
            this.lbBlock.Text = "Block:";
            // 
            // lbPoolHashrate
            // 
            this.lbPoolHashrate.AutoSize = true;
            this.lbPoolHashrate.Location = new System.Drawing.Point(6, 48);
            this.lbPoolHashrate.Name = "lbPoolHashrate";
            this.lbPoolHashrate.Size = new System.Drawing.Size(75, 13);
            this.lbPoolHashrate.TabIndex = 7;
            this.lbPoolHashrate.Text = "Pool hashrate:";
            // 
            // lbNetworkHashrate
            // 
            this.lbNetworkHashrate.AutoSize = true;
            this.lbNetworkHashrate.Location = new System.Drawing.Point(6, 26);
            this.lbNetworkHashrate.Name = "lbNetworkHashrate";
            this.lbNetworkHashrate.Size = new System.Drawing.Size(71, 13);
            this.lbNetworkHashrate.TabIndex = 6;
            this.lbNetworkHashrate.Text = "Net hashrate:";
            // 
            // gbxBalance
            // 
            this.gbxBalance.Controls.Add(this.varUsd);
            this.gbxBalance.Controls.Add(this.lbUsd);
            this.gbxBalance.Controls.Add(this.varDoge);
            this.gbxBalance.Controls.Add(this.lbDoges);
            this.gbxBalance.Controls.Add(this.varUnconfirmed);
            this.gbxBalance.Controls.Add(this.varConfirmed);
            this.gbxBalance.Controls.Add(this.dgvWallet);
            this.gbxBalance.Controls.Add(this.lbUnconfirmed);
            this.gbxBalance.Controls.Add(this.lbConfirmed);
            this.gbxBalance.Location = new System.Drawing.Point(392, 62);
            this.gbxBalance.Name = "gbxBalance";
            this.gbxBalance.Size = new System.Drawing.Size(374, 338);
            this.gbxBalance.TabIndex = 21;
            this.gbxBalance.TabStop = false;
            this.gbxBalance.Text = "Balance:";
            // 
            // varUsd
            // 
            this.varUsd.Location = new System.Drawing.Point(205, 304);
            this.varUsd.Name = "varUsd";
            this.varUsd.Size = new System.Drawing.Size(86, 13);
            this.varUsd.TabIndex = 29;
            this.varUsd.Text = "N/A";
            this.varUsd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbUsd
            // 
            this.lbUsd.AutoSize = true;
            this.lbUsd.Location = new System.Drawing.Point(68, 304);
            this.lbUsd.Name = "lbUsd";
            this.lbUsd.Size = new System.Drawing.Size(107, 13);
            this.lbUsd.TabIndex = 28;
            this.lbUsd.Text = "Total in wallet (USD):";
            // 
            // varDoge
            // 
            this.varDoge.Location = new System.Drawing.Point(205, 282);
            this.varDoge.Name = "varDoge";
            this.varDoge.Size = new System.Drawing.Size(86, 13);
            this.varDoge.TabIndex = 27;
            this.varDoge.Text = "N/A";
            this.varDoge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbDoges
            // 
            this.lbDoges.AutoSize = true;
            this.lbDoges.Location = new System.Drawing.Point(68, 282);
            this.lbDoges.Name = "lbDoges";
            this.lbDoges.Size = new System.Drawing.Size(115, 13);
            this.lbDoges.TabIndex = 26;
            this.lbDoges.Text = "Total in wallet (DOGE):";
            // 
            // varUnconfirmed
            // 
            this.varUnconfirmed.Location = new System.Drawing.Point(205, 260);
            this.varUnconfirmed.Name = "varUnconfirmed";
            this.varUnconfirmed.Size = new System.Drawing.Size(86, 13);
            this.varUnconfirmed.TabIndex = 25;
            this.varUnconfirmed.Text = "N/A";
            this.varUnconfirmed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varConfirmed
            // 
            this.varConfirmed.Location = new System.Drawing.Point(208, 238);
            this.varConfirmed.Name = "varConfirmed";
            this.varConfirmed.Size = new System.Drawing.Size(83, 13);
            this.varConfirmed.TabIndex = 24;
            this.varConfirmed.Text = "N/A";
            this.varConfirmed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvWallet
            // 
            this.dgvWallet.AllowUserToResizeRows = false;
            this.dgvWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWallet.Location = new System.Drawing.Point(6, 41);
            this.dgvWallet.Name = "dgvWallet";
            this.dgvWallet.RowHeadersVisible = false;
            this.dgvWallet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWallet.Size = new System.Drawing.Size(362, 177);
            this.dgvWallet.TabIndex = 15;
            this.dgvWallet.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvWallet_ColumnHeaderMouseClick);
            this.dgvWallet.Leave += new System.EventHandler(this.dgvWallet_Leave);
            // 
            // lbUnconfirmed
            // 
            this.lbUnconfirmed.AutoSize = true;
            this.lbUnconfirmed.Location = new System.Drawing.Point(68, 260);
            this.lbUnconfirmed.Name = "lbUnconfirmed";
            this.lbUnconfirmed.Size = new System.Drawing.Size(92, 13);
            this.lbUnconfirmed.TabIndex = 14;
            this.lbUnconfirmed.Text = "Pool unconfirmed:";
            // 
            // lbConfirmed
            // 
            this.lbConfirmed.AutoSize = true;
            this.lbConfirmed.Location = new System.Drawing.Point(68, 238);
            this.lbConfirmed.Name = "lbConfirmed";
            this.lbConfirmed.Size = new System.Drawing.Size(80, 13);
            this.lbConfirmed.TabIndex = 13;
            this.lbConfirmed.Text = "Pool confirmed:";
            // 
            // poolTimer
            // 
            this.poolTimer.Interval = 1000;
            this.poolTimer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(305, 27);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 29);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(224, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ofdWallet
            // 
            this.ofdWallet.Filter = "Dogecoin wallet|*.csv";
            // 
            // exchangeTimer
            // 
            this.exchangeTimer.Interval = 3600000;
            this.exchangeTimer.Tick += new System.EventHandler(this.exchangeTimer_Tick);
            // 
            // gbxTransactions
            // 
            this.gbxTransactions.Controls.Add(this.chart1);
            this.gbxTransactions.Controls.Add(this.varMax);
            this.gbxTransactions.Controls.Add(this.varMin);
            this.gbxTransactions.Controls.Add(this.varAvg);
            this.gbxTransactions.Controls.Add(this.varTotalFees);
            this.gbxTransactions.Controls.Add(this.varTotalMined);
            this.gbxTransactions.Controls.Add(this.lbTotalFees);
            this.gbxTransactions.Controls.Add(this.lbMaxBlock);
            this.gbxTransactions.Controls.Add(this.lbMinBlock);
            this.gbxTransactions.Controls.Add(this.lbAvgBlock);
            this.gbxTransactions.Controls.Add(this.lbTotalMined);
            this.gbxTransactions.Location = new System.Drawing.Point(12, 406);
            this.gbxTransactions.Name = "gbxTransactions";
            this.gbxTransactions.Size = new System.Drawing.Size(754, 104);
            this.gbxTransactions.TabIndex = 24;
            this.gbxTransactions.TabStop = false;
            this.gbxTransactions.Text = "Transactions:";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(386, 19);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(362, 79);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart";
            // 
            // varMax
            // 
            this.varMax.Location = new System.Drawing.Point(307, 76);
            this.varMax.Name = "varMax";
            this.varMax.Size = new System.Drawing.Size(61, 13);
            this.varMax.TabIndex = 27;
            this.varMax.Text = "N/A";
            this.varMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varMin
            // 
            this.varMin.Location = new System.Drawing.Point(303, 52);
            this.varMin.Name = "varMin";
            this.varMin.Size = new System.Drawing.Size(65, 13);
            this.varMin.TabIndex = 26;
            this.varMin.Text = "N/A";
            this.varMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varAvg
            // 
            this.varAvg.Location = new System.Drawing.Point(303, 28);
            this.varAvg.Name = "varAvg";
            this.varAvg.Size = new System.Drawing.Size(65, 13);
            this.varAvg.TabIndex = 25;
            this.varAvg.Text = "N/A";
            this.varAvg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varTotalFees
            // 
            this.varTotalFees.Location = new System.Drawing.Point(71, 52);
            this.varTotalFees.Name = "varTotalFees";
            this.varTotalFees.Size = new System.Drawing.Size(99, 13);
            this.varTotalFees.TabIndex = 24;
            this.varTotalFees.Text = "N/A";
            this.varTotalFees.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // varTotalMined
            // 
            this.varTotalMined.Location = new System.Drawing.Point(71, 28);
            this.varTotalMined.Name = "varTotalMined";
            this.varTotalMined.Size = new System.Drawing.Size(99, 13);
            this.varTotalMined.TabIndex = 19;
            this.varTotalMined.Text = "N/A";
            this.varTotalMined.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Location = new System.Drawing.Point(6, 52);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(57, 13);
            this.lbTotalFees.TabIndex = 23;
            this.lbTotalFees.Text = "Total fees:";
            // 
            // lbMaxBlock
            // 
            this.lbMaxBlock.AutoSize = true;
            this.lbMaxBlock.Location = new System.Drawing.Point(200, 76);
            this.lbMaxBlock.Name = "lbMaxBlock";
            this.lbMaxBlock.Size = new System.Drawing.Size(101, 13);
            this.lbMaxBlock.TabIndex = 22;
            this.lbMaxBlock.Text = "Maximum per block:";
            // 
            // lbMinBlock
            // 
            this.lbMinBlock.AutoSize = true;
            this.lbMinBlock.Location = new System.Drawing.Point(199, 52);
            this.lbMinBlock.Name = "lbMinBlock";
            this.lbMinBlock.Size = new System.Drawing.Size(98, 13);
            this.lbMinBlock.TabIndex = 21;
            this.lbMinBlock.Text = "Minimum per block:";
            // 
            // lbAvgBlock
            // 
            this.lbAvgBlock.AutoSize = true;
            this.lbAvgBlock.Location = new System.Drawing.Point(200, 28);
            this.lbAvgBlock.Name = "lbAvgBlock";
            this.lbAvgBlock.Size = new System.Drawing.Size(97, 13);
            this.lbAvgBlock.TabIndex = 20;
            this.lbAvgBlock.Text = "Average per block:";
            // 
            // lbTotalMined
            // 
            this.lbTotalMined.AutoSize = true;
            this.lbTotalMined.Location = new System.Drawing.Point(3, 28);
            this.lbTotalMined.Name = "lbTotalMined";
            this.lbTotalMined.Size = new System.Drawing.Size(65, 13);
            this.lbTotalMined.TabIndex = 19;
            this.lbTotalMined.Text = "Total mined:";
            // 
            // bgwExchange
            // 
            this.bgwExchange.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExchange_DoWork);
            this.bgwExchange.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExchange_RunWorkerCompleted);
            // 
            // bgwWallet
            // 
            this.bgwWallet.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWallet_DoWork);
            this.bgwWallet.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwWallet_RunWorkerCompleted);
            // 
            // bgwPool
            // 
            this.bgwPool.WorkerReportsProgress = true;
            this.bgwPool.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwPool_DoWork);
            this.bgwPool.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwPool_ProgressChanged);
            this.bgwPool.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwPool_RunWorkerCompleted);
            // 
            // bgwWrite
            // 
            this.bgwWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWrite_DoWork);
            this.bgwWrite.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwWrite_RunWorkerCompleted);
            // 
            // bgwRead
            // 
            this.bgwRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRead_DoWork);
            this.bgwRead.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRead_RunWorkerCompleted);
            // 
            // MoonStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 539);
            this.Controls.Add(this.gbxTransactions);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxBalance);
            this.Controls.Add(this.gbxNetwork);
            this.Controls.Add(this.gbxWorkers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MoonStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoonStats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoonStats_FormClosing);
            this.Load += new System.EventHandler(this.MoonStats_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbxWorkers.ResumeLayout(false);
            this.gbxWorkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.gbxNetwork.ResumeLayout(false);
            this.gbxNetwork.PerformLayout();
            this.gbxBalance.ResumeLayout(false);
            this.gbxBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallet)).EndInit();
            this.gbxTransactions.ResumeLayout(false);
            this.gbxTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbSeparator;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbxWorkers;
        private System.Windows.Forms.Label lbValid;
        private System.Windows.Forms.Label lbInvalid;
        private System.Windows.Forms.Label lbHashrate;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.GroupBox gbxNetwork;
        private System.Windows.Forms.Label lbTimeTo;
        private System.Windows.Forms.Label lbTimeSince;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.Label lbBlock;
        private System.Windows.Forms.Label lbPoolHashrate;
        private System.Windows.Forms.Label lbNetworkHashrate;
        private System.Windows.Forms.GroupBox gbxBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHashrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDifficulty;
        private System.Windows.Forms.DataGridView dgvWallet;
        private System.Windows.Forms.Label lbUnconfirmed;
        private System.Windows.Forms.Label lbConfirmed;
        private System.Windows.Forms.Timer poolTimer;
        private System.Windows.Forms.Label varBlock;
        private System.Windows.Forms.Label varDifficulty;
        private System.Windows.Forms.Label varTimeTo;
        private System.Windows.Forms.Label varTimeSince;
        private System.Windows.Forms.Label varPoolHashrate;
        private System.Windows.Forms.Label varNetworkHashrate;
        private System.Windows.Forms.Label varValid;
        private System.Windows.Forms.Label varInvalid;
        private System.Windows.Forms.Label varUserHashrate;
        private System.Windows.Forms.Label varUnconfirmed;
        private System.Windows.Forms.Label varConfirmed;
        private System.Windows.Forms.Label varUserSharerate;
        private System.Windows.Forms.Label lbSharerate;
        private System.Windows.Forms.ToolStripStatusLabel lbDogeToUsd;
        private System.Windows.Forms.Label varUsd;
        private System.Windows.Forms.Label lbUsd;
        private System.Windows.Forms.Label varDoge;
        private System.Windows.Forms.Label lbDoges;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cbxPools;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWalletToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdWallet;
        private System.Windows.Forms.Timer exchangeTimer;
        private System.Windows.Forms.GroupBox gbxTransactions;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label lbMaxBlock;
        private System.Windows.Forms.Label lbMinBlock;
        private System.Windows.Forms.Label lbAvgBlock;
        private System.Windows.Forms.Label lbTotalMined;
        private System.Windows.Forms.Label varMax;
        private System.Windows.Forms.Label varMin;
        private System.Windows.Forms.Label varAvg;
        private System.Windows.Forms.Label varTotalFees;
        private System.Windows.Forms.Label varTotalMined;
        private System.ComponentModel.BackgroundWorker bgwExchange;
        private System.ComponentModel.BackgroundWorker bgwWallet;
        private System.ComponentModel.BackgroundWorker bgwPool;
        private System.ComponentModel.BackgroundWorker bgwWrite;
        private System.ComponentModel.BackgroundWorker bgwRead;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}