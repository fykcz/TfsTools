namespace Fyk.Tfs.Estimate2Remaining
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.wiListView = new System.Windows.Forms.ListView();
			this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.stateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.originalEstColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.remainingColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.loadItemsButton = new System.Windows.Forms.Button();
			this.tfsUrlAndProjects = new Fyk.Tfs.TfsCommonControls.TfsUrlAndProjects();
			this.allSelCheckBox = new System.Windows.Forms.CheckBox();
			this.updateButton = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// wiListView
			// 
			this.wiListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.wiListView.CheckBoxes = true;
			this.wiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.typeColumnHeader,
            this.stateColumnHeader,
            this.titleColumnHeader,
            this.originalEstColumnHeader,
            this.remainingColumnHeader});
			this.wiListView.FullRowSelect = true;
			this.wiListView.Location = new System.Drawing.Point(12, 105);
			this.wiListView.Name = "wiListView";
			this.wiListView.Size = new System.Drawing.Size(460, 344);
			this.wiListView.TabIndex = 0;
			this.wiListView.UseCompatibleStateImageBehavior = false;
			this.wiListView.View = System.Windows.Forms.View.Details;
			this.wiListView.DoubleClick += new System.EventHandler(this.wiListView_DoubleClick);
			// 
			// idColumnHeader
			// 
			this.idColumnHeader.Text = "ID";
			// 
			// typeColumnHeader
			// 
			this.typeColumnHeader.Text = "Type";
			this.typeColumnHeader.Width = 80;
			// 
			// stateColumnHeader
			// 
			this.stateColumnHeader.Text = "State";
			this.stateColumnHeader.Width = 80;
			// 
			// titleColumnHeader
			// 
			this.titleColumnHeader.Text = "Title";
			this.titleColumnHeader.Width = 250;
			// 
			// originalEstColumnHeader
			// 
			this.originalEstColumnHeader.Text = "Orig. Est.";
			// 
			// remainingColumnHeader
			// 
			this.remainingColumnHeader.Text = "Remaining";
			// 
			// loadItemsButton
			// 
			this.loadItemsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.loadItemsButton.Location = new System.Drawing.Point(205, 76);
			this.loadItemsButton.Name = "loadItemsButton";
			this.loadItemsButton.Size = new System.Drawing.Size(75, 23);
			this.loadItemsButton.TabIndex = 2;
			this.loadItemsButton.Text = "Load items";
			this.loadItemsButton.UseVisualStyleBackColor = true;
			this.loadItemsButton.Click += new System.EventHandler(this.loadItemsButton_Click);
			// 
			// tfsUrlAndProjects
			// 
			this.tfsUrlAndProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tfsUrlAndProjects.Location = new System.Drawing.Point(12, 12);
			this.tfsUrlAndProjects.Name = "tfsUrlAndProjects";
			this.tfsUrlAndProjects.Size = new System.Drawing.Size(460, 58);
			this.tfsUrlAndProjects.TabIndex = 1;
			this.tfsUrlAndProjects.Url = "";
			// 
			// allSelCheckBox
			// 
			this.allSelCheckBox.AutoSize = true;
			this.allSelCheckBox.Location = new System.Drawing.Point(12, 80);
			this.allSelCheckBox.Name = "allSelCheckBox";
			this.allSelCheckBox.Size = new System.Drawing.Size(109, 17);
			this.allSelCheckBox.TabIndex = 9;
			this.allSelCheckBox.Text = "Select all/nothing";
			this.allSelCheckBox.UseVisualStyleBackColor = true;
			this.allSelCheckBox.CheckedChanged += new System.EventHandler(this.allSelCheckBox_CheckedChanged);
			// 
			// updateButton
			// 
			this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.updateButton.Location = new System.Drawing.Point(397, 76);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 2;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(397, 76);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(75, 21);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 0;
			this.progressBar.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.allSelCheckBox);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.loadItemsButton);
			this.Controls.Add(this.tfsUrlAndProjects);
			this.Controls.Add(this.wiListView);
			this.Controls.Add(this.progressBar);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView wiListView;
		private TfsCommonControls.TfsUrlAndProjects tfsUrlAndProjects;
		private System.Windows.Forms.Button loadItemsButton;
		private System.Windows.Forms.ColumnHeader idColumnHeader;
		private System.Windows.Forms.ColumnHeader typeColumnHeader;
		private System.Windows.Forms.ColumnHeader stateColumnHeader;
		private System.Windows.Forms.ColumnHeader titleColumnHeader;
		private System.Windows.Forms.ColumnHeader originalEstColumnHeader;
		private System.Windows.Forms.ColumnHeader remainingColumnHeader;
		private System.Windows.Forms.CheckBox allSelCheckBox;
		private System.Windows.Forms.Button updateButton;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}