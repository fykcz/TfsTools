using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Fyk.Tfs.TfsCommonControls;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace Fyk.Tfs.AlertsExplorer
{
	public partial class MainWindow : Form, IMasterFormHandler
	{
		private Dictionary<int, WIDetail> _details = new Dictionary<int, WIDetail>();

		public MainWindow()
		{
			InitializeComponent();
#if DEBUG
			tfsUrlAndProjects.Url = Utils.TfsUrl;
#endif
		}

		public void WindowMsg(WorkItem workItem, MsgTypes msgType)
		{
			throw new NotImplementedException();
		}

		private void allSelCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in wiListView.Items)
				lvi.Checked = allSelCheckBox.Checked;
		}

		private void loadItemsButton_Click(object sender, EventArgs e)
		{
			LoadItems();
		}
		private void SetListViewItem(Subscription subscription, ListViewItem listViewItem, bool update = false)
		{
			if (update)
			{
				listViewItem.SubItems[1].Text = subscription.EventType;
				listViewItem.SubItems[2].Text = subscription.Device;
				listViewItem.SubItems[3].Text = subscription.Subscriber;
				listViewItem.SubItems[4].Text = subscription.DeliveryPreference.Address;

			}
			else
			{
				listViewItem.SubItems.Add(subscription.EventType);
				listViewItem.SubItems.Add(subscription.Device);
				listViewItem.SubItems.Add(subscription.Subscriber);
				listViewItem.SubItems.Add(subscription.DeliveryPreference.Address);
			}
			listViewItem.Tag = subscription;
		}
		private void LoadItems()
		{
			Cursor = Cursors.WaitCursor;
			var projectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(tfsUrlAndProjects.Url));

			IEventService es = projectCollection.GetService<IEventService>();
			List<Subscription> subs = es.GetAllEventSubscriptions().ToList<Subscription>();
			wiListView.Items.Clear();
			foreach (Subscription s in subs)
			{
				var lvi = wiListView.Items.Add(s.ID.ToString());
				SetListViewItem(s, lvi);
			}
			Cursor = Cursors.Default;

		}
		private void wiListView_DoubleClick(object sender, EventArgs e)
		{
			var x = new SubscriptionDetail();
			var lvi = wiListView.SelectedItems[0];
			var wi = (Subscription)lvi.Tag;
			x.FilterText = wi.ConditionString;
			x.Show();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (var x in _details.Values)
				x.ParentClose();
		}

	}
}
