namespace Fyk.Tfs.AreasAndIterationsOnanyzer
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
			this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.areaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.iterationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.newIterationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.loadItemsButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.allSelCheckBox = new System.Windows.Forms.CheckBox();
			this.setAreaButton = new System.Windows.Forms.Button();
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
            this.titleColumnHeader,
            this.areaColumnHeader,
            this.iterationColumnHeader,
            this.newIterationColumnHeader});
			this.wiListView.FullRowSelect = true;
			this.wiListView.Location = new System.Drawing.Point(18, 103);
			this.wiListView.Name = "wiListView";
			this.wiListView.Size = new System.Drawing.Size(1040, 616);
			this.wiListView.TabIndex = 5;
			this.wiListView.UseCompatibleStateImageBehavior = false;
			this.wiListView.View = System.Windows.Forms.View.Details;
			this.wiListView.SelectedIndexChanged += new System.EventHandler(this.wiListView_SelectedIndexChanged);
			this.wiListView.DoubleClick += new System.EventHandler(this.wiListView_DoubleClick);
			// 
			// idColumnHeader
			// 
			this.idColumnHeader.Text = "ID";
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
			// newIterationColumnHeader
			// 
			this.newIterationColumnHeader.Text = "New Iteration";
			this.newIterationColumnHeader.Width = 200;
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
			this.updateButton.Location = new System.Drawing.Point(500, 725);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 7;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
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
			// setAreaButton
			// 
			this.setAreaButton.Location = new System.Drawing.Point(581, 725);
			this.setAreaButton.Name = "setAreaButton";
			this.setAreaButton.Size = new System.Drawing.Size(75, 23);
			this.setAreaButton.TabIndex = 9;
			this.setAreaButton.Text = "Set Area";
			this.setAreaButton.UseVisualStyleBackColor = true;
			this.setAreaButton.Click += new System.EventHandler(this.setAreaButton_Click);
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
			this.Controls.Add(this.setAreaButton);
			this.Controls.Add(this.allSelCheckBox);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.loadItemsButton);
			this.Controls.Add(this.wiListView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Areas And Iteration Onanyzer";
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
		private System.Windows.Forms.ColumnHeader newIterationColumnHeader;
		private System.Windows.Forms.Button setAreaButton;
		private TfsCommonControls.TfsUrlAndProjects tfsUrlAndProjects;
	}
}