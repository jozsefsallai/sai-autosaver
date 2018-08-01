namespace sai_autosaver
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.SaveIntervalGroup = new System.Windows.Forms.GroupBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.currentInterval = new System.Windows.Forms.Label();
            this.CurrentIntervalLabel = new System.Windows.Forms.Label();
            this.intervalTrackbar = new System.Windows.Forms.TrackBar();
            this.Trigger = new System.Windows.Forms.Timer(this.components);
            this.Copyright = new System.Windows.Forms.Label();
            this.taskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.appContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSettingsMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckifOpen = new System.Windows.Forms.Timer(this.components);
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.SaveIntervalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackbar)).BeginInit();
            this.appContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveIntervalGroup
            // 
            this.SaveIntervalGroup.Controls.Add(this.applyButton);
            this.SaveIntervalGroup.Controls.Add(this.currentInterval);
            this.SaveIntervalGroup.Controls.Add(this.CurrentIntervalLabel);
            this.SaveIntervalGroup.Controls.Add(this.intervalTrackbar);
            this.SaveIntervalGroup.Location = new System.Drawing.Point(13, 13);
            this.SaveIntervalGroup.Name = "SaveIntervalGroup";
            this.SaveIntervalGroup.Size = new System.Drawing.Size(491, 100);
            this.SaveIntervalGroup.TabIndex = 0;
            this.SaveIntervalGroup.TabStop = false;
            this.SaveIntervalGroup.Text = "Save Interval";
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(410, 67);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // currentInterval
            // 
            this.currentInterval.AutoSize = true;
            this.currentInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentInterval.Location = new System.Drawing.Point(98, 72);
            this.currentInterval.Name = "currentInterval";
            this.currentInterval.Size = new System.Drawing.Size(19, 13);
            this.currentInterval.TabIndex = 1;
            this.currentInterval.Text = "...";
            this.currentInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentIntervalLabel
            // 
            this.CurrentIntervalLabel.AutoSize = true;
            this.CurrentIntervalLabel.Location = new System.Drawing.Point(7, 72);
            this.CurrentIntervalLabel.Name = "CurrentIntervalLabel";
            this.CurrentIntervalLabel.Size = new System.Drawing.Size(85, 13);
            this.CurrentIntervalLabel.TabIndex = 1;
            this.CurrentIntervalLabel.Text = "Current Interval: ";
            // 
            // intervalTrackbar
            // 
            this.intervalTrackbar.LargeChange = 3;
            this.intervalTrackbar.Location = new System.Drawing.Point(6, 20);
            this.intervalTrackbar.Maximum = 6;
            this.intervalTrackbar.Name = "intervalTrackbar";
            this.intervalTrackbar.Size = new System.Drawing.Size(479, 45);
            this.intervalTrackbar.TabIndex = 0;
            this.intervalTrackbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.intervalTrackbar.Value = 2;
            this.intervalTrackbar.Scroll += new System.EventHandler(this.intervalTrackbar_Scroll);
            // 
            // Trigger
            // 
            this.Trigger.Interval = 600000;
            this.Trigger.Tick += new System.EventHandler(this.Trigger_Tick);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Copyright.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Copyright.Location = new System.Drawing.Point(179, 116);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(292, 13);
            this.Copyright.TabIndex = 1;
            this.Copyright.Text = "This is an open-source tool. Contribute to its development on";
            // 
            // taskbarIcon
            // 
            this.taskbarIcon.ContextMenuStrip = this.appContextMenu;
            this.taskbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarIcon.Icon")));
            this.taskbarIcon.Text = "Sai Auto-saver";
            this.taskbarIcon.Visible = true;
            this.taskbarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskbarIcon_MouseDoubleClick);
            // 
            // appContextMenu
            // 
            this.appContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsMenuitem,
            this.closeToolStripMenuItem});
            this.appContextMenu.Name = "contextMenuStrip1";
            this.appContextMenu.Size = new System.Drawing.Size(154, 48);
            // 
            // openSettingsMenuitem
            // 
            this.openSettingsMenuitem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openSettingsMenuitem.Name = "openSettingsMenuitem";
            this.openSettingsMenuitem.Size = new System.Drawing.Size(153, 22);
            this.openSettingsMenuitem.Text = "Open Settings";
            this.openSettingsMenuitem.Click += new System.EventHandler(this.openSettingsMenuitem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // CheckifOpen
            // 
            this.CheckifOpen.Enabled = true;
            this.CheckifOpen.Interval = 10000;
            this.CheckifOpen.Tick += new System.EventHandler(this.CheckifOpen_Tick);
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(468, 116);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(40, 13);
            this.GithubLink.TabIndex = 2;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "GitHub";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 135);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.SaveIntervalGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintTool SAI Autosaver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsWindow_FormClosing);
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.Resize += new System.EventHandler(this.SettingsWindow_Resize);
            this.SaveIntervalGroup.ResumeLayout(false);
            this.SaveIntervalGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackbar)).EndInit();
            this.appContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SaveIntervalGroup;
        private System.Windows.Forms.TrackBar intervalTrackbar;
        private System.Windows.Forms.Label currentInterval;
        private System.Windows.Forms.Label CurrentIntervalLabel;
        private System.Windows.Forms.Timer Trigger;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.NotifyIcon taskbarIcon;
        private System.Windows.Forms.ContextMenuStrip appContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openSettingsMenuitem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer CheckifOpen;
        private System.Windows.Forms.LinkLabel GithubLink;
    }
}

