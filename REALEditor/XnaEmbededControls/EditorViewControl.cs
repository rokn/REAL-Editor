using Microsoft.Xna.Framework;

namespace XnaEmbededControls
{
	public partial class EditorViewControl : GraphicsDeviceControl
	{
		public EditorViewControl()
		{
			InitializeComponent();
		}

		protected override void Initialize()
		{
		}

		protected override void Draw()
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);
		}
	}
}
