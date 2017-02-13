using System;
using System.Windows.Forms;

namespace Fyk.Tfs.TfsCommonControls
{
	public partial class ConnectToTfsForm : Form
	{
		public ConnectToTfsForm()
		{
			InitializeComponent();
#if DEBUG
			serverTextBox.Text = "10.1.1.102";
			portTextBox.Text = "8080";
#endif
            protocolComboBox.SelectedIndex = 0;
            rootTextBox.Text = "tfs";
            collectionTextBox.Text = "DefaultCollection";
        }
        public string Url
		{
			get { return protocolComboBox.Items[protocolComboBox.SelectedIndex].ToString() + "://" + serverTextBox.Text.Trim() + ":" + portTextBox.Text.Trim() + "/" + rootTextBox.Text.Trim() + "/" + collectionTextBox.Text.Trim(); }
		}
		private void UrlItemChanged()
		{
			var port = 0;
			okButton.Enabled = (protocolComboBox.SelectedIndex > -1) &&
											(serverTextBox.Text.Trim().Length > 0) &&
											((portTextBox.Text.Trim().Length > 0) && Int32.TryParse(portTextBox.Text.Trim(), out port)) &&
											(rootTextBox.Text.Trim().Length > 0) &&
											(collectionTextBox.Text.Trim().Length > 0);
			urlTextBox.Text = Url;
		}

		private void protocolComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UrlItemChanged();
		}

		private void serverTextBox_TextChanged(object sender, EventArgs e)
		{
			UrlItemChanged();
		}

		private void portTextBox_TextChanged(object sender, EventArgs e)
		{
			UrlItemChanged();
		}

		private void rootTextBox_TextChanged(object sender, EventArgs e)
		{
			UrlItemChanged();
		}

		private void collectionTextBox_TextChanged(object sender, EventArgs e)
		{
			UrlItemChanged();
		}

	}
}
