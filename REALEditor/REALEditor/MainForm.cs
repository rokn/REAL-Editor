using System;
using System.Drawing;
using System.Windows.Forms;
using RealEditor.Common;
using RealEditorCustomControls;
using REALEditor.Properties;
using XnaEmbededControls;

namespace REALEditor
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
		}

		private void MainWindow_Load(object sender, System.EventArgs e)
		{
			this.BackColor = Configuration.DefaultFormBackgroundColor;
			menuStrip1.BackColor = Configuration.DefaultMenuBackgroundColor;
			menuStrip1.ForeColor = Configuration.DefaultTextColor;
			menuStrip1.Renderer = new MyRenderer(new RealColorTable());
		}

		private void OpenNewProjectForm()
		{
			var newProject = new NewProjectForm();
			newProject.ShowDialog();
		}

		private void OpenProject(string filename)
		{
			//TODO ProjectOpening
		}

		private void NewProjectMenuItemClick(object sender, EventArgs e)
		{
			OpenNewProjectForm();
		}

		private void OpenProjectMenuItemClick(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog { Filter = Resources.RealProjectFilter };
			fileDialog.ShowDialog();
			OpenProject(fileDialog.FileName);
		}

		private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

}
