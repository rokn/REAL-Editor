using System.Windows.Forms;
using XnaEmbededControls;

namespace RealEditorCustomControls
{
	public partial class EditorPanel : RealPanelBase
	{
		public EditorViewControl EditorControl { get; private set; }

		public EditorPanel()
		{
			InitializeComponent();
			EditorControl = new EditorViewControl {Dock = DockStyle.Fill};
			Controls.Add(EditorControl);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
	}
}
