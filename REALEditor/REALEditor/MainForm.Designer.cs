using System.Windows.Forms;

namespace REALEditor
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
			this.realMenuStrip1 = new RealEditorCustomControls.RealMenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.realMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// realMenuStrip1
			// 
			this.realMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.realMenuStrip1.ForeColor = System.Drawing.Color.White;
			this.realMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.realMenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.realMenuStrip1.Name = "realMenuStrip1";
			this.realMenuStrip1.Size = new System.Drawing.Size(620, 24);
			this.realMenuStrip1.TabIndex = 0;
			this.realMenuStrip1.Text = "realMenuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.exitToolStripMenuItem1});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newProjectToolStripMenuItem
			// 
			this.newProjectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
			this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.newProjectToolStripMenuItem.Text = "New Project";
			this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectMenuItemClick);
			// 
			// openProjectToolStripMenuItem
			// 
			this.openProjectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
			this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.openProjectToolStripMenuItem.Text = "Open Project";
			this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectMenuItemClick);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
			this.exitToolStripMenuItem1.Text = "Exit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitMenuItemClick);
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.runToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.runToolStripMenuItem.Text = "Run";
			this.runToolStripMenuItem.Click += new System.EventHandler(this.RunGameMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.ClientSize = new System.Drawing.Size(620, 454);
			this.Controls.Add(this.realMenuStrip1);
			this.Name = "MainForm";
			this.Text = "REALEditor";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.realMenuStrip1.ResumeLayout(false);
			this.realMenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newProjectToolStripMenuItem;
		private ToolStripMenuItem openProjectToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem1;
		private ToolStripMenuItem runToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private RealEditorCustomControls.RealMenuStrip realMenuStrip1;
	}
}

