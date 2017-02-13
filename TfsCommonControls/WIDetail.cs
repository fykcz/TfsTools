using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Windows.Forms;

namespace Fyk.Tfs.TfsCommonControls
{
    public partial class WIDetail : Form
    {
        private WorkItem _workItem;
        private IMasterFormHandler _masterWindow;
        private MsgTypes _closeType = MsgTypes.Nothing;
        private bool _parentClose = false;

        public WIDetail()
        {
            InitializeComponent();
        }

        public void LoadWI(WorkItem workItem, IMasterFormHandler masterWindow)
        {
            wiFormControl.Item = _workItem = workItem;
            _masterWindow = masterWindow;
            Text = string.Format("{0} - {1}", workItem.Id, workItem.Title);
        }

        private void WIDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_workItem.IsDirty)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", string.Format("{0} - Save", _workItem.Id), _parentClose ? MessageBoxButtons.YesNo : MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _workItem.Save();
                        _closeType = MsgTypes.ChangeAndClose;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (result == DialogResult.No)
                {
                    _workItem.Reset();
                    _closeType = MsgTypes.Close;
                }
                else
                    e.Cancel = true;
            }
        }

        public void ParentClose()
        {
            _parentClose = true;
            Close();
        }
        private void WIDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            _masterWindow.WindowMsg(_workItem, _closeType);
        }
    }
}
