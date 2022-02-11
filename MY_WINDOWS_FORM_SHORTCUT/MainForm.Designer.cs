namespace MY_WINDOWS_FORM_SHORTCUT
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
			this.menuPanel = new System.Windows.Forms.Panel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.منویفرمهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shortcutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.removeShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPanel.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.SlateBlue;
			this.menuPanel.Controls.Add(this.menuStrip);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(800, 30);
			this.menuPanel.TabIndex = 4;
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuStrip.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.منویفرمهاToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip.Size = new System.Drawing.Size(800, 30);
			this.menuStrip.TabIndex = 4;
			this.menuStrip.Text = "menuStrip1";
			// 
			// منویفرمهاToolStripMenuItem
			// 
			this.منویفرمهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem,
            this.form4ToolStripMenuItem,
            this.form5ToolStripMenuItem});
			this.منویفرمهاToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.منویفرمهاToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("منویفرمهاToolStripMenuItem.Image")));
			this.منویفرمهاToolStripMenuItem.Name = "منویفرمهاToolStripMenuItem";
			this.منویفرمهاToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
			this.منویفرمهاToolStripMenuItem.Text = "منوی فرم ها";
			// 
			// form1ToolStripMenuItem
			// 
			this.form1ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.form1ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
			this.form1ToolStripMenuItem.RightToLeftAutoMirrorImage = true;
			this.form1ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.form1ToolStripMenuItem.Text = "فرم شماره یک";
			this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
			// 
			// form2ToolStripMenuItem
			// 
			this.form2ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.form2ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
			this.form2ToolStripMenuItem.RightToLeftAutoMirrorImage = true;
			this.form2ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.form2ToolStripMenuItem.Text = "فرم شماره دو";
			this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
			// 
			// form3ToolStripMenuItem
			// 
			this.form3ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.form3ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
			this.form3ToolStripMenuItem.RightToLeftAutoMirrorImage = true;
			this.form3ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.form3ToolStripMenuItem.Text = "فرم شماره سه";
			this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
			// 
			// form4ToolStripMenuItem
			// 
			this.form4ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.form4ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
			this.form4ToolStripMenuItem.RightToLeftAutoMirrorImage = true;
			this.form4ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.form4ToolStripMenuItem.Text = "فرم شماره چهار";
			this.form4ToolStripMenuItem.Click += new System.EventHandler(this.form4ToolStripMenuItem_Click);
			// 
			// form5ToolStripMenuItem
			// 
			this.form5ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.form5ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.form5ToolStripMenuItem.Name = "form5ToolStripMenuItem";
			this.form5ToolStripMenuItem.RightToLeftAutoMirrorImage = true;
			this.form5ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.form5ToolStripMenuItem.Text = "فرم شماره پنج";
			this.form5ToolStripMenuItem.Click += new System.EventHandler(this.form5ToolStripMenuItem_Click);
			// 
			// shortcutPanel
			// 
			this.shortcutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.shortcutPanel.Location = new System.Drawing.Point(0, 30);
			this.shortcutPanel.Name = "shortcutPanel";
			this.shortcutPanel.Size = new System.Drawing.Size(800, 36);
			this.shortcutPanel.TabIndex = 5;
			this.shortcutPanel.WrapContents = false;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeShortcutToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.contextMenuStrip.Size = new System.Drawing.Size(173, 26);
			// 
			// removeShortcutToolStripMenuItem
			// 
			this.removeShortcutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeShortcutToolStripMenuItem.Image")));
			this.removeShortcutToolStripMenuItem.Name = "removeShortcutToolStripMenuItem";
			this.removeShortcutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.removeShortcutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.removeShortcutToolStripMenuItem.Text = "حذف میانبر";
			this.removeShortcutToolStripMenuItem.Click += new System.EventHandler(this.removeShortcutToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.shortcutPanel);
			this.Controls.Add(this.menuPanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuPanel.ResumeLayout(false);
			this.menuPanel.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem منویفرمهاToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form5ToolStripMenuItem;
		private System.Windows.Forms.FlowLayoutPanel shortcutPanel;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem removeShortcutToolStripMenuItem;
	}
}

