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
			return string.Format("{2}/{0}/_workitems#_a=edit&id={1}", item.Project.Name, item.Id, TfsUrl);
		}

		public const string TfsUrl = @"https://vyvoj1/tfs/AstraNET";
	}
}
