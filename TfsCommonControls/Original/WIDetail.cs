using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Windows.Forms;

namespace Fyk.Tfs.TfsCommonControls
{
    public partial class WIDetail : Form
    {
        private WorkItem _workItem;
        public WIDetail()
        {
            InitializeComponent();
        }

        public void LoadWI(WorkItem workItem)
        {
            wiFormControl.Item = _workItem = workItem;
        }

        private void WIDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_workItem.IsDirty)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _workItem.Save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                    _workItem.Reset();
                else
                    e.Cancel = true;
            }
        }
    }
}
