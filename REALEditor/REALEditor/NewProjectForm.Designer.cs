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
			this.dirTextBox = new RealEditorCustomControls.RealTextBox();
			this.projectDirLabel = new RealEditorCustomControls.RealLabel();
			this.header = new RealEditorCustomControls.RealLabel();
			this.projectNameLabel = new RealEditorCustomControls.RealLabel();
			this.projectNameTextBox = new RealEditorCustomControls.RealTextBox();
			this.browseDirButton = new RealEditorCustomControls.RealButton();
			this.createProjectButton = new RealEditorCustomControls.RealButton();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.headerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// dirTextBox
			// 
			this.dirTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.dirTextBox.ForeColor = System.Drawing.Color.White;
			this.dirTextBox.Location = new System.Drawing.Point(135, 125);
			this.dirTextBox.Name = "dirTextBox";
			this.dirTextBox.Size = new System.Drawing.Size(268, 20);
			this.dirTextBox.TabIndex = 4;
			// 
			// projectDirLabel
			// 
			this.projectDirLabel.AutoSize = true;
			this.projectDirLabel.ForeColor = System.Drawing.Color.White;
			this.projectDirLabel.Location = new System.Drawing.Point(13, 125);
			this.projectDirLabel.Name = "projectDirLabel";
			this.projectDirLabel.Size = new System.Drawing.Size(91, 13);
			this.projectDirLabel.TabIndex = 3;
			this.projectDirLabel.Text = "Project Directory :";
			// 
			// header
			// 
			this.header.AutoSize = true;
			this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
			this.header.ForeColor = System.Drawing.Color.White;
			this.header.Location = new System.Drawing.Point(12, 9);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(200, 26);
			this.header.TabIndex = 2;
			this.header.Text = "Create new project ";
			// 
			// projectNameLabel
			// 
			this.projectNameLabel.AutoSize = true;
			this.projectNameLabel.ForeColor = System.Drawing.Color.White;
			this.projectNameLabel.Location = new System.Drawing.Point(12, 83);
			this.projectNameLabel.Name = "projectNameLabel";
			this.projectNameLabel.Size = new System.Drawing.Size(77, 13);
			this.projectNameLabel.TabIndex = 1;
			this.projectNameLabel.Text = "Project Name :";
			// 
			// projectNameTextBox
			// 
			this.projectNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.projectNameTextBox.ForeColor = System.Drawing.Color.White;
			this.projectNameTextBox.Location = new System.Drawing.Point(135, 83);
			this.projectNameTextBox.Name = "projectNameTextBox";
			this.projectNameTextBox.Size = new System.Drawing.Size(297, 21);
			this.projectNameTextBox.TabIndex = 0;
			// 
			// browseDirButton
			// 
			this.browseDirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.browseDirButton.FlatAppearance.BorderSize = 0;
			this.browseDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseDirButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseDirButton.ForeColor = System.Drawing.Color.White;
			this.browseDirButton.Location = new System.Drawing.Point(409, 125);
			this.browseDirButton.Margin = new System.Windows.Forms.Padding(0);
			this.browseDirButton.Name = "browseDirButton";
			this.browseDirButton.Size = new System.Drawing.Size(26, 20);
			this.browseDirButton.TabIndex = 6;
			this.browseDirButton.Text = "...";
			this.browseDirButton.UseVisualStyleBackColor = false;
			// 
			// createProjectButton
			// 
			this.createProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.createProjectButton.FlatAppearance.BorderSize = 0;
			this.createProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createProjectButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createProjectButton.ForeColor = System.Drawing.Color.White;
			this.createProjectButton.Location = new System.Drawing.Point(331, 182);
			this.createProjectButton.Name = "createProjectButton";
			this.createProjectButton.Size = new System.Drawing.Size(104, 23);
			this.createProjectButton.TabIndex = 7;
			this.createProjectButton.Text = "Create Project";
			this.createProjectButton.UseVisualStyleBackColor = false;
			this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
			// 
			// headerPanel
			// 
			this.headerPanel.Controls.Add(this.header);
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(445, 35);
			this.headerPanel.TabIndex = 8;
			// 
			// NewProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 217);
			this.Controls.Add(this.createProjectButton);
			this.Controls.Add(this.browseDirButton);
			this.Controls.Add(this.dirTextBox);
			this.Controls.Add(this.projectDirLabel);
			this.Controls.Add(this.projectNameLabel);
			this.Controls.Add(this.projectNameTextBox);
			this.Controls.Add(this.headerPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewProjectForm";
			this.Text = "Create new project";
			this.Load += new System.EventHandler(this.NewProjectForm_Load);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RealEditorCustomControls.RealTextBox projectNameTextBox;
		private RealEditorCustomControls.RealLabel projectNameLabel;
		private RealEditorCustomControls.RealLabel header;
		private RealEditorCustomControls.RealLabel projectDirLabel;
		private RealEditorCustomControls.RealTextBox dirTextBox;
		private RealEditorCustomControls.RealButton browseDirButton;
		private RealEditorCustomControls.RealButton createProjectButton;
		private System.Windows.Forms.Panel headerPanel;
	}
}