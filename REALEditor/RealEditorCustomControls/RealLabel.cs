using System.Drawing;
using System.Windows.Forms;
using RealEditor.Common;

namespace RealEditorCustomControls
{
	public partial class RealLabel : Label
	{
		public RealLabel()
		{
			InitializeComponent();
			this.ForeColor = Configuration.DefaultTextColor;
		}
	}
}
