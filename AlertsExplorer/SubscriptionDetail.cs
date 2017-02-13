using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fyk.Tfs.AlertsExplorer
{
	public partial class SubscriptionDetail : Form
	{
		public SubscriptionDetail()
		{
			InitializeComponent();
		}
		public string FilterText
		{
			get { return textBox.Text; }
			set { textBox.Text = value; }
		}

	}
}
