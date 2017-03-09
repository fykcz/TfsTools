using Microsoft.TeamFoundation.Client;
using System;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Framework.Client;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System.Collections.Generic;
using Fyk.Tfs.TfsCommonControls;

namespace Fyk.Tfs.HtmlDescriptionMigrator
{
	public partial class PrepareMigration : Form, IMasterFormHandler
	{

		private WorkItemStore _store;
		private Dictionary<int, WIDetail> _details = new Dictionary<int, WIDetail>();
		private Dictionary<int, ListViewItem> _wiLVI = new Dictionary<int, ListViewItem>();

		public PrepareMigration()
		{
			InitializeComponent();
#if DEBUG
			tfsUrlAndProjects.Url = Utils.TfsUrl;
#endif
		}

		private void SetListViewItem(WorkItem workItem, ListViewItem listViewItem, bool update = false)
		{
			String htmlDescription = workItem.Fields.Contains("HtmlDescription") ? workItem.Fields["HtmlDescription"].Value.ToString() : null;

			if (update)
			{
				listViewItem.SubItems[1].Text = workItem.Title;
				listViewItem.SubItems[2].Text = workItem.Description;
				listViewItem.SubItems[3].Text = htmlDescription != null ? htmlDescription : "-";

			}
			else
			{
				listViewItem.SubItems.Add(workItem.Title);
				listViewItem.SubItems.Add(workItem.Description);
				listViewItem.SubItems.Add(htmlDescription != null ? htmlDescription : "-");
			}
			listViewItem.Tag = workItem;
			if (htmlDescription != null)
			{
				if ((workItem.Description.Length == 0) && (htmlDescription.Length > 0))
				{
					listViewItem.Checked = true;
					listViewItem.BackColor = System.Drawing.Color.LightSeaGreen;
				}
				else if ((workItem.Description.Length > 0) && (htmlDescription.Length > 0))
					if (workItem.Description != htmlDescription)
					{
						listViewItem.Checked = true;
						listViewItem.BackColor = System.Drawing.Color.IndianRed;
					}
					else
					{
						listViewItem.Checked = false;
						listViewItem.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					}
				else if ((workItem.Description.Length > 0) && (htmlDescription.Length == 0))
				{
					listViewItem.Checked = false;
					listViewItem.BackColor = System.Drawing.Color.SeaShell;
				}
			}
		}

		private void LoadItems()
		{
			Cursor = Cursors.WaitCursor;
			var projectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(tfsUrlAndProjects.Url));

			_store = projectCollection.GetService<WorkItemStore>();
			wiListView.Items.Clear();
			_wiLVI.Clear();
			var l = _store.Query(string.Format("SELECT * FROM WorkItems WHERE [System.TeamProject]='{0}' and [System.WorkItemType]='Task'", tfsUrlAndProjects.Project));
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

		private void PrepareMigration_FormClosing(object sender, FormClosingEventArgs e)
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
				wi.Description = wi.Fields["HtmlDescription"].Value.ToString();
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
