using Microsoft.TeamFoundation.Server;

namespace Fyk.Tfs.TfsCommonControls
{
	public class SelectedProjectsEnvelope
	{
		public ProjectInfo[] SelectedProjects { get; set; }
		public string Url { get; set; }
	}
}
