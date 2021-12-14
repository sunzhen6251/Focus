namespace Focus
{
    partial class FocusMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FocusMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pause = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.LabCurrentProcess = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabTodayProcess = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LabStat = new System.Windows.Forms.Label();
            this.tic = new System.Windows.Forms.Timer(this.components);
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pause);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.LabCurrentProcess);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(645, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current";
            // 
            // Pause
            // 
            this.Pause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pause.Location = new System.Drawing.Point(595, 28);
            this.Pause.Margin = new System.Windows.Forms.Padding(4);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(39, 31);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "■";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Start
            // 
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(548, 28);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(39, 31);
            this.Start.TabIndex = 1;
            this.Start.Text = ">";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // LabCurrentProcess
            // 
            this.LabCurrentProcess.AutoSize = true;
            this.LabCurrentProcess.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LabCurrentProcess.Location = new System.Drawing.Point(25, 35);
            this.LabCurrentProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabCurrentProcess.Name = "LabCurrentProcess";
            this.LabCurrentProcess.Size = new System.Drawing.Size(439, 15);
            this.LabCurrentProcess.TabIndex = 0;
            this.LabCurrentProcess.Text = "||>>>>>>>>>>>>>>>>>>>>>>>>>>                        ||";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabTodayProcess);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(16, 94);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(645, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Today";
            // 
            // LabTodayProcess
            // 
            this.LabTodayProcess.AutoSize = true;
            this.LabTodayProcess.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LabTodayProcess.Location = new System.Drawing.Point(25, 28);
            this.LabTodayProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabTodayProcess.Name = "LabTodayProcess";
            this.LabTodayProcess.Size = new System.Drawing.Size(447, 15);
            this.LabTodayProcess.TabIndex = 0;
            this.LabTodayProcess.Text = "||>>>>>>>>>>>>>>>>>>>>>>>>>>>                        ||";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LabStat);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(16, 324);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(645, 42);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "statistic";
            // 
            // LabStat
            // 
            this.LabStat.AutoSize = true;
            this.LabStat.Location = new System.Drawing.Point(169, 21);
            this.LabStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabStat.Name = "LabStat";
            this.LabStat.Size = new System.Drawing.Size(302, 15);
            this.LabStat.TabIndex = 0;
            this.LabStat.Text = "TotalTime:  ##:##        Complete：##";
            // 
            // tic
            // 
            this.tic.Interval = 1000;
            this.tic.Tick += new System.EventHandler(this.tic_Tick);
            // 
            // Notify
            // 
            this.Notify.ContextMenuStrip = this.NotifyMenu;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Notify";
            this.Notify.Visible = true;
            this.Notify.DoubleClick += new System.EventHandler(this.Notify_DoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(105, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FocusMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(677, 381);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FocusMain";
            this.Text = "Focus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FocusMain_FormClosing);
            this.Load += new System.EventHandler(this.FocusMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabCurrentProcess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabTodayProcess;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label LabStat;
        private System.Windows.Forms.Timer tic;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

