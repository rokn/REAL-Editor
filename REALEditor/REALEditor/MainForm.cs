using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using RealEditor.Common;
using RealEditorCustomControls;
using REALEditor.Properties;
using REALCore;

namespace REALEditor
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			projectExplorerPanel1.ProjectExplorer.ShowProjectFolder(new DirectoryInfo(@"F:\Games\BioShock Infinite"));
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

		private void ExitMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void RunGameMenuItemClick(object sender, EventArgs e)
		{
			RunGame();
		}

		private void RunGame()
		{
			var realGame = new REALGame(800,480,false);
			var gameThread = new Thread(() => realGame.Run());
			gameThread.Start();
		}
	}

}
