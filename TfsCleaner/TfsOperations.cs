using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Net;

namespace FYK.Tfs.TfsCleaner
{
	internal class TfsOperations
	{
		private OperationsSection _operations = null;
		private WorkItemStore _store = null;
		public TfsOperations(OperationsSection operations)
		{
			_operations = operations;
		}

		public WorkItemStore Login()
		{
			Utils.DebugWrite("TFS: {0}", _operations.Configuration.URL);
			Utils.DebugWrite("Credentials: {0}\\{1}#{2}", _operations.Configuration.Domain, _operations.Configuration.UserName, _operations.Configuration.Password);

			// Translate username and password to TFS Credentials
			ICredentials networkCredential = new NetworkCredential(_operations.Configuration.UserName, _operations.Configuration.Password, _operations.Configuration.Domain);
			WindowsCredential windowsCredential = new WindowsCredential(networkCredential);
			TfsClientCredentials tfsCredential = new TfsClientCredentials(windowsCredential, false);

			// Connect to TFS Work Item Store
			Uri tfsUri = new Uri(_operations.Configuration.URL);
			TfsTeamProjectCollection tfs = new TfsTeamProjectCollection(tfsUri, tfsCredential);
			//WorkItemStore witStore = new WorkItemStore(tfs);

			_store = tfs.GetService<WorkItemStore>();
			Utils.DebugWrite("Connected");

			return _store;
		}

		public void RunOperations()
		{
			foreach (Operation operation in _operations.Operations)
			{
				var query = string.Format("SELECT * FROM WorkItems WHERE [System.TeamProject]='{0}' and {1}", operation.Project, operation.Condition);
				var l = _store.Query(query);
				Utils.DebugWrite("Query: {0}\\{1}", l.Count, query);

				RunOperation(operation, l);
			}
		}

		private void RunOperation(Operation operation, WorkItemCollection workItems)
		{
			foreach (WorkItem wi in workItems)
			{
				//Console.Out.WriteLine(string.Format("{0} {1} {2}", wi.Id, wi.Title, wi.Fields[operation.Action.FieldName].Value));

			}
		}
	}
}
