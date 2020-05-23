using Printers.View;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Printers
{
    public partial class MainForm : Form
    {
        private readonly float leftSideMenu_maxWidth = 250F;
        private bool leftSideMenu_isCollapsed = false;

        private readonly float filterMenu_maxHeight = 120F;
        private bool filterMenu_isCollapsed = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void типыУстройствToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void collapseBtn_Click(object sender, EventArgs e)
        {
            int sleep_time = 5;
            int itter_count = 5;
            if (leftSideMenu_isCollapsed)
            {
                collapseBtn.Text = "<";
                leftSideMenu_isCollapsed = false;

                for (int i = 0; i < itter_count; i++) {
                    mainLayoutPanel.ColumnStyles[0].Width = Math.Min(mainLayoutPanel.ColumnStyles[0].Width + leftSideMenu_maxWidth / itter_count, leftSideMenu_maxWidth);
                    mainLayoutPanel.Refresh();
                    Thread.Sleep(sleep_time);
                }
            }
            else {
                collapseBtn.Text = ">";
                leftSideMenu_isCollapsed = true;
                for (int i = 0; i < itter_count; i++)
                {
                    mainLayoutPanel.ColumnStyles[0].Width = Math.Max(mainLayoutPanel.ColumnStyles[0].Width - leftSideMenu_maxWidth / itter_count, 0);
                    mainLayoutPanel.Refresh();
                    Thread.Sleep(sleep_time);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainLayoutPanel.ColumnStyles[0].Width = leftSideMenu_maxWidth;
            CommonElements.Init();
            refreshTree();

            mainLayoutPanel.RowStyles[0].Height = 0;
            filterCollapseBtn.Text = "▼ Фильтр ▼";

            creatorCB.DataSource = CommonElements.Creators;
            creatorCB.DisplayMember = "Name";

            deviceTypeCB.DataSource = CommonElements.DeviceTypes;
            deviceTypeCB.DisplayMember = "Name";

            statementCB.DataSource = CommonElements.Statements;
            statementCB.DisplayMember = "Name";

            deviceTable.Rows.Add(-1, "[Имя устройства]", "[Инвент. номер]", "[Тип устройства]", "[Статус устройства]", "Подробнее");
        }

        private void refreshTree() {
            treeMenu.Nodes.Clear();
            treeMenu.Nodes.Add(CommonElements.DepTreeRoot);

        }

        private void treeMenu_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeMenu.SelectedNode != null)
                treeMenu.SelectedNode.BackColor = treeMenu.BackColor;
        }

        private void treeMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeMenu.SelectedNode.BackColor = Color.LightBlue;
        }

        private void filterCollapseBtn_Click(object sender, EventArgs e)
        {
            int sleep_time = 5;
            int itter_count = 5;
            if (filterMenu_isCollapsed)
            {
                filterCollapseBtn.Text = "▲ Фильтр ▲";
                filterMenu_isCollapsed = false;

                for (int i = 0; i < itter_count; i++)
                {
                    mainLayoutPanel.RowStyles[0].Height = Math.Min(mainLayoutPanel.RowStyles[0].Height + filterMenu_maxHeight / itter_count, filterMenu_maxHeight);
                    mainLayoutPanel.Refresh();
                    Thread.Sleep(sleep_time);
                }
            }
            else
            {
                filterCollapseBtn.Text = "▼ Фильтр ▼";
                filterMenu_isCollapsed = true;

                for (int i = 0; i < itter_count; i++)
                {
                    mainLayoutPanel.RowStyles[0].Height = Math.Max(mainLayoutPanel.RowStyles[0].Height - filterMenu_maxHeight / itter_count, 0);
                    mainLayoutPanel.Refresh();
                    Thread.Sleep(sleep_time);
                }
            }
        }

        private void структурныеПодразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepartmentForm().ShowDialog();
        }

        private void типToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeviceTypeForm().ShowDialog();
        }

        private void производительУстройствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreatorForm().ShowDialog();
        }

        private void типРасхожныхМатериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UsingMatherialForm().ShowDialog();
        }

        private void параметрыПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConnectionPropertiesForm().ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewDeviceForm().ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deviceTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == deviceTable.Columns["More"].Index)
                new DeviceInfoForm().ShowDialog();
        }
    }
}
