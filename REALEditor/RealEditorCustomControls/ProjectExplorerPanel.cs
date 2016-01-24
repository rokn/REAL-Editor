using System;
using System.Drawing;
using System.Windows.Forms;
using RealEditor.Common;

namespace RealEditorCustomControls
{
	public sealed partial class ProjectExplorerPanel : RealPanelBase
	{
		public ProjectExplorer ProjectExplorer { get; private set; }

		private RealMenuStrip _menuStrip;
		private ToolStripMenuItem _importMenuItem;


		public ProjectExplorerPanel()
		{
			InitializeComponent();
			InitializeMenu();
			InitializeProjectExplorer();
			this.Resize += OnResize;
			this.MinimumSize = new Size(150, 200);
		}

		private void OnResize(object sender, System.EventArgs e)
		{
			ResizeProjectExplorer();
		}

		private void InitializeMenu()
		{
			_menuStrip = new RealMenuStrip();
			_importMenuItem = new ToolStripMenuItem("Import");
			_importMenuItem.Click += ImportMenuItem_Click;
			_menuStrip.Items.Add(_importMenuItem);
			_menuStrip.Dock = DockStyle.Top;
			Controls.Add(_menuStrip);
		}

		private void ImportMenuItem_Click(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog();
			fileDialog.ShowDialog();
			ProjectExplorer.ImportFile(fileDialog.FileName, "");
		}

		private void InitializeProjectExplorer()
		{
			ProjectExplorer = new ProjectExplorer { Dock = DockStyle.Bottom };
			ResizeProjectExplorer();
			ProjectExplorer.BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(ProjectExplorer);
		}

		private void ResizeProjectExplorer()
		{
			ProjectExplorer.Height = (Height - _menuStrip.Height) - this.Padding.Top * 2;
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
//			Point borderLineP1 = ProjectExplorer.Location;
//			Point borderLineP2 = new Point(borderLineP1.X + ProjectExplorer.Size.Width - 1, borderLineP1.Y);
//
//			pe.Graphics.DrawLine(new Pen(Configuration.DefaultFocusedColor), borderLineP1, borderLineP2 );
			base.OnPaint(pe);

		}
	}
}
