using System.Drawing;
using System.Windows.Forms;
using RealEditor.Common;

namespace RealEditorCustomControls
{
	public partial class RealTextBox : Panel
	{
		private const int SidePadding = 3;
		private readonly TextBox _textBox;

		public RealTextBox()
		{
			InitializeComponent();

			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

			BackColor = Configuration.DefaultMenuBackgroundColor;
			ForeColor = Configuration.DefaultTextColor;
			BorderStyle = BorderStyle.None;

			_textBox = new TextBox
			{
				AutoSize = false,
				BorderStyle = BorderStyle.None,
				Location = new Point(SidePadding, SidePadding),
				ForeColor = this.ForeColor,
				BackColor = this.BackColor
			};

			_textBox.GotFocus +=
				(s, e) => BackColor = Configuration.DefaultFocusedColor;
			_textBox.LostFocus +=
				(s, e) => BackColor = Configuration.DefaultMenuBackgroundColor;

			Controls.Add(_textBox);

			_textBox.Paint += (s, e) => OnPaint(e);


			Resize += RealTextBox_Resize;
		}


		private void RealTextBox_Resize(object sender, System.EventArgs e)
		{
			_textBox.Width = Width - SidePadding * 2;
			_textBox.Height = Height - SidePadding * 2;
		}

		public override string Text
		{
			get { return _textBox?.Text; }
			set
			{
				if (_textBox != null)
					_textBox.Text = value;
			}
		}

		public override sealed Color ForeColor
		{
			get { return base.ForeColor; }
			set
			{
				base.ForeColor = value;
				if(_textBox != null)
					_textBox.ForeColor = value;
			}
		}

		public override sealed Color BackColor
		{
			get { return base.BackColor; }
			set
			{
				base.BackColor = value;
				if (_textBox != null)
					_textBox.BackColor = BackColor;
			}
		}

		public override sealed bool AutoSize
		{
			get { return base.AutoSize; }
			set { base.AutoSize = value; }
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			var penBorder = _textBox.Focused ? new Pen(Configuration.DefaultBorderColor, 1) : new Pen(Color.Transparent, 1);

			var rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);

			e.Graphics.DrawRectangle(penBorder, rectBorder);

			var textRec = new Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);

			TextRenderer.DrawText(e.Graphics, Text, Font, textRec, ForeColor, BackColor, TextFormatFlags.Default);
		}
	}
}
