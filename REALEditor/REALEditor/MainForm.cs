using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using RealEditor.Common;
using REALEditor.Properties;
using REALCore;
using REALProjectManagement;

namespace REALEditor
{
	public partial class MainForm : Form
	{
		private RealProject _openedProject;

		public MainForm()
		{
			InitializeComponent();

			this.Closing += MainForm_Closing;
		}

		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			AskForSave(e);
		}

		private void AskForSave(System.ComponentModel.CancelEventArgs e)
		{
			if(_openedProject == null || _openedProject.Saved)
				return;

			var dialogResult = MessageBox.Show("The project '" + _openedProject.Name + "' is not saved. Do you want to save it ?", "Project not saved", MessageBoxButtons.YesNoCancel);

			switch(dialogResult)
			{
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
				case DialogResult.Yes:
					_openedProject.Save();
					break;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
		}

		private void MainWindow_Load(object sender, System.EventArgs e)
		{
			this.BackColor = Configuration.DefaultFormBackgroundColor;
		}

		private void OpenNewProjectForm()
		{
			var newProject = new NewProjectForm();
			newProject.ShowDialog();

			if (newProject.CreatedProject != null)
				_openedProject = newProject.CreatedProject;

			projectExplorerPanel1.ProjectExplorer.OpenProject(_openedProject);
		}

		private void OpenProject(string filename)
		{
			if (string.IsNullOrEmpty(filename))
				return;

			CancelEventArgs cancelEvent = new CancelEventArgs {Cancel = false};
			AskForSave(cancelEvent);

			if (cancelEvent.Cancel)
				return;

			_openedProject = new RealProject("");

			if(_openedProject.Load(filename))
				projectExplorerPanel1.ProjectExplorer.OpenProject(_openedProject);
		}

		private void RunGame()
		{
			var realGame = new REALGame(800,480,false);
			var gameThread = new Thread(() => realGame.Run());
			gameThread.Start();
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
	}

}
