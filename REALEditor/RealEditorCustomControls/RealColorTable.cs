using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RealEditor.Common;

namespace RealEditorCustomControls
{
	public class RealColorTable : ProfessionalColorTable
	{
		public override Color MenuItemSelected => Configuration.DefaultFocusedColor;

		public override Color MenuBorder => Configuration.DefaultFocusedColor;

		
	}

	public class MyRenderer : ToolStripProfessionalRenderer
	{
		public MyRenderer(ProfessionalColorTable colorTable)
			: base(colorTable)
		{}

//		protected override 

		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
			if (!e.Item.Selected)
			{
				Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
				e.Graphics.FillRectangle(new SolidBrush(Configuration.DefaultMenuBackgroundColor), rc);
			}
			else
			{
				Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
				e.Graphics.FillRectangle(new SolidBrush(Configuration.DefaultFocusedColor), rc);
			}
		}

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			
		}

		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			foreach (ToolStripMenuItem menuItem in e.ToolStrip.Items)
			{
				((ToolStripDropDownMenu) menuItem.DropDown).ShowImageMargin = false;
				menuItem.ForeColor = Configuration.DefaultTextColor;
			}
			Rectangle rc = new Rectangle(Point.Empty, e.ToolStrip.Size);
			e.Graphics.FillRectangle(new SolidBrush(Configuration.DefaultMenuBackgroundColor), rc);
		}
	}
}
