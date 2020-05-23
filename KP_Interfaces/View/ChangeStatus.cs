using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printers.View
{
    public partial class ChangeStatus : Form
    {
        public ChangeStatus()
        {
            InitializeComponent();
        }

        private void ChangeStatus_Load(object sender, EventArgs e)
        {
            DepTree.Nodes.Add(CommonElements.DepTreeRoot.Clone() as TreeNode);
        }

        private void Set_CheckedChanged(object sender, EventArgs e)
        {
            DepPanel.Enabled = Set.Checked;
        }
    }
}
