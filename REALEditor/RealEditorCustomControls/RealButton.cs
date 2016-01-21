
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using RealEditor.Common;

namespace RealEditorCustomControls
{
	public sealed partial class RealButton : Button
	{
		private readonly static Font NormalFont = new Font("Arial", 8F, FontStyle.Bold,
			GraphicsUnit.Point, (0));

		public RealButton()
		{
			Font = NormalFont;
			ForeColor = Configuration.DefaultTextColor;
			BackColor = Configuration.DefaultMenuBackgroundColor;
			FlatAppearance.BorderSize = 0;
			FlatStyle = FlatStyle.Flat;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (!Focused) return;

			var penBorder = new Pen(Color.CornflowerBlue, 1);

			var rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);

			e.Graphics.DrawRectangle(penBorder, rectBorder);
		}

		protected override bool ShowFocusCues => false;
	}
}
