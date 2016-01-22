using System.Windows.Forms;

namespace RealEditorCustomControls
{
	public partial class RealPanelBase : Panel
	{
		protected RealPanelBase()
		{
			InitializeComponent();
			DockPadding.All = 5;
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
	}
}
