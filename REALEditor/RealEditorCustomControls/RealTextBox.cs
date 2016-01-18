using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEditor.Common;

namespace RealEditorCustomControls
{
	public partial class RealTextBox : TextBox
	{
		public RealTextBox()
		{
			InitializeComponent();

			BackColor = Configuration.DefaultMenuBackgroundColor;
		}
	}
}
