using System.Windows.Forms;

namespace RealEditorCustomControls
{
	public partial class ProjectExplorerPanel : RealPanelBase
	{
		public ProjectExplorer ProjectExplorer { get; private set; }

		public ProjectExplorerPanel()
		{
			InitializeComponent();
			ProjectExplorer = new ProjectExplorer {Dock = DockStyle.Fill};
			Controls.Add(ProjectExplorer);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
	}
}
