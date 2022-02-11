namespace Side_Forms
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShortcutToolStripMenuItem,
            this.removeShortcutToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(173, 48);
			// 
			// addShortcutToolStripMenuItem
			// 
			this.addShortcutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addShortcutToolStripMenuItem.Image")));
			this.addShortcutToolStripMenuItem.Name = "addShortcutToolStripMenuItem";
			this.addShortcutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.addShortcutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.addShortcutToolStripMenuItem.Text = "افزودن میانبر";
			this.addShortcutToolStripMenuItem.Click += new System.EventHandler(this.addShortcutToolStripMenuItem_Click);
			// 
			// removeShortcutToolStripMenuItem
			// 
			this.removeShortcutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeShortcutToolStripMenuItem.Image")));
			this.removeShortcutToolStripMenuItem.Name = "removeShortcutToolStripMenuItem";
			this.removeShortcutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.removeShortcutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.removeShortcutToolStripMenuItem.Text = "حذف میانبر";
			this.removeShortcutToolStripMenuItem.Visible = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 485);
			this.ContextMenuStrip = this.contextMenuStrip;
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form2";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "فرم شماره دوم";
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem addShortcutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeShortcutToolStripMenuItem;
	}
}