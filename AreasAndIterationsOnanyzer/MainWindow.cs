using Microsoft.TeamFoundation.Client;
using System;
using System.Windows.Forms;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System.Collections.Generic;
using Fyk.Tfs.TfsCommonControls;

namespace Fyk.Tfs.AreasAndIterationsOnanyzer
{
	public partial class MainWindow : Form, IMasterFormHandler
	{

		private WorkItemStore _store;
		private Dictionary<int, WIDetail> _details = new Dictionary<int, WIDetail>();
		private Dictionary<int, ListViewItem> _wiLVI = new Dictionary<int, ListViewItem>();
		private Dictionary<string, Node> _iterationList = new Dictionary<string, Node>();
		private Node _bezZarazeniNode = null;

		private void GetIterationTree(NodeCollection nodeCollection)
		{
			for (int i = 0; i < nodeCollection.Count; i++)
			{

				//Console.WriteLine(nodeCollection[i].Id + " : " + nodeCollection[i].Path);
				// Console.WriteLine(nodeCollection[i].Name);
				string[] spl = nodeCollection[i].Path.Split('\\');
				_iterationList.Add(spl[1], nodeCollection[i]);

				if (nodeCollection[i].ChildNodes.Count > 0)
				{
					// Recursively walk through the child nodes
					GetIterationTree(nodeCollection[i].ChildNodes);
				}
			}
		}

		private void GetAreaTree(NodeCollection nodeCollection)
		{
			for (var i = 0; i < nodeCollection.Count; i++)
			{
				string[] spl = nodeCollection[i].Path.Split('\\');
				var name = spl[spl.Length - 1];
				if (name == "_Bez zařazení po přenosu")
					_bezZarazeniNode = nodeCollection[i];
				if (nodeCollection[i].ChildNodes.Count > 0)
					GetAreaTree(nodeCollection[i].ChildNodes);
			}
		}
	
		public MainWindow()
		{
			InitializeComponent();
#if DEBUG
			tfsUrlAndProjects.Url = Utils.TfsUrl;
#endif
		}

		private void SetListViewItem(WorkItem workItem, ListViewItem listViewItem, bool update = false)
		{
			//String htmlDescription = workItem.Fields.Contains("HtmlDescription") ? workItem.Fields["HtmlDescription"].Value.ToString() : null;
			var newIteration = "";
			string[] keys = new string[_iterationList.Keys.Count];
			_iterationList.Keys.CopyTo(keys, 0);
			foreach (var x in keys)
			{
				if (workItem.AreaPath.Contains(x))
				{
					newIteration = x;
					listViewItem.Checked = true;
				}
			}

			if (update)
			{
				listViewItem.SubItems[1].Text = workItem.Title;
				listViewItem.SubItems[2].Text = workItem.AreaPath;
				listViewItem.SubItems[3].Text = workItem.IterationPath;
				listViewItem.SubItems[4].Text = newIteration;

			}
			else
			{
				listViewItem.SubItems.Add(workItem.Title);
				listViewItem.SubItems.Add(workItem.AreaPath);
				listViewItem.SubItems.Add(workItem.IterationPath);
				listViewItem.SubItems.Add(newIteration);
			}
			listViewItem.Tag = workItem;
		}

		private void LoadItems()
		{
			Cursor = Cursors.WaitCursor;
			var projectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(tfsUrlAndProjects.Url));

			_store = projectCollection.GetService<WorkItemStore>();
			var projectName = tfsUrlAndProjects.Project;
			NodeCollection rootNodeCollection = _store.Projects[projectName].IterationRootNodes;
			_iterationList.Clear();
			GetIterationTree(rootNodeCollection);
			NodeCollection rnCollection = _store.Projects[projectName].AreaRootNodes;
			GetAreaTree(rnCollection);

			wiListView.Items.Clear();
			_wiLVI.Clear();
			var l = _store.Query(string.Format("SELECT * FROM WorkItems WHERE [System.TeamProject]='{0}'", projectName));
			foreach (WorkItem wi in l)
			{
				var lvi = wiListView.Items.Add(wi.Id.ToString());
				SetListViewItem(wi, lvi);
				_wiLVI.Add(wi.Id, lvi);
			}
			Cursor = Cursors.Default;
		}
		private void loadItemsButton_Click(object sender, EventArgs e)
		{
			LoadItems();
		}

		private void wiListView_DoubleClick(object sender, EventArgs e)
		{
			var x = new WIDetail();
			var lvi = wiListView.SelectedItems[0];
			var wi = (WorkItem)lvi.Tag;
			x.LoadWI(wi, this);
			x.Show();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (var x in _details.Values)
				x.ParentClose();
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			foreach (ListViewItem lvi in wiListView.CheckedItems)
			{
				var wi = (WorkItem)lvi.Tag;
				wi.Open();
				wi.IterationId = _iterationList[lvi.SubItems[4].Text].Id;
				wi.Save();
				var nwi = _store.GetWorkItem(wi.Id);
				SetListViewItem(nwi, lvi, true);
			}
			Cursor = Cursors.Default;
		}

		private void allSelCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in wiListView.Items)
				lvi.Checked = allSelCheckBox.Checked;
		}

		private void setAreaButton_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			foreach (ListViewItem lvi in wiListView.CheckedItems)
			{
				var wi = (WorkItem)lvi.Tag;
				wi.Open();
				wi.AreaId = _bezZarazeniNode.Id;
				wi.Save();
				var nwi = _store.GetWorkItem(wi.Id);
				SetListViewItem(nwi, lvi, true);
			}
			Cursor = Cursors.Default;
		}

		public void WindowMsg(WorkItem workItem, MsgTypes msgType)
		{
			switch (msgType)
			{
				case MsgTypes.Close:
					break;
				case MsgTypes.Nothing:
					return;
				case MsgTypes.ChangeAndClose:
					var nwi = _store.GetWorkItem(workItem.Id);
					var lvi = _wiLVI[workItem.Id];
					SetListViewItem(nwi, lvi, true);
					break;
			}
			_details.Remove(workItem.Id);
		}

		private void wiListView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
