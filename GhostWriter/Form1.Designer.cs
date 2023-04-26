namespace GhostWriter
{
    partial class frmGhostWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGhostWriter));
            this.tmrElapsedTime = new System.Windows.Forms.Timer(this.components);
            this.TemporaryText = new System.Windows.Forms.TextBox();
            this.TopLineMenu = new System.Windows.Forms.MenuStrip();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopLineMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrElapsedTime
            // 
            this.tmrElapsedTime.Interval = 1000;
            // 
            // TemporaryText
            // 
            this.TemporaryText.AcceptsReturn = true;
            this.TemporaryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemporaryText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemporaryText.Location = new System.Drawing.Point(0, 33);
            this.TemporaryText.Multiline = true;
            this.TemporaryText.Name = "TemporaryText";
            this.TemporaryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TemporaryText.Size = new System.Drawing.Size(800, 417);
            this.TemporaryText.TabIndex = 0;
            this.TemporaryText.TextChanged += new System.EventHandler(this.TemporaryText_TextChanged);
            // 
            // TopLineMenu
            // 
            this.TopLineMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLineMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuClear});
            this.TopLineMenu.Location = new System.Drawing.Point(0, 0);
            this.TopLineMenu.Name = "TopLineMenu";
            this.TopLineMenu.ShowItemToolTips = true;
            this.TopLineMenu.Size = new System.Drawing.Size(800, 33);
            this.TopLineMenu.TabIndex = 1;
            this.TopLineMenu.Text = "menuStrip1";
            // 
            // mnuClear
            // 
            this.mnuClear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClearAllText});
            this.mnuClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuClear.Size = new System.Drawing.Size(68, 29);
            this.mnuClear.Text = "Clear";
            this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // mnuClearAllText
            // 
            this.mnuClearAllText.Name = "mnuClearAllText";
            this.mnuClearAllText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuClearAllText.Size = new System.Drawing.Size(211, 30);
            this.mnuClearAllText.Text = "All Text";
            this.mnuClearAllText.Click += new System.EventHandler(this.mnuClearAllText_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.optionsToolStripMenuItem.Text = "Options...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(231, 30);
            this.toolStripMenuItem2.Text = "-";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmGhostWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TemporaryText);
            this.Controls.Add(this.TopLineMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TopLineMenu;
            this.Name = "frmGhostWriter";
            this.Text = "GhostWriter";
            this.TopLineMenu.ResumeLayout(false);
            this.TopLineMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrElapsedTime;
        private System.Windows.Forms.TextBox TemporaryText;
        private System.Windows.Forms.MenuStrip TopLineMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
        private System.Windows.Forms.ToolStripMenuItem mnuClearAllText;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

