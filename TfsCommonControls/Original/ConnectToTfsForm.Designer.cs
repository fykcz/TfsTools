namespace Fyk.Tfs.TfsCommonControls
{
	partial class ConnectToTfsForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.protocolComboBox = new System.Windows.Forms.ComboBox();
			this.serverTextBox = new System.Windows.Forms.TextBox();
			this.portTextBox = new System.Windows.Forms.TextBox();
			this.rootTextBox = new System.Windows.Forms.TextBox();
			this.collectionTextBox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.urlTextBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Protocol:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Server:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Port:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Root path:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Default collection:";
			// 
			// protocolComboBox
			// 
			this.protocolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.protocolComboBox.ItemHeight = 13;
			this.protocolComboBox.Items.AddRange(new object[] {
            "http",
            "https"});
			this.protocolComboBox.Location = new System.Drawing.Point(134, 9);
			this.protocolComboBox.Name = "protocolComboBox";
			this.protocolComboBox.Size = new System.Drawing.Size(96, 21);
			this.protocolComboBox.TabIndex = 5;
			this.protocolComboBox.SelectedIndexChanged += new System.EventHandler(this.protocolComboBox_SelectedIndexChanged);
			// 
			// serverTextBox
			// 
			this.serverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.serverTextBox.Location = new System.Drawing.Point(134, 37);
			this.serverTextBox.Name = "serverTextBox";
			this.serverTextBox.Size = new System.Drawing.Size(210, 20);
			this.serverTextBox.TabIndex = 6;
			this.serverTextBox.TextChanged += new System.EventHandler(this.serverTextBox_TextChanged);
			// 
			// portTextBox
			// 
			this.portTextBox.Location = new System.Drawing.Point(134, 64);
			this.portTextBox.Name = "portTextBox";
			this.portTextBox.Size = new System.Drawing.Size(96, 20);
			this.portTextBox.TabIndex = 6;
			this.portTextBox.TextChanged += new System.EventHandler(this.portTextBox_TextChanged);
			// 
			// rootTextBox
			// 
			this.rootTextBox.Location = new System.Drawing.Point(134, 91);
			this.rootTextBox.Name = "rootTextBox";
			this.rootTextBox.Size = new System.Drawing.Size(96, 20);
			this.rootTextBox.TabIndex = 6;
			this.rootTextBox.TextChanged += new System.EventHandler(this.rootTextBox_TextChanged);
			// 
			// collectionTextBox
			// 
			this.collectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.collectionTextBox.Location = new System.Drawing.Point(134, 118);
			this.collectionTextBox.Name = "collectionTextBox";
			this.collectionTextBox.Size = new System.Drawing.Size(210, 20);
			this.collectionTextBox.TabIndex = 6;
			this.collectionTextBox.TextChanged += new System.EventHandler(this.collectionTextBox_TextChanged);
			// 
			// okButton
			// 
			this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(101, 186);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 7;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "URL:";
			// 
			// urlTextBox
			// 
			this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.urlTextBox.Location = new System.Drawing.Point(134, 145);
			this.urlTextBox.Name = "urlTextBox";
			this.urlTextBox.ReadOnly = true;
			this.urlTextBox.Size = new System.Drawing.Size(210, 20);
			this.urlTextBox.TabIndex = 9;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(182, 186);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// ConnectToTfsForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(364, 221);
			this.ControlBox = false;
			this.Controls.Add(this.urlTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.rootTextBox);
			this.Controls.Add(this.portTextBox);
			this.Controls.Add(this.collectionTextBox);
			this.Controls.Add(this.serverTextBox);
			this.Controls.Add(this.protocolComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(600, 300);
			this.MinimumSize = new System.Drawing.Size(350, 250);
			this.Name = "ConnectToTfsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Connect To TFS";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox protocolComboBox;
		private System.Windows.Forms.TextBox serverTextBox;
		private System.Windows.Forms.TextBox portTextBox;
		private System.Windows.Forms.TextBox rootTextBox;
		private System.Windows.Forms.TextBox collectionTextBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox urlTextBox;
		private System.Windows.Forms.Button cancelButton;
	}
}