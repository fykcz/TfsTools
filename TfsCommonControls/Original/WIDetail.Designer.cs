namespace Fyk.Tfs.TfsCommonControls
{
    partial class WIDetail
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
            this.wiFormControl = new Fyk.Tfs.TfsCommonControls.WIFormControl();
            this.SuspendLayout();
            // 
            // wiFormControl
            // 
            this.wiFormControl.AccessibleName = "";
            this.wiFormControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiFormControl.FormDefinition = null;
            this.wiFormControl.Item = null;
            this.wiFormControl.LayoutTargetName = "";
            this.wiFormControl.Location = new System.Drawing.Point(0, 0);
            this.wiFormControl.Name = "wiFormControl";
            this.wiFormControl.ReadOnly = false;
            this.wiFormControl.ServiceProvider = null;
            this.wiFormControl.Size = new System.Drawing.Size(284, 261);
            this.wiFormControl.StatusHandler = null;
            this.wiFormControl.TabIndex = 0;
            this.wiFormControl.UserActionRequiredBackColor = System.Drawing.SystemColors.Info;
            this.wiFormControl.UserActionRequiredForeColor = System.Drawing.SystemColors.InfoText;
            // 
            // WIDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.wiFormControl);
            this.Name = "WIDetail";
            this.Text = "WIDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WIDetail_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private WIFormControl wiFormControl;
    }
}