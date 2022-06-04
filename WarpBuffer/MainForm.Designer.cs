namespace WarpBuffer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtClientIDList = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.txtProxyPath = new System.Windows.Forms.TextBox();
            this.btnLoadProxy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotalProxy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalDoneClient = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEarned = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMaxGB = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipThread = new System.Windows.Forms.ToolTip(this.components);
            this.ch_GetProxylist = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProxyType = new System.Windows.Forms.ComboBox();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxGB)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientIDList
            // 
            this.txtClientIDList.Location = new System.Drawing.Point(12, 27);
            this.txtClientIDList.Multiline = true;
            this.txtClientIDList.Name = "txtClientIDList";
            this.txtClientIDList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClientIDList.Size = new System.Drawing.Size(270, 148);
            this.txtClientIDList.TabIndex = 0;
            this.toolTipThread.SetToolTip(this.txtClientIDList, "List of Client ID");
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(12, 313);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(270, 26);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(12, 345);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(270, 27);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // numThreads
            // 
            this.numThreads.Location = new System.Drawing.Point(291, 240);
            this.numThreads.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(270, 27);
            this.numThreads.TabIndex = 4;
            this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThreads.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogs.Location = new System.Drawing.Point(291, 27);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(270, 148);
            this.txtLogs.TabIndex = 3;
            // 
            // txtProxyPath
            // 
            this.txtProxyPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtProxyPath.Enabled = false;
            this.txtProxyPath.Location = new System.Drawing.Point(291, 196);
            this.txtProxyPath.Name = "txtProxyPath";
            this.txtProxyPath.ReadOnly = true;
            this.txtProxyPath.Size = new System.Drawing.Size(166, 27);
            this.txtProxyPath.TabIndex = 1;
            // 
            // btnLoadProxy
            // 
            this.btnLoadProxy.Enabled = false;
            this.btnLoadProxy.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadProxy.Image")));
            this.btnLoadProxy.Location = new System.Drawing.Point(463, 194);
            this.btnLoadProxy.Name = "btnLoadProxy";
            this.btnLoadProxy.Size = new System.Drawing.Size(98, 25);
            this.btnLoadProxy.TabIndex = 2;
            this.btnLoadProxy.Text = "Load Proxy";
            this.btnLoadProxy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadProxy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadProxy.UseVisualStyleBackColor = true;
            this.btnLoadProxy.Click += new System.EventHandler(this.BtnLoadProxy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalProxy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbTotalDoneClient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbTotalClient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbEarned);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(291, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // lbTotalProxy
            // 
            this.lbTotalProxy.Location = new System.Drawing.Point(98, 64);
            this.lbTotalProxy.Name = "lbTotalProxy";
            this.lbTotalProxy.Size = new System.Drawing.Size(166, 15);
            this.lbTotalProxy.TabIndex = 7;
            this.lbTotalProxy.Text = "0";
            this.lbTotalProxy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Proxy";
            // 
            // lbTotalDoneClient
            // 
            this.lbTotalDoneClient.Location = new System.Drawing.Point(98, 49);
            this.lbTotalDoneClient.Name = "lbTotalDoneClient";
            this.lbTotalDoneClient.Size = new System.Drawing.Size(166, 15);
            this.lbTotalDoneClient.TabIndex = 5;
            this.lbTotalDoneClient.Text = "0";
            this.lbTotalDoneClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Done";
            // 
            // lbTotalClient
            // 
            this.lbTotalClient.Location = new System.Drawing.Point(98, 34);
            this.lbTotalClient.Name = "lbTotalClient";
            this.lbTotalClient.Size = new System.Drawing.Size(166, 15);
            this.lbTotalClient.TabIndex = 3;
            this.lbTotalClient.Text = "0";
            this.lbTotalClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // lbEarned
            // 
            this.lbEarned.Location = new System.Drawing.Point(98, 19);
            this.lbEarned.Name = "lbEarned";
            this.lbEarned.Size = new System.Drawing.Size(166, 15);
            this.lbEarned.TabIndex = 1;
            this.lbEarned.Text = "0";
            this.lbEarned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Earned";
            // 
            // numMaxGB
            // 
            this.numMaxGB.Location = new System.Drawing.Point(12, 284);
            this.numMaxGB.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMaxGB.Name = "numMaxGB";
            this.numMaxGB.Size = new System.Drawing.Size(270, 27);
            this.numMaxGB.TabIndex = 5;
            this.numMaxGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipThread.SetToolTip(this.numMaxGB, "How many GB do you want to buff?");
            this.numMaxGB.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 383);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(573, 26);
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(327, 20);
            this.toolStripStatusLabel2.Text = "original by James from J2TeaM, remade by Hiep";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolTipThread
            // 
            this.toolTipThread.IsBalloon = true;
            this.toolTipThread.ToolTipTitle = "Notice";
            // 
            // ch_GetProxylist
            // 
            this.ch_GetProxylist.AutoSize = true;
            this.ch_GetProxylist.Checked = true;
            this.ch_GetProxylist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_GetProxylist.Location = new System.Drawing.Point(190, 177);
            this.ch_GetProxylist.Name = "ch_GetProxylist";
            this.ch_GetProxylist.Size = new System.Drawing.Size(113, 24);
            this.ch_GetProxylist.TabIndex = 19;
            this.ch_GetProxylist.Text = "Get Proxylist";
            this.toolTipThread.SetToolTip(this.ch_GetProxylist, "Get proxy list online from proxyscrape.com");
            this.ch_GetProxylist.UseVisualStyleBackColor = true;
            this.ch_GetProxylist.CheckedChanged += new System.EventHandler(this.ch_GetProxylist_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "List of Client ID";
            this.toolTipThread.SetToolTip(this.label2, "Go to Settings -> Diagnostics -> ID, fill your ID(s) below");
            // 
            // comboProxyType
            // 
            this.comboProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProxyType.FormattingEnabled = true;
            this.comboProxyType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS5",
            "SOCKS4"});
            this.comboProxyType.Location = new System.Drawing.Point(12, 196);
            this.comboProxyType.Name = "comboProxyType";
            this.comboProxyType.Size = new System.Drawing.Size(270, 28);
            this.comboProxyType.TabIndex = 10;
            this.comboProxyType.SelectedIndexChanged += new System.EventHandler(this.ComboProxyType_SelectedIndexChanged);
            // 
            // numTimeout
            // 
            this.numTimeout.Location = new System.Drawing.Point(12, 240);
            this.numTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(270, 27);
            this.numTimeout.TabIndex = 11;
            this.numTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTimeout.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Proxy File";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Logs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Proxy Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Connect Timeout";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Threads";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Max GB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 409);
            this.Controls.Add(this.ch_GetProxylist);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTimeout);
            this.Controls.Add(this.comboProxyType);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.numMaxGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadProxy);
            this.Controls.Add(this.txtProxyPath);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.numThreads);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtClientIDList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudFlare Warp+ Buffer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxGB)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientIDList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.TextBox txtProxyPath;
        private System.Windows.Forms.Button btnLoadProxy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEarned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalDoneClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalProxy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numMaxGB;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTipThread;
        private System.Windows.Forms.ComboBox comboProxyType;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ch_GetProxylist;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

