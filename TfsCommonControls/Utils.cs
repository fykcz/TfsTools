using System.Windows.Forms;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace Fyk.Tfs.TfsCommonControls
{
	public static class Utils
	{
		public static SelectedProjectsEnvelope SelectTfsProjects()
		{
			using (var tpp = new TeamProjectPicker(TeamProjectPickerMode.MultiProject, true))
			{
				tpp.AcceptButtonText = "Select";
				if (tpp.ShowDialog() == DialogResult.Cancel) return null;
				var rv = new SelectedProjectsEnvelope
				{
					SelectedProjects = tpp.SelectedProjects,
					Url = tpp.SelectedTeamProjectCollection.Uri.AbsoluteUri
				};
				return rv;
			}
		}

		public static string GetUrlForEditWorkItem(WorkItem item)
		{
			return string.Format("http://vmwtfs:8080/tfs/DefaultCollection/{0}/_workitems#_a=edit&id={1}", item.Project.Name, item.Id);
		}

		public const string TfsUrl = @"http://vmwtfs:8080/tfs/defaultcollection";
	}
}
