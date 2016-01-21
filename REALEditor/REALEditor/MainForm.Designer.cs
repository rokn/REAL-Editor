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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._realMenu1 = new RealEditorCustomControls.RealMenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this._realMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(620, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem1,
            this.openProjectToolStripMenuItem,
            this.exitToolStripMenuItem1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newProjectToolStripMenuItem1
			// 
			this.newProjectToolStripMenuItem1.Name = "newProjectToolStripMenuItem1";
			this.newProjectToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
			this.newProjectToolStripMenuItem1.Text = "New Project";
			this.newProjectToolStripMenuItem1.Click += new System.EventHandler(this.NewProjectMenuItemClick);
			// 
			// openProjectToolStripMenuItem
			// 
			this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
			this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.openProjectToolStripMenuItem.Text = "Open Project";
			this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectMenuItemClick);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
			this.exitToolStripMenuItem1.Text = "Exit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// _realMenu1
			// 
			this._realMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this._realMenu1.ForeColor = System.Drawing.Color.White;
			this._realMenu1.GripMargin = new System.Windows.Forms.Padding(2);
			this._realMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem2});
			this._realMenu1.Location = new System.Drawing.Point(0, 0);
			this._realMenu1.Name = "_realMenu1";
			this._realMenu1.Size = new System.Drawing.Size(100, 48);
			this._realMenu1.TabIndex = 0;
			this._realMenu1.Text = "_realMenu1";
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 44);
			this.fileToolStripMenuItem1.Text = "File";
			// 
			// newProjectToolStripMenuItem
			// 
			this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
			this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.newProjectToolStripMenuItem.Text = "New Project";
			// 
			// openProjectToolStripMenuItem1
			// 
			this.openProjectToolStripMenuItem1.Name = "openProjectToolStripMenuItem1";
			this.openProjectToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
			this.openProjectToolStripMenuItem1.Text = "Open Project";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// helpToolStripMenuItem2
			// 
			this.helpToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.helpToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
			this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
			this.helpToolStripMenuItem2.Size = new System.Drawing.Size(44, 44);
			this.helpToolStripMenuItem2.Text = "Help";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runGameToolStripMenuItem});
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.runToolStripMenuItem.Text = "Run";
			// 
			// runGameToolStripMenuItem
			// 
			this.runGameToolStripMenuItem.Name = "runGameToolStripMenuItem";
			this.runGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.runGameToolStripMenuItem.Text = "Run Game";
			this.runGameToolStripMenuItem.Click += new System.EventHandler(this.RunGameMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.ClientSize = new System.Drawing.Size(620, 454);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "REALEditor";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this._realMenu1.ResumeLayout(false);
			this._realMenu1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private RealEditorCustomControls.RealMenuStrip _realMenu1;
		private ToolStripMenuItem fileToolStripMenuItem1;
		private ToolStripMenuItem helpToolStripMenuItem2;
		private ToolStripMenuItem newProjectToolStripMenuItem;
		private ToolStripMenuItem openProjectToolStripMenuItem1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newProjectToolStripMenuItem1;
		private ToolStripMenuItem openProjectToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem1;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem runToolStripMenuItem;
		private ToolStripMenuItem runGameToolStripMenuItem;
	}
}

