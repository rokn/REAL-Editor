using System;
using System.Windows.Forms;
using RealEditor.Common;

namespace REALEditor
{
	public partial class NewProjectForm : Form
	{
		public NewProjectForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void NewProjectForm_Load(object sender, EventArgs e)
		{
			this.BackColor = Configuration.DefaultFormBackgroundColor;
		}
	}
}
