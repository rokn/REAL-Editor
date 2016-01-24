using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using RealEditor.Common;
using RealEditorCustomControls.Properties;
using REALProjectManagement;

namespace RealEditorCustomControls
{
	public sealed partial class ProjectExplorer : TreeView
	{
		private RealProject _openedProject;

		internal ProjectExplorer()
		{
			InitializeComponent();
			ForeColor = Configuration.DefaultTextColor;
			BackColor = Configuration.DefaultMenuBackgroundColor;
			this.HideSelection = true;
			this.DrawMode = TreeViewDrawMode.OwnerDrawText;
			this.DrawNode += OnDrawNode;
			this.ImageIndex = 0;
			this.ImageList = new ImageList();
			this.ImageList.Images.Add(Resources.FolderIcon);
			this.ImageList.Images.Add(Resources.FileIcon);
			this.NodeMouseDoubleClick += ProjectExplorer_NodeMouseDoubleClick;
		}

		private void ProjectExplorer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (NodeIsFile(e.Node))
			{
				_openedProject?.OpenFile(new FileInfo(e.Node.FullPath));
			}
		}

		private bool NodeIsFile(TreeNode node)
		{
			return node.ImageIndex > 0;
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

		public void OpenProject(RealProject project)
		{
			_openedProject = project;
			if(_openedProject != null)
				RefreshFolder();
		}

		public void AddFolder(TreeNode attachTo, DirectoryInfo dirInfo)
		{
			if (_openedProject == null)
				return;

			var nodeCollection = attachTo?.Nodes ?? Nodes;

			foreach(var directoryInfo in dirInfo.GetDirectories())
			{
				var newNode = new TreeNode(directoryInfo.Name,0,0);

				nodeCollection.Add(newNode);
				AddFolder(newNode, directoryInfo);
			}

			foreach (var fileInfo in dirInfo.GetFiles()
				.Where(_openedProject.ContainsFile))
			{
				nodeCollection.Add(new TreeNode(fileInfo.Name,1,1));
			}
		}

		public void ImportFile(string filePath, string subfolder = "")
		{
			if (_openedProject == null) return;

			_openedProject.ImportFile(filePath, subfolder);
			RefreshFolder();
		}

		private void RefreshFolder()
		{
			this.Nodes.Clear();
			if(_openedProject?.ProjectPath != null)
				AddFolder(null, new DirectoryInfo(Path.GetDirectoryName(_openedProject.ProjectPath)));
		}

		private Rectangle NodeBounds(TreeNode node)
		{
			// Set the return value to the normal node bounds.
			var bounds = node.Bounds;
			if (node.Tag == null) return bounds;
			// Retrieve a Graphics object from the TreeView handle
			// and use it to calculate the display width of the tag.
			var g = FindForm()?.CreateGraphics();
			if (g != null)
			{
				var tagWidth = (int)g.MeasureString
					(node.Tag.ToString(), Font).Width + 6;

				// Adjust the node bounds using the calculated value.
				bounds.Offset(tagWidth / 2, 0);
				bounds = Rectangle.Inflate(bounds, tagWidth / 2, 0);
				g.Dispose();
			}

			return bounds;

		}
	}
}
