using System.Windows.Forms;
using XnaEmbededControls;

namespace RealEditorCustomControls
{
	public partial class EditorPanel : Panel
	{
		public EditorViewControl EditorControl { get; private set; }

		public EditorPanel()
		{
			InitializeComponent();
			this.DockPadding.All = 5;
			EditorControl = new EditorViewControl {Dock = DockStyle.Fill};
			Controls.Add(EditorControl);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
	}
}
