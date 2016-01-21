using System;
using System.IO;
using System.Windows.Forms;
using RealEditor.Common;

namespace REALEditor
{
	public partial class NewProjectForm : Form
	{
		public NewProjectForm()
		{
			InitializeComponent();
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			BackColor = Configuration.DefaultFormBackgroundColor;
			browseDirButton.Click += browseDirButton_Click;
			headerPanel.SendToBack();
			headerPanel.BackColor = Configuration.DefaultMenuBackgroundColor;
			header.BackColor = Configuration.DefaultMenuBackgroundColor;
		}

		private void NewProjectForm_Load(object sender, EventArgs e)
		{
		}

		private void browseDirButton_Click(object sender, EventArgs e)
		{
			var dialog = new FolderBrowserDialog();
			dialog.ShowDialog();
			dirTextBox.Text = dialog.SelectedPath;
		}

		private void createProjectButton_Click(object sender, EventArgs e)
		{
			if (CreateProject(dirTextBox.Text, projectNameTextBox.Text))
			{
				this.Close();
			}
		}

		private bool CreateProject(string directory, string name)
		{
			if (!Directory.Exists(directory))
			{
				var dialogResult = MessageBox.Show("Directory : '"+directory+"' doesn't exist. Do you want to create it ?", "Directory doesn't exist", MessageBoxButtons.YesNo);

				if(dialogResult == DialogResult.Yes)
				{
					Directory.CreateDirectory(directory);
				}
				else if(dialogResult == DialogResult.No)
				{
					return false;
				}
			}

			return true;
		}
	}
}
