using System;
using System.Windows.Forms;
using RealEditor.Common;

namespace REALEditor
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
//			LinearGradientBrush linGrBrush = new LinearGradientBrush(
//			   new Point(0, 0),
//			   new Point(0, BorderSize),
//			   Color.FromArgb(0, 0, 0, 0),   // Opaque red
//			   Color.FromArgb(255, 80, 80, 255));
//			Brush borderColor = new SolidBrush(Color.FromArgb(255, 80,80,255));
//			e.Graphics.FillRectangle(linGrBrush, TopBorder);
//			e.Graphics.FillRectangle(borderColor, LeftBorder);
//			e.Graphics.FillRectangle(borderColor, RightBorder);
//			e.Graphics.FillRectangle(borderColor, BottomBorder);
		}

		private void MainWindow_Load(object sender, System.EventArgs e)
		{
			this.BackColor = Configuration.DefaultFormBackgroundColor;
		}

		private void AltMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void fileStripNewProject_Click(object sender, EventArgs e)
		{
			OpenNewProjectForm();
		}

		private void OpenNewProjectForm()
		{
			var newProject = new NewProjectForm();
			newProject.ShowDialog();
		}

		private void fileStripExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

}
