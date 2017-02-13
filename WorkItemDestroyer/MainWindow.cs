using Microsoft.TeamFoundation.Client;
using System;
using System.Windows.Forms;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System.Collections.Generic;
using Fyk.Tfs.TfsCommonControls;
using System.Text;

namespace Fyk.Tfs.WorkItemDestroyer
{
	public partial class MainWindow : Form, IMasterFormHandler
	{

		private WorkItemStore _store;
		private Dictionary<int, WIDetail> _details = new Dictionary<int, WIDetail>();
		private Dictionary<int, ListViewItem> _wiLVI = new Dictionary<int, ListViewItem>();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void SetListViewItem(WorkItem workItem, ListViewItem listViewItem, bool update = false)
		{
			if (update)
			{
				listViewItem.SubItems[1].Text = workItem.Type.Name;
				listViewItem.SubItems[2].Text = workItem.State;
				listViewItem.SubItems[3].Text = workItem.CreatedBy;
				listViewItem.SubItems[4].Text = workItem.Title;
				listViewItem.SubItems[5].Text = workItem.AreaPath;
				listViewItem.SubItems[6].Text = workItem.IterationPath;
			}
			else
			{
				listViewItem.SubItems.Add(workItem.Type.Name);
				listViewItem.SubItems.Add(workItem.State);
				listViewItem.SubItems.Add(workItem.CreatedBy);
				listViewItem.SubItems.Add(workItem.Title);
				listViewItem.SubItems.Add(workItem.AreaPath);
				listViewItem.SubItems.Add(workItem.IterationPath);
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

			wiListView.Items.Clear();
			_wiLVI.Clear();
			var l = _store.Query(string.Format("SELECT * FROM WorkItems WHERE [System.TeamProject]='{0}'", projectName));
			foreach (WorkItem wi in l)
			{
				var lvi = wiListView.Items.Add(wi.Id.ToString());
				SetListViewItem(wi, lvi);
				_wiLVI.Add(wi.Id, lvi);
			}
			wiListView.Sort();
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
			if (wiListView.CheckedItems.Count == 0) return;
			Cursor = Cursors.WaitCursor;
			var idS = new List<int>();
			StringBuilder sb = new StringBuilder();
			foreach (ListViewItem i in wiListView.CheckedItems)
			{
				idS.Add(Convert.ToInt32(i.SubItems[0].Text));
				sb.Append(i.SubItems[0].Text).Append(", ");
			}
			var lst = sb.ToString();
			lst = lst.Substring(0, lst.Length - 2);
			Cursor = Cursors.Default;
			if (MessageBox.Show(string.Format("Do you really want to destroy these records: {0}", lst), Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.No)
				return;
			Cursor = Cursors.WaitCursor;
			foreach (var i in _details.Values)
				i.Close();
			_details.Clear();
			var errors = _store.DestroyWorkItems(idS);
			sb.Clear();
			foreach (var i in errors)
				sb.Append(i.Exception.Message).Append(Environment.NewLine);
			if (sb.ToString().Length > 0)
				MessageBox.Show(sb.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				LoadItems();
			Cursor = Cursors.Default;
		}

		private void allSelCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in wiListView.Items)
				lvi.Checked = allSelCheckBox.Checked;
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
	}
}
