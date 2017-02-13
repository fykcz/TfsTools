namespace Fyk.Tfs.TfsWatcher
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.urlTextBox = new System.Windows.Forms.TextBox();
			this.projectsListBox = new System.Windows.Forms.ListBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.connectButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tasksListView = new System.Windows.Forms.ListView();
			this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.projectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.subjectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.createdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// urlTextBox
			// 
			this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.urlTextBox.Location = new System.Drawing.Point(41, 7);
			this.urlTextBox.Name = "urlTextBox";
			this.urlTextBox.ReadOnly = true;
			this.urlTextBox.Size = new System.Drawing.Size(621, 20);
			this.urlTextBox.TabIndex = 0;
			// 
			// projectsListBox
			// 
			this.projectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectsListBox.FormattingEnabled = true;
			this.projectsListBox.Location = new System.Drawing.Point(0, 0);
			this.projectsListBox.Name = "projectsListBox";
			this.projectsListBox.Size = new System.Drawing.Size(229, 449);
			this.projectsListBox.Sorted = true;
			this.projectsListBox.TabIndex = 3;
			this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Tfs Watcher";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "URL:";
			// 
			// connectButton
			// 
			this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.connectButton.Location = new System.Drawing.Point(668, 5);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(75, 23);
			this.connectButton.TabIndex = 6;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.connectButton);
			this.panel1.Controls.Add(this.urlTextBox);
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(749, 37);
			this.panel1.TabIndex = 7;
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(0, 71);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.projectsListBox);
			this.splitContainer.Panel1MinSize = 150;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.button2);
			this.splitContainer.Panel2.Controls.Add(this.textBox1);
			this.splitContainer.Panel2.Controls.Add(this.button1);
			this.splitContainer.Panel2.Controls.Add(this.tasksListView);
			this.splitContainer.Size = new System.Drawing.Size(743, 449);
			this.splitContainer.SplitterDistance = 229;
			this.splitContainer.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(23, 143);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 15);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(374, 166);
			this.textBox1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(23, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tasksListView
			// 
			this.tasksListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.projectColumnHeader,
            this.subjectColumnHeader,
            this.statusColumnHeader,
            this.createdColumnHeader,
            this.dueColumnHeader});
			this.tasksListView.FullRowSelect = true;
			this.tasksListView.Location = new System.Drawing.Point(3, 187);
			this.tasksListView.Name = "tasksListView";
			this.tasksListView.Size = new System.Drawing.Size(504, 258);
			this.tasksListView.TabIndex = 0;
			this.tasksListView.UseCompatibleStateImageBehavior = false;
			this.tasksListView.View = System.Windows.Forms.View.Details;
			this.tasksListView.DoubleClick += new System.EventHandler(this.tasksListView_DoubleClick);
			// 
			// idColumnHeader
			// 
			this.idColumnHeader.Text = "ID";
			// 
			// projectColumnHeader
			// 
			this.projectColumnHeader.Text = "Project";
			// 
			// subjectColumnHeader
			// 
			this.subjectColumnHeader.Text = "Task";
			// 
			// statusColumnHeader
			// 
			this.statusColumnHeader.Text = "Status";
			// 
			// createdColumnHeader
			// 
			this.createdColumnHeader.Text = "Created";
			// 
			// dueColumnHeader
			// 
			this.dueColumnHeader.Text = "Due";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton,
            this.exitToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(749, 25);
			this.toolStrip1.TabIndex = 9;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// refreshToolStripButton
			// 
			this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
			this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.refreshToolStripButton.Name = "refreshToolStripButton";
			this.refreshToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.refreshToolStripButton.Text = "Refresh";
			this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
			// 
			// exitToolStripButton
			// 
			this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.exitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripButton.Image")));
			this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.exitToolStripButton.Name = "exitToolStripButton";
			this.exitToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.exitToolStripButton.Text = "Exit";
			this.exitToolStripButton.Click += new System.EventHandler(this.exitToolStripButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 528);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "MainForm";
			this.Text = "Tfs Watcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox urlTextBox;
		private System.Windows.Forms.ListBox projectsListBox;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ListView tasksListView;
		private System.Windows.Forms.ColumnHeader idColumnHeader;
		private System.Windows.Forms.ColumnHeader subjectColumnHeader;
		private System.Windows.Forms.ColumnHeader statusColumnHeader;
		private System.Windows.Forms.ColumnHeader createdColumnHeader;
		private System.Windows.Forms.ColumnHeader dueColumnHeader;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton refreshToolStripButton;
		private System.Windows.Forms.ColumnHeader projectColumnHeader;
		private System.Windows.Forms.ToolStripButton exitToolStripButton;
    }
}