namespace Fyk.Tfs.WorkItemDestroyer
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.wiListView = new System.Windows.Forms.ListView();
			this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.stateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.createdByColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.areaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.iterationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.loadItemsButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.allSelCheckBox = new System.Windows.Forms.CheckBox();
			this.tfsUrlAndProjects = new Fyk.Tfs.TfsCommonControls.TfsUrlAndProjects();
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
            this.createdByColumnHeader,
            this.titleColumnHeader,
            this.areaColumnHeader,
            this.iterationColumnHeader});
			this.wiListView.FullRowSelect = true;
			this.wiListView.Location = new System.Drawing.Point(18, 103);
			this.wiListView.Name = "wiListView";
			this.wiListView.Size = new System.Drawing.Size(1040, 616);
			this.wiListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.wiListView.TabIndex = 5;
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
			// createdByColumnHeader
			// 
			this.createdByColumnHeader.Text = "Created By";
			this.createdByColumnHeader.Width = 120;
			// 
			// titleColumnHeader
			// 
			this.titleColumnHeader.Text = "Title";
			this.titleColumnHeader.Width = 250;
			// 
			// areaColumnHeader
			// 
			this.areaColumnHeader.Text = "Area";
			this.areaColumnHeader.Width = 250;
			// 
			// iterationColumnHeader
			// 
			this.iterationColumnHeader.Text = "Iteration";
			this.iterationColumnHeader.Width = 200;
			// 
			// loadItemsButton
			// 
			this.loadItemsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.loadItemsButton.Location = new System.Drawing.Point(500, 67);
			this.loadItemsButton.Name = "loadItemsButton";
			this.loadItemsButton.Size = new System.Drawing.Size(75, 23);
			this.loadItemsButton.TabIndex = 6;
			this.loadItemsButton.Text = "Load Items";
			this.loadItemsButton.UseVisualStyleBackColor = true;
			this.loadItemsButton.Click += new System.EventHandler(this.loadItemsButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.updateButton.BackColor = System.Drawing.Color.Red;
			this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.updateButton.Location = new System.Drawing.Point(500, 725);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 7;
			this.updateButton.Text = "DESTROY!!!";
			this.updateButton.UseVisualStyleBackColor = false;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// allSelCheckBox
			// 
			this.allSelCheckBox.AutoSize = true;
			this.allSelCheckBox.Location = new System.Drawing.Point(18, 71);
			this.allSelCheckBox.Name = "allSelCheckBox";
			this.allSelCheckBox.Size = new System.Drawing.Size(109, 17);
			this.allSelCheckBox.TabIndex = 8;
			this.allSelCheckBox.Text = "Select all/nothing";
			this.allSelCheckBox.UseVisualStyleBackColor = true;
			this.allSelCheckBox.CheckedChanged += new System.EventHandler(this.allSelCheckBox_CheckedChanged);
			// 
			// tfsUrlAndProjects
			// 
			this.tfsUrlAndProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tfsUrlAndProjects.Location = new System.Drawing.Point(12, 7);
			this.tfsUrlAndProjects.Name = "tfsUrlAndProjects";
			this.tfsUrlAndProjects.Size = new System.Drawing.Size(1046, 58);
			this.tfsUrlAndProjects.TabIndex = 10;
			this.tfsUrlAndProjects.Url = "";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 755);
			this.Controls.Add(this.tfsUrlAndProjects);
			this.Controls.Add(this.allSelCheckBox);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.loadItemsButton);
			this.Controls.Add(this.wiListView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListView wiListView;
		private System.Windows.Forms.Button loadItemsButton;
		private System.Windows.Forms.ColumnHeader idColumnHeader;
		private System.Windows.Forms.ColumnHeader titleColumnHeader;
		private System.Windows.Forms.ColumnHeader areaColumnHeader;
		private System.Windows.Forms.ColumnHeader iterationColumnHeader;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.CheckBox allSelCheckBox;
		private TfsCommonControls.TfsUrlAndProjects tfsUrlAndProjects;
		private System.Windows.Forms.ColumnHeader typeColumnHeader;
		private System.Windows.Forms.ColumnHeader stateColumnHeader;
		private System.Windows.Forms.ColumnHeader createdByColumnHeader;
	}
}