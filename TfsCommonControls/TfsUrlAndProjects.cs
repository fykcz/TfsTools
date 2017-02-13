using System;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.Client;

namespace Fyk.Tfs.TfsCommonControls
{
	public delegate void ChangedEventHandler(object sender);

	public partial class TfsUrlAndProjects : UserControl
	{
		public event ChangedEventHandler Changed;

		public TfsUrlAndProjects()
		{
			InitializeComponent();
#if DEBUG
			urlTextBox.Text = Utils.TfsUrl;
#endif
		}

		private void refreshProjectsButton_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			ReadOnlyCollection<CatalogNode> projectNodes = new TfsTeamProjectCollection(new Uri(urlTextBox.Text)).CatalogNode.QueryChildren(
					new[] { CatalogResourceTypes.TeamProject },
					false, CatalogQueryOptions.None);
			projectsComboBox.Items.Clear();
			foreach (var tp in projectNodes)
				projectsComboBox.Items.Add(tp.Resource.DisplayName);
			projectsComboBox.Text = projectsComboBox.Items[0].ToString();
			Changed?.Invoke(this);
			Cursor = Cursors.Default;
		}
		public string Url
		{
			get { return urlTextBox.Text; }
			set { urlTextBox.Text = value; }
		}

		public string Project
		{
			get { return projectsComboBox.SelectedItem.ToString(); }
		}

		private void projectsComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			Changed?.Invoke(this);
		}
	}
}
