using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Server;

namespace Fyk.Tfs.TfsCommonControls
{
	public partial class SelectTfsProjects : Form
	{
		public SelectTfsProjects()
		{
			InitializeComponent();
		}

		private void connectButton_Click(object sender, EventArgs e)
		{
			using (var tpp = new TeamProjectPicker(TeamProjectPickerMode.MultiProject, true))
			{
				tpp.AcceptButtonText = "Select";
				//tpp.SelectedTeamProjectCollection.Uri = new Uri(textBox1.Text);
				if (tpp.ShowDialog() == DialogResult.Cancel) return;
				//				var stpc = tpp.SelectedTeamProjectCollection;
				var pc = tpp.SelectedProjects;
				projectsListView.Items.Clear();
				urlTextBox.Text = tpp.SelectedTeamProjectCollection.Uri.AbsoluteUri;
				foreach (var x in pc)
				{
					var ii = projectsListView.Items.Add(x.Name);
					ii.Tag = x;
				}
			}
		}

		public ProjectInfo[] ProjectList
		{
			get { return (from ListViewItem x in projectsListView.Items select x.Tag as ProjectInfo).ToArray(); }
		}
		public string Url { get { return urlTextBox.Text; } }
	}
}
