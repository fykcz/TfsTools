using System;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace FYK.Tfs.TfsCleaner
{
	class Program
	{
		static void Main(string[] args)
		{
			//var arg = new Arguments(args);
			var projectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(Utils.TFSUrl));
			var store = projectCollection.GetService<WorkItemStore>();
			//var query = "SELECT * FROM WorkItems WHERE [System.TeamProject]='{0}' and [System.WorkItemType]='Task' and [System.State]='Closed'";
			var query = "SELECT * FROM WorkItems WHERE [System.TeamProject]='{0}' and [System.WorkItemType]='Task' and [System.State]='Closed' and [System.IterationPath]<>'{1}'";
			var l = store.Query(string.Format(query, Utils.Project, Utils.TargetIterationPath));
			foreach (WorkItem wi in l)
			{
				Console.Out.WriteLine(string.Format("{0} {1} {2}", wi.Id, wi.Title, wi.IterationPath));
				wi.Open();
				wi.IterationPath = Utils.TargetIterationPath;
				wi.Save();
			}
		}
	}
}
