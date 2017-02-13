namespace Fyk.Tfs.TfsCommonControls
{
	partial class TfsUrlAndProjects
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
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.refreshProjectsButton = new System.Windows.Forms.Button();
			this.projectsComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.urlTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// refreshProjectsButton
			// 
			this.refreshProjectsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshProjectsButton.Location = new System.Drawing.Point(230, 29);
			this.refreshProjectsButton.Name = "refreshProjectsButton";
			this.refreshProjectsButton.Size = new System.Drawing.Size(75, 23);
			this.refreshProjectsButton.TabIndex = 9;
			this.refreshProjectsButton.Text = "Refresh";
			this.refreshProjectsButton.UseVisualStyleBackColor = true;
			this.refreshProjectsButton.Click += new System.EventHandler(this.refreshProjectsButton_Click);
			// 
			// projectsComboBox
			// 
			this.projectsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.projectsComboBox.FormattingEnabled = true;
			this.projectsComboBox.Location = new System.Drawing.Point(66, 31);
			this.projectsComboBox.Name = "projectsComboBox";
			this.projectsComboBox.Size = new System.Drawing.Size(158, 21);
			this.projectsComboBox.Sorted = true;
			this.projectsComboBox.TabIndex = 8;
			this.projectsComboBox.SelectedValueChanged += new System.EventHandler(this.projectsComboBox_SelectedValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Project:";
			// 
			// urlTextBox
			// 
			this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.urlTextBox.Location = new System.Drawing.Point(66, 3);
			this.urlTextBox.Name = "urlTextBox";
			this.urlTextBox.Size = new System.Drawing.Size(239, 20);
			this.urlTextBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "URL:";
			// 
			// TfsUrlAndProjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.refreshProjectsButton);
			this.Controls.Add(this.projectsComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.urlTextBox);
			this.Controls.Add(this.label1);
			this.Name = "TfsUrlAndProjects";
			this.Size = new System.Drawing.Size(313, 58);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button refreshProjectsButton;
		private System.Windows.Forms.ComboBox projectsComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox urlTextBox;
		private System.Windows.Forms.Label label1;
	}
}
