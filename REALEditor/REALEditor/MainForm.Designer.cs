using System.Windows.Forms;

namespace REALEditor
{
	partial class MainWindow
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
			if(disposing && (components != null))
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
			this.AltMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileStripNewProject = new System.Windows.Forms.ToolStripMenuItem();
			this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileStripExit = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sorryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AltMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// AltMenu
			// 
			this.AltMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.AltMenu.Location = new System.Drawing.Point(0, 0);
			this.AltMenu.Name = "AltMenu";
			this.AltMenu.Size = new System.Drawing.Size(620, 24);
			this.AltMenu.TabIndex = 0;
			this.AltMenu.Text = "AltMenu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripNewProject,
            this.openProjectToolStripMenuItem,
            this.fileStripExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// fileStripNewProject
			// 
			this.fileStripNewProject.Name = "fileStripNewProject";
			this.fileStripNewProject.Size = new System.Drawing.Size(143, 22);
			this.fileStripNewProject.Text = "New Project";
			this.fileStripNewProject.Click += new System.EventHandler(this.fileStripNewProject_Click);
			// 
			// openProjectToolStripMenuItem
			// 
			this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
			this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.openProjectToolStripMenuItem.Text = "Open Project";
			// 
			// fileStripExit
			// 
			this.fileStripExit.Name = "fileStripExit";
			this.fileStripExit.Size = new System.Drawing.Size(143, 22);
			this.fileStripExit.Text = "Exit";
			this.fileStripExit.Click += new System.EventHandler(this.fileStripExit_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorryToolStripMenuItem,
            this.noToolStripMenuItem,
            this.helpToolStripMenuItem1});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// sorryToolStripMenuItem
			// 
			this.sorryToolStripMenuItem.Name = "sorryToolStripMenuItem";
			this.sorryToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.sorryToolStripMenuItem.Text = "Sorry";
			// 
			// noToolStripMenuItem
			// 
			this.noToolStripMenuItem.Name = "noToolStripMenuItem";
			this.noToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.noToolStripMenuItem.Text = "No";
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
			this.helpToolStripMenuItem1.Text = "Help";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.ClientSize = new System.Drawing.Size(620, 454);
			this.Controls.Add(this.AltMenu);
			this.MainMenuStrip = this.AltMenu;
			this.Name = "MainWindow";
			this.Text = "REALEditor";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.AltMenu.ResumeLayout(false);
			this.AltMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip AltMenu;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem fileStripNewProject;
		private ToolStripMenuItem openProjectToolStripMenuItem;
		private ToolStripMenuItem fileStripExit;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem sorryToolStripMenuItem;
		private ToolStripMenuItem noToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem1;
		private ContextMenuStrip contextMenuStrip1;
	}
}

