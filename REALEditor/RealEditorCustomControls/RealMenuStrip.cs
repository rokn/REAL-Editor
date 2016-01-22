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
			this.BackColor = Configuration.DefaultMenuBackgroundColor;
			this.ForeColor = Configuration.DefaultTextColor;
			this.Renderer = new MyRenderer(new RealColorTable());
			ItemAdded += OnItemAdded;
		}

		private void OnItemAdded(object sender, ToolStripItemEventArgs e)
		{
			e.Item.ForeColor = Configuration.DefaultTextColor;
			e.Item.BackColor = Configuration.DefaultMenuBackgroundColor;
		}
	}
}
