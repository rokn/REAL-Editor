using System.Drawing;
using System.Windows.Forms;
using RealEditor.Common;

namespace RealEditorCustomControls
{
	public partial class RealMenuStrip : MenuStrip
	{
		public RealMenuStrip()
		{
			InitializeComponent();
			BackColor = Configuration.DefaultMenuBackgroundColor;
			ForeColor = Configuration.DefaultTextColor;
			ItemAdded += OnItemAdded;
			Renderer = new ToolStripProfessionalRenderer(new RealColorTable());
		}

		private void OnItemAdded(object sender, ToolStripItemEventArgs e)
		{
			e.Item.ForeColor = Configuration.DefaultTextColor;
			e.Item.BackColor = Configuration.DefaultMenuBackgroundColor;
		}
	}
}
