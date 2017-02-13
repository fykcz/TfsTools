using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fyk.Tfs.TfsCommonControls
{
    public partial class ItemWB : Form
    {
        public ItemWB()
        {
            InitializeComponent();
        }
        public void ShowItem(WorkItem item)
        {
            //webBrowser.Navigate(string.Format("http://vmwtfs:8080/tfs/DefaultCollection/CDCP/_workitems/edit/{0}", id));
            //var url = string.Format("http://vmwtfs:8080/tfs/web/wi.aspx?id={0}", id);
            //var url = string.Format("http://vmwtfs:8080/tfs/DefaultCollection/{0}/_workitems#_a=edit&id={1}", projectName, id);
            webBrowser.Navigate(Utils.GetUrlForEditWorkItem(item));
        }
    }
}
