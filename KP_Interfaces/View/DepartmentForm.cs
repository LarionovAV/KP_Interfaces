using System;
using System.Windows.Forms;

namespace Printers
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            deptsTree.Nodes.Add(CommonElements.DepTreeRoot.Clone() as TreeNode);
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
          //  Department.create(NewDepName.Text, Convert.ToInt32(deptsTree.SelectedNode.Name));
            refreshTree();
        }

        private void refreshTree() {
            CommonElements.refreshDepTree();
            deptsTree.Nodes.Clear();
            deptsTree.Nodes.Add(CommonElements.DepTreeRoot.Clone() as TreeNode);
        }

        private void depList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
