using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Fyk.Tfs.TfsCommonControls;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace Fyk.Tfs.TfsWatcher
{
	public partial class MainForm : Form
	{

		private readonly ContextMenu _contextMenu = new ContextMenu();
		private bool _inClose;

		public MainForm()
		{
			InitializeComponent();

			var mi = _contextMenu.MenuItems.Add("Show window", MenuShowWindow);
			mi.DefaultItem = true;
			_contextMenu.MenuItems.Add("Exit", MenuExit);
			notifyIcon.ContextMenu = _contextMenu;
		}

		/*
		protected override void OnLoad(EventArgs e)
		{
			//Visible = false;
			//ShowInTaskbar = false;

			base.OnLoad(e);
		}
		*/

		private void connectButton_Click(object sender, EventArgs e)
		{
			projectsListBox.Items.Clear();
			var pinfo = Utils.SelectTfsProjects();
			if (pinfo == null) return;
			urlTextBox.Text = pinfo.Url;
			foreach (var x in pinfo.SelectedProjects)
				projectsListBox.Items.Add(x.Name);

			if (projectsListBox.Items.Count > 0)
			{

			}
		}

		private void MenuShowWindow(object sender, EventArgs e)
		{
			Visible = true;
			ShowInTaskbar = true;
			notifyIcon.Visible = false;
		}

		private void MenuExit(object sender, EventArgs e)
		{
			_inClose = true;
			Application.Exit();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_inClose)
			{
				Visible = false;
				ShowInTaskbar = false;
				notifyIcon.Visible = true;
				e.Cancel = true;
			}
			else e.Cancel = false;
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (WindowState != FormWindowState.Minimized) return;
			Visible = ShowInTaskbar = false;
			notifyIcon.Visible = true;
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			MenuShowWindow(null, null);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var projectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(urlTextBox.Text));

			var workItemStore = projectCollection.GetService<WorkItemStore>();

			var project = workItemStore.Projects["ZEELANDIA"];
			//projectsListBox.Items.Clear();


			foreach (var sd in (from q in project.QueryHierarchy where q.Name.Equals("Shared Queries") from sq in ((QueryFolder)q) where sq.Name.Equals("After Due") select sq).OfType<QueryDefinition>())
			{
				textBox1.Text = sd.QueryText;
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			var projectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(urlTextBox.Text));

			var workItemStore = projectCollection.GetService<WorkItemStore>();
			var wic =
				workItemStore.Query(
					"SELECT * FROM WorkItems WHERE [Microsoft.VSTS.Scheduling.DueDate] < @today AND [System.State] = 'Active' ORDER BY [System.Id]");
			//			projectsListBox.Items.Clear();
			tasksListView.Items.Clear();
			//var first = true;
			foreach (WorkItem wi in wic)
			{
				if (!wi.Fields.Contains("Due Date")) continue;
				if (wi.Fields["Due Date"].Value == null) continue;

				var lvi = tasksListView.Items.Add(wi.Id.ToString(CultureInfo.InvariantCulture));
				lvi.SubItems.Add(wi.Project.Name);
				lvi.SubItems.Add(wi.Title);
				lvi.SubItems.Add(wi.State);
				lvi.SubItems.Add(wi.CreatedDate.ToString("dd.MM.yyyy hh:mm"));
				lvi.SubItems.Add(Convert.ToDateTime(wi.Fields["Due Date"].Value).ToString("dd.MM.yyyy"));
				lvi.Tag = wi;
				/*
				if (wi.Id != 1510) continue;
				foreach (Field f in wi.Fields)
					projectsListBox.Items.Add(f.FieldDefinition.Name);
				 */
				Cursor.Current = Cursors.Default;
			}
		}

		private void projectsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void exitToolStripButton_Click(object sender, EventArgs e)
		{
			MenuExit(null, null);
		}

		private void tasksListView_DoubleClick(object sender, EventArgs e)
		{
			if (tasksListView.SelectedItems.Count == 0) return;
			var wi = (WorkItem)tasksListView.SelectedItems[0].Tag;
			System.Diagnostics.Process.Start(Utils.GetUrlForEditWorkItem(wi));
			/*
			var wb = new ItemWB();
			wb.ShowItem(wi);
			wb.Show();
			*/
		}

		private void refreshToolStripButton_Click(object sender, EventArgs e)
		{

		}
	}
}

/*
SELECT [System.Id]
[Custom.HDTicket]
[System.WorkItemType]
[System.Title]
[System.AssignedTo]
[System.State]
[System.IterationPath]
[System.CreatedDate]
[Microsoft.VSTS.Common.ClosedDate]
[Microsoft.VSTS.Scheduling.FinishDate]
[Microsoft.VSTS.Scheduling.OriginalEstimate]
[Microsoft.VSTS.Scheduling.CompletedWork]
[Microsoft.VSTS.Scheduling.DueDate]
FROM WorkItems
WHERE [System.TeamProject] = @project AND [Microsoft.VSTS.Scheduling.DueDate] < @today AND [System.State] = 'Active' ORDER BY [System.Id]
 */
