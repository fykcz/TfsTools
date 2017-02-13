using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;

namespace Fyk.Tfs.HtmlDescriptionMigrator
{
    public class DetailWindowEventArgs : EventArgs
    {
        public DetailWindowEventArgs(WorkItem workItem):base()
        {
            WorkItem = workItem;
        }
        public WorkItem WorkItem { get; private set; }
    }

    public delegate void DetailWindowEventHandler(object sender, DetailWindowEventArgs e);
}
