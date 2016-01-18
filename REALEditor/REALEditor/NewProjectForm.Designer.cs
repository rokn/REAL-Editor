namespace REALEditor
{
	partial class NewProjectForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.realTextBox1 = new RealEditorCustomControls.RealTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// realTextBox1
			// 
			this.realTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.realTextBox1.Location = new System.Drawing.Point(93, 80);
			this.realTextBox1.Name = "realTextBox1";
			this.realTextBox1.Size = new System.Drawing.Size(339, 20);
			this.realTextBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Project name :";
			// 
			// NewProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 280);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.realTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewProjectForm";
			this.Text = "Create new project";
			this.Load += new System.EventHandler(this.NewProjectForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RealEditorCustomControls.RealTextBox realTextBox1;
		private System.Windows.Forms.Label label1;
	}
}