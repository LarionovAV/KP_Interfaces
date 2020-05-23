namespace Printers
{
    partial class DepartmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.deptsTree = new System.Windows.Forms.TreeView();
            this.rightsidePanel = new System.Windows.Forms.TableLayoutPanel();
            this.newDepPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newDepLabel = new System.Windows.Forms.Label();
            this.NewDepTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.depList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.rightsidePanel.SuspendLayout();
            this.newDepPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 613F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.mainPanel.Controls.Add(this.deptsTree, 0, 0);
            this.mainPanel.Controls.Add(this.rightsidePanel, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(834, 561);
            this.mainPanel.TabIndex = 0;
            // 
            // deptsTree
            // 
            this.deptsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deptsTree.Location = new System.Drawing.Point(3, 3);
            this.deptsTree.Name = "deptsTree";
            this.deptsTree.Size = new System.Drawing.Size(182, 555);
            this.deptsTree.TabIndex = 0;
            // 
            // rightsidePanel
            // 
            this.rightsidePanel.ColumnCount = 1;
            this.rightsidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rightsidePanel.Controls.Add(this.newDepPanel, 0, 0);
            this.rightsidePanel.Controls.Add(this.depList, 0, 1);
            this.rightsidePanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.rightsidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightsidePanel.Location = new System.Drawing.Point(190, 2);
            this.rightsidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightsidePanel.Name = "rightsidePanel";
            this.rightsidePanel.RowCount = 3;
            this.rightsidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.rightsidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.rightsidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.rightsidePanel.Size = new System.Drawing.Size(642, 557);
            this.rightsidePanel.TabIndex = 1;
            // 
            // newDepPanel
            // 
            this.newDepPanel.ColumnCount = 3;
            this.newDepPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.newDepPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.newDepPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.newDepPanel.Controls.Add(this.newDepLabel, 0, 0);
            this.newDepPanel.Controls.Add(this.NewDepTB, 1, 0);
            this.newDepPanel.Controls.Add(this.addBtn, 2, 0);
            this.newDepPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newDepPanel.Location = new System.Drawing.Point(3, 3);
            this.newDepPanel.Name = "newDepPanel";
            this.newDepPanel.RowCount = 1;
            this.newDepPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.newDepPanel.Size = new System.Drawing.Size(636, 39);
            this.newDepPanel.TabIndex = 0;
            // 
            // newDepLabel
            // 
            this.newDepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newDepLabel.AutoSize = true;
            this.newDepLabel.Location = new System.Drawing.Point(3, 11);
            this.newDepLabel.Name = "newDepLabel";
            this.newDepLabel.Size = new System.Drawing.Size(152, 16);
            this.newDepLabel.TabIndex = 0;
            this.newDepLabel.Text = "Новое подразделение:";
            // 
            // NewDepTB
            // 
            this.NewDepTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewDepTB.Location = new System.Drawing.Point(161, 8);
            this.NewDepTB.Name = "NewDepTB";
            this.NewDepTB.Size = new System.Drawing.Size(336, 23);
            this.NewDepTB.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.Location = new System.Drawing.Point(503, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 31);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // depList
            // 
            this.depList.AllowUserToAddRows = false;
            this.depList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.depList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DepName,
            this.Update,
            this.Delete,
            this.action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.depList.DefaultCellStyle = dataGridViewCellStyle2;
            this.depList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depList.Location = new System.Drawing.Point(3, 48);
            this.depList.Name = "depList";
            this.depList.ReadOnly = true;
            this.depList.RowHeadersVisible = false;
            this.depList.Size = new System.Drawing.Size(636, 452);
            this.depList.TabIndex = 1;
            this.depList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.depList_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DepName
            // 
            this.DepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepName.FillWeight = 60F;
            this.DepName.HeaderText = "Название подразделения";
            this.DepName.Name = "DepName";
            this.DepName.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Update.FillWeight = 20F;
            this.Update.HeaderText = "Изменить";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.FillWeight = 20F;
            this.Delete.HeaderText = "Удалить";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // action
            // 
            this.action.HeaderText = "Действие";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.action.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 636F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 506);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 48);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.79848F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.20152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.Controls.Add(this.restoreBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveBtn, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 42);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // restoreBtn
            // 
            this.restoreBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.restoreBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.restoreBtn.Location = new System.Drawing.Point(429, 3);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(93, 36);
            this.restoreBtn.TabIndex = 2;
            this.restoreBtn.Text = "Отмена";
            this.restoreBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.saveBtn.Location = new System.Drawing.Point(534, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(93, 36);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подразделения";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.rightsidePanel.ResumeLayout(false);
            this.newDepPanel.ResumeLayout(false);
            this.newDepPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TreeView deptsTree;
        private System.Windows.Forms.TableLayoutPanel rightsidePanel;
        private System.Windows.Forms.TableLayoutPanel newDepPanel;
        private System.Windows.Forms.Label newDepLabel;
        private System.Windows.Forms.TextBox NewDepTB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView depList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.DataGridViewLinkColumn Update;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.Button restoreBtn;
    }
}