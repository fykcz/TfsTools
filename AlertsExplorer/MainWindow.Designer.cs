namespace Fyk.Tfs.AlertsExplorer
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
			this.allSelCheckBox = new System.Windows.Forms.CheckBox();
			this.loadItemsButton = new System.Windows.Forms.Button();
			this.wiListView = new System.Windows.Forms.ListView();
			this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.eventTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.deviceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.subscriberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.addressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tfsUrlAndProjects = new Fyk.Tfs.TfsCommonControls.TfsUrlAndProjects();
			this.SuspendLayout();
			// 
			// allSelCheckBox
			// 
			this.allSelCheckBox.AutoSize = true;
			this.allSelCheckBox.Location = new System.Drawing.Point(15, 88);
			this.allSelCheckBox.Name = "allSelCheckBox";
			this.allSelCheckBox.Size = new System.Drawing.Size(109, 17);
			this.allSelCheckBox.TabIndex = 11;
			this.allSelCheckBox.Text = "Select all/nothing";
			this.allSelCheckBox.UseVisualStyleBackColor = true;
			this.allSelCheckBox.CheckedChanged += new System.EventHandler(this.allSelCheckBox_CheckedChanged);
			// 
			// loadItemsButton
			// 
			this.loadItemsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.loadItemsButton.Location = new System.Drawing.Point(497, 84);
			this.loadItemsButton.Name = "loadItemsButton";
			this.loadItemsButton.Size = new System.Drawing.Size(75, 23);
			this.loadItemsButton.TabIndex = 10;
			this.loadItemsButton.Text = "Load Items";
			this.loadItemsButton.UseVisualStyleBackColor = true;
			this.loadItemsButton.Click += new System.EventHandler(this.loadItemsButton_Click);
			// 
			// wiListView
			// 
			this.wiListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.wiListView.CheckBoxes = true;
			this.wiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.eventTypeColumnHeader,
            this.deviceColumnHeader,
            this.subscriberColumnHeader,
            this.addressColumnHeader});
			this.wiListView.FullRowSelect = true;
			this.wiListView.Location = new System.Drawing.Point(15, 120);
			this.wiListView.Name = "wiListView";
			this.wiListView.Size = new System.Drawing.Size(1040, 616);
			this.wiListView.TabIndex = 9;
			this.wiListView.UseCompatibleStateImageBehavior = false;
			this.wiListView.View = System.Windows.Forms.View.Details;
			this.wiListView.DoubleClick += new System.EventHandler(this.wiListView_DoubleClick);
			// 
			// idColumnHeader
			// 
			this.idColumnHeader.Text = "ID";
			// 
			// eventTypeColumnHeader
			// 
			this.eventTypeColumnHeader.Text = "Event Type";
			this.eventTypeColumnHeader.Width = 250;
			// 
			// deviceColumnHeader
			// 
			this.deviceColumnHeader.Text = "Device";
			this.deviceColumnHeader.Width = 250;
			// 
			// subscriberColumnHeader
			// 
			this.subscriberColumnHeader.Text = "Subscriber";
			this.subscriberColumnHeader.Width = 200;
			// 
			// addressColumnHeader
			// 
			this.addressColumnHeader.Text = "Address";
			this.addressColumnHeader.Width = 200;
			// 
			// tfsUrlAndProjects
			// 
			this.tfsUrlAndProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tfsUrlAndProjects.Location = new System.Drawing.Point(13, 13);
			this.tfsUrlAndProjects.Name = "tfsUrlAndProjects";
			this.tfsUrlAndProjects.Size = new System.Drawing.Size(1045, 58);
			this.tfsUrlAndProjects.TabIndex = 0;
			this.tfsUrlAndProjects.Url = "";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 755);
			this.Controls.Add(this.allSelCheckBox);
			this.Controls.Add(this.loadItemsButton);
			this.Controls.Add(this.wiListView);
			this.Controls.Add(this.tfsUrlAndProjects);
			this.Name = "MainWindow";
			this.Text = "Alerts Explorer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TfsCommonControls.TfsUrlAndProjects tfsUrlAndProjects;
		private System.Windows.Forms.CheckBox allSelCheckBox;
		private System.Windows.Forms.Button loadItemsButton;
		private System.Windows.Forms.ListView wiListView;
		private System.Windows.Forms.ColumnHeader idColumnHeader;
		private System.Windows.Forms.ColumnHeader eventTypeColumnHeader;
		private System.Windows.Forms.ColumnHeader deviceColumnHeader;
		private System.Windows.Forms.ColumnHeader subscriberColumnHeader;
		private System.Windows.Forms.ColumnHeader addressColumnHeader;
	}
}