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
            this.toolTipThread = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxGB)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClientIDList
            // 
            this.txtClientIDList.Location = new System.Drawing.Point(14, 14);
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
            this.btnStart.Location = new System.Drawing.Point(14, 413);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(270, 27);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(14, 447);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(270, 27);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // numThreads
            // 
            this.numThreads.Location = new System.Drawing.Point(14, 355);
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(270, 23);
            this.numThreads.TabIndex = 4;
            this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipThread.SetToolTip(this.numThreads, "Thread Number");
            this.numThreads.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogs.Location = new System.Drawing.Point(14, 200);
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
            this.txtProxyPath.Location = new System.Drawing.Point(14, 170);
            this.txtProxyPath.Name = "txtProxyPath";
            this.txtProxyPath.ReadOnly = true;
            this.txtProxyPath.Size = new System.Drawing.Size(166, 23);
            this.txtProxyPath.TabIndex = 1;
            // 
            // btnLoadProxy
            // 
            this.btnLoadProxy.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadProxy.Image")));
            this.btnLoadProxy.Location = new System.Drawing.Point(186, 169);
            this.btnLoadProxy.Name = "btnLoadProxy";
            this.btnLoadProxy.Size = new System.Drawing.Size(98, 25);
            this.btnLoadProxy.TabIndex = 2;
            this.btnLoadProxy.Text = "Load Proxy";
            this.btnLoadProxy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadProxy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadProxy.UseVisualStyleBackColor = true;
            this.btnLoadProxy.Click += new System.EventHandler(this.btnLoadProxy_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 480);
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
            this.label7.Size = new System.Drawing.Size(36, 15);
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
            this.label5.Size = new System.Drawing.Size(35, 15);
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
            this.label3.Size = new System.Drawing.Size(33, 15);
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
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Earned";
            // 
            // numMaxGB
            // 
            this.numMaxGB.Location = new System.Drawing.Point(14, 384);
            this.numMaxGB.Name = "numMaxGB";
            this.numMaxGB.Size = new System.Drawing.Size(270, 23);
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
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 580);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(297, 22);
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "by James from J2TeaM";
            // 
            // toolTipThread
            // 
            this.toolTipThread.IsBalloon = true;
            this.toolTipThread.ToolTipTitle = "Notice";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 602);
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
    }
}

