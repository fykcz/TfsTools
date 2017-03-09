using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fyk.Tfs.TfsCommonControls;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;

namespace Fyk.Tfs.Estimate2Remaining
{
	public partial class MainForm : Form, IMasterFormHandler
	{
		private WorkItemStore _store;
		private Dictionary<int, WIDetail> _details = new Dictionary<int, WIDetail>();
		private Dictionary<int, ListViewItem> _wiLVI = new Dictionary<int, ListViewItem>();

		public MainForm()
		{
			InitializeComponent();
#if DEBUG
			tfsUrlAndProjects.Url = Utils.TfsUrl;
#endif
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
		private void SetListViewItem(WorkItem workItem, ListViewItem listViewItem, bool update = false)
		{
			var rwo = workItem.Fields.Contains("Remaining Work") ? workItem.Fields["Remaining Work"].Value : null;
			var rw = (rwo != null) ? rwo.ToString() : "";
			var oeo = workItem.Fields.Contains("Original Estimate") ? workItem.Fields["Original Estimate"].Value : null;
			var oe = (oeo != null) ? oeo.ToString() : "";
			listViewItem.Checked = false;
			listViewItem.BackColor = SystemColors.Window;
			if (update)
			{
				listViewItem.SubItems[1].Text = workItem.Type.Name;
				listViewItem.SubItems[2].Text = workItem.State;
				listViewItem.SubItems[3].Text = workItem.Title;
				listViewItem.SubItems[4].Text = oe;
				listViewItem.SubItems[5].Text = rw;

			}
			else
			{
				listViewItem.SubItems.Add(workItem.Type.Name);
				listViewItem.SubItems.Add(workItem.State);
				listViewItem.SubItems.Add(workItem.Title);
				listViewItem.SubItems.Add(oe);
				listViewItem.SubItems.Add(rw);
			}
			listViewItem.Tag = workItem;
			if (!workItem.Fields.Contains("Remaining Work") && !workItem.Fields.Contains("Original Estimate"))
			{
				listViewItem.BackColor = Color.Gray;
				listViewItem.Checked = false;
			}

			if ((oe.Length > 0 && rw.Length == 0) || (Convert.ToDecimal(oe.Length > 0 ? oe : "0") > Convert.ToDecimal(rw.Length > 0 ? rw : "0")))
			{
				listViewItem.BackColor = Color.LightSeaGreen;
				listViewItem.Checked = true;
			}
			else if (oe.Length > 0 && rw.Length > 0 && !oe.Equals(rw))
				listViewItem.BackColor = Color.IndianRed;

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
			var l = _store.Query(string.Format("SELECT * FROM WorkItems WHERE [System.TeamProject]='{0}' ORDER BY ID", projectName));
			foreach (WorkItem wi in l)
			{
				if (wi.Fields.Contains("Remaining Work") && wi.Fields.Contains("Original Estimate"))
				{
					var lvi = wiListView.Items.Add(wi.Id.ToString());
					SetListViewItem(wi, lvi);
					_wiLVI.Add(wi.Id, lvi);
				}
			}
			//wiListView.Sort();
			Cursor = Cursors.Default;
		}
		private void loadItemsButton_Click(object sender, EventArgs e)
		{
			LoadItems();
		}

		private void allSelCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in wiListView.Items)
				lvi.Checked = allSelCheckBox.Checked;
		}

		private void wiListView_DoubleClick(object sender, EventArgs e)
		{
			var x = new WIDetail();
			var lvi = wiListView.SelectedItems[0];
			var wi = (WorkItem)lvi.Tag;
			x.LoadWI(wi, this);
			x.Show();
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			progressBar.Visible = true;
			progressBar.BringToFront();
			progressBar.Minimum = 0;
			progressBar.Step = 1;
			progressBar.Value = 0;
			progressBar.Maximum = 100;
			ListViewItem[] items = new ListViewItem[wiListView.CheckedItems.Count];
			wiListView.CheckedItems.CopyTo(items, 0);
			backgroundWorker.RunWorkerAsync(items);
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var backgroundWorker = sender as BackgroundWorker;
			var counter = 0;
			var lviCollection = e.Argument as ListViewItem[];
			var maxCount = Convert.ToInt32(lviCollection.Length);
			foreach (ListViewItem lvi in lviCollection)
			{
				var wi = (WorkItem)lvi.Tag;
				wi.Open();
				var id = wi.Id;
				wi.Fields["Remaining Work"].Value = wi.Fields["Original Estimate"].Value;
				try
				{
					wi.Save();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				/*
				var nwi = _store.GetWorkItem(wi.Id);
				SetListViewItem(nwi, lvi, true);
				*/
				counter++;
				backgroundWorker.ReportProgress(Convert.ToInt32(Convert.ToDecimal(counter) / Convert.ToDecimal(maxCount)) * 100);
			}

		}

		private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			progressBar.Value = e.ProgressPercentage;
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			progressBar.Visible = false;
			progressBar.SendToBack();
			LoadItems();
			Cursor = Cursors.Default;
		}
	}
}
