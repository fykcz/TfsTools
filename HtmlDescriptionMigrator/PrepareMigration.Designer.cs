namespace Fyk.Tfs.HtmlDescriptionMigrator
{
    partial class PrepareMigration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrepareMigration));
			this.wiListView = new System.Windows.Forms.ListView();
			this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.descriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.htmlDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.titleColumnHeader,
            this.descriptionColumnHeader,
            this.htmlDescriptionColumnHeader});
			this.wiListView.FullRowSelect = true;
			this.wiListView.Location = new System.Drawing.Point(18, 103);
			this.wiListView.Name = "wiListView";
			this.wiListView.Size = new System.Drawing.Size(1040, 616);
			this.wiListView.TabIndex = 5;
			this.wiListView.UseCompatibleStateImageBehavior = false;
			this.wiListView.View = System.Windows.Forms.View.Details;
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
			// descriptionColumnHeader
			// 
			this.descriptionColumnHeader.Text = "Description";
			this.descriptionColumnHeader.Width = 350;
			// 
			// htmlDescriptionColumnHeader
			// 
			this.htmlDescriptionColumnHeader.Text = "HTML Description";
			this.htmlDescriptionColumnHeader.Width = 350;
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
			// tfsUrlAndProjects
			// 
			this.tfsUrlAndProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tfsUrlAndProjects.Location = new System.Drawing.Point(12, 7);
			this.tfsUrlAndProjects.Name = "tfsUrlAndProjects";
			this.tfsUrlAndProjects.Size = new System.Drawing.Size(1046, 58);
			this.tfsUrlAndProjects.TabIndex = 9;
			this.tfsUrlAndProjects.Url = "";
			// 
			// PrepareMigration
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
			this.Name = "PrepareMigration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PrepareMigration";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrepareMigration_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView wiListView;
        private System.Windows.Forms.Button loadItemsButton;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionColumnHeader;
        private System.Windows.Forms.ColumnHeader htmlDescriptionColumnHeader;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.CheckBox allSelCheckBox;
		private TfsCommonControls.TfsUrlAndProjects tfsUrlAndProjects;
	}
}