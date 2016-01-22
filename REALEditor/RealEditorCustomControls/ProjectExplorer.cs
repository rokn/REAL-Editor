using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RealEditor.Common;

namespace RealEditorCustomControls
{
	public sealed partial class ProjectExplorer : TreeView
	{
		internal ProjectExplorer()
		{
			InitializeComponent();
			ForeColor = Configuration.DefaultTextColor;
			BackColor = Configuration.DefaultMenuBackgroundColor;
			this.HideSelection = true;
			this.DrawMode = TreeViewDrawMode.OwnerDrawText;
			this.DrawNode += OnDrawNode;
		}

		private void OnDrawNode(object sender, DrawTreeNodeEventArgs e)
		{
			if ((e.State & TreeNodeStates.Selected) != 0)
			{

				var backColor = ((e.State & TreeNodeStates.Focused) != 0) ? Configuration.DefaultFocusedColor : BackColor ;

				e.Graphics.FillRectangle(new SolidBrush(backColor), NodeBounds(e.Node));

				// Retrieve the node font. If the node font has not been set,
				// use the TreeView font.
				var nodeFont = e.Node.NodeFont ?? ((TreeView) sender).Font;

				// Draw the node text.
				e.Graphics.DrawString(e.Node.Text, nodeFont, new SolidBrush(ForeColor),
					Rectangle.Inflate(e.Bounds, 2, 0));
			}
			else
			{
				e.DrawDefault = true;
			}

//			if ((e.State & TreeNodeStates.Focused) == 0) return;
//
//			using(var focusBrush = new SolidBrush(Configuration.DefaultFocusedColor))
//			{
//				focusBrush.Color = Color.FromArgb(100, focusBrush.Color.R, focusBrush.Color.G, focusBrush.Color.B);
//				var focusBounds = NodeBounds(e.Node);
//				focusBounds.Size = new Size(focusBounds.Width - 1,
//					focusBounds.Height - 1);
////				e.Graphics.DrawRectangle(focusPen, focusBounds);
//				e.Graphics.FillRectangle(focusBrush,focusBounds);
//			}
		}

		public void ShowProjectFolder(DirectoryInfo dirInfo)
		{
			if(!dirInfo.Exists)
				throw new DirectoryNotFoundException();
			this.Nodes.Clear();
			AddFolder(null,dirInfo);
		}

		public void AddFolder(TreeNode attachTo, DirectoryInfo dirInfo)
		{
			var nodeCollection = attachTo?.Nodes ?? Nodes;

			foreach(var directoryInfo in dirInfo.GetDirectories())
			{
				var newNode = new TreeNode(directoryInfo.Name);

				nodeCollection.Add(newNode);
				AddFolder(newNode, directoryInfo);
			}

			foreach (var fileInfo in dirInfo.GetFiles())
			{
				nodeCollection.Add(new TreeNode(fileInfo.Name));
			}
		}

		private Rectangle NodeBounds(TreeNode node)
		{
			// Set the return value to the normal node bounds.
			var bounds = node.Bounds;
			if (node.Tag == null) return bounds;
			// Retrieve a Graphics object from the TreeView handle
			// and use it to calculate the display width of the tag.
			var g = FindForm()?.CreateGraphics();
			var tagWidth = (int)g.MeasureString
				(node.Tag.ToString(), Font).Width + 6;

			// Adjust the node bounds using the calculated value.
			bounds.Offset(tagWidth / 2, 0);
			bounds = Rectangle.Inflate(bounds, tagWidth / 2, 0);
			g.Dispose();

			return bounds;

		}
	}
}
