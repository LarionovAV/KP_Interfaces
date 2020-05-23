namespace Printers
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.collapseBtn = new System.Windows.Forms.Button();
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.filterCollapseBtn = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.devTypeLabel = new System.Windows.Forms.Label();
            this.statementLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.deviceTypeCB = new System.Windows.Forms.ComboBox();
            this.statementCB = new System.Windows.Forms.ComboBox();
            this.creatorCB = new System.Windows.Forms.ComboBox();
            this.acceptFilterBtn = new System.Windows.Forms.Button();
            this.deviceListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addDeviceBtn = new System.Windows.Forms.PictureBox();
            this.updateListBtn = new System.Windows.Forms.PictureBox();
            this.deviceTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.More = new System.Windows.Forms.DataGridViewLinkColumn();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.устройстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.структурныеПодразделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производительУстройствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типРасхожныхМатериаловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.параметрыПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayoutPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.deviceListPanel.SuspendLayout();
            this.btnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDeviceBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateListBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTable)).BeginInit();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 955F));
            this.mainLayoutPanel.Controls.Add(this.collapseBtn, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.treeMenu, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.filterCollapseBtn, 2, 1);
            this.mainLayoutPanel.Controls.Add(this.filterPanel, 2, 0);
            this.mainLayoutPanel.Controls.Add(this.deviceListPanel, 2, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(1282, 810);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // collapseBtn
            // 
            this.collapseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collapseBtn.Location = new System.Drawing.Point(300, 2);
            this.collapseBtn.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.collapseBtn.Name = "collapseBtn";
            this.mainLayoutPanel.SetRowSpan(this.collapseBtn, 3);
            this.collapseBtn.Size = new System.Drawing.Size(24, 806);
            this.collapseBtn.TabIndex = 1;
            this.collapseBtn.Text = "<";
            this.collapseBtn.UseVisualStyleBackColor = true;
            this.collapseBtn.Click += new System.EventHandler(this.collapseBtn_Click);
            // 
            // treeMenu
            // 
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMenu.Location = new System.Drawing.Point(4, 4);
            this.treeMenu.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.treeMenu.Name = "treeMenu";
            this.mainLayoutPanel.SetRowSpan(this.treeMenu, 3);
            this.treeMenu.Size = new System.Drawing.Size(296, 802);
            this.treeMenu.TabIndex = 2;
            this.treeMenu.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeMenu_BeforeSelect);
            this.treeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMenu_AfterSelect);
            // 
            // filterCollapseBtn
            // 
            this.filterCollapseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterCollapseBtn.Location = new System.Drawing.Point(331, 152);
            this.filterCollapseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.filterCollapseBtn.Name = "filterCollapseBtn";
            this.filterCollapseBtn.Size = new System.Drawing.Size(947, 29);
            this.filterCollapseBtn.TabIndex = 3;
            this.filterCollapseBtn.Text = "▼";
            this.filterCollapseBtn.UseVisualStyleBackColor = true;
            this.filterCollapseBtn.Click += new System.EventHandler(this.filterCollapseBtn_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.ColumnCount = 3;
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 547F));
            this.filterPanel.Controls.Add(this.devTypeLabel, 0, 1);
            this.filterPanel.Controls.Add(this.statementLabel, 0, 3);
            this.filterPanel.Controls.Add(this.creatorLabel, 0, 2);
            this.filterPanel.Controls.Add(this.deviceTypeCB, 1, 1);
            this.filterPanel.Controls.Add(this.statementCB, 1, 3);
            this.filterPanel.Controls.Add(this.creatorCB, 1, 2);
            this.filterPanel.Controls.Add(this.acceptFilterBtn, 2, 4);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Location = new System.Drawing.Point(331, 4);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.RowCount = 5;
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.filterPanel.Size = new System.Drawing.Size(947, 140);
            this.filterPanel.TabIndex = 4;
            // 
            // devTypeLabel
            // 
            this.devTypeLabel.AutoSize = true;
            this.devTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devTypeLabel.Location = new System.Drawing.Point(4, 12);
            this.devTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.devTypeLabel.Name = "devTypeLabel";
            this.devTypeLabel.Size = new System.Drawing.Size(125, 27);
            this.devTypeLabel.TabIndex = 0;
            this.devTypeLabel.Text = "Тип устройства";
            this.devTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statementLabel
            // 
            this.statementLabel.AutoSize = true;
            this.statementLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statementLabel.Location = new System.Drawing.Point(4, 66);
            this.statementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(125, 27);
            this.statementLabel.TabIndex = 1;
            this.statementLabel.Text = "Статус";
            this.statementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creatorLabel.Location = new System.Drawing.Point(4, 39);
            this.creatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(125, 27);
            this.creatorLabel.TabIndex = 2;
            this.creatorLabel.Text = "Производитель";
            this.creatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deviceTypeCB
            // 
            this.deviceTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceTypeCB.FormattingEnabled = true;
            this.deviceTypeCB.Location = new System.Drawing.Point(137, 16);
            this.deviceTypeCB.Margin = new System.Windows.Forms.Padding(4);
            this.deviceTypeCB.Name = "deviceTypeCB";
            this.deviceTypeCB.Size = new System.Drawing.Size(259, 27);
            this.deviceTypeCB.TabIndex = 3;
            // 
            // statementCB
            // 
            this.statementCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statementCB.FormattingEnabled = true;
            this.statementCB.Location = new System.Drawing.Point(137, 70);
            this.statementCB.Margin = new System.Windows.Forms.Padding(4);
            this.statementCB.Name = "statementCB";
            this.statementCB.Size = new System.Drawing.Size(259, 27);
            this.statementCB.TabIndex = 4;
            // 
            // creatorCB
            // 
            this.creatorCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creatorCB.FormattingEnabled = true;
            this.creatorCB.Location = new System.Drawing.Point(137, 43);
            this.creatorCB.Margin = new System.Windows.Forms.Padding(4);
            this.creatorCB.Name = "creatorCB";
            this.creatorCB.Size = new System.Drawing.Size(259, 27);
            this.creatorCB.TabIndex = 5;
            // 
            // acceptFilterBtn
            // 
            this.acceptFilterBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.acceptFilterBtn.Location = new System.Drawing.Point(404, 97);
            this.acceptFilterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.acceptFilterBtn.Name = "acceptFilterBtn";
            this.acceptFilterBtn.Size = new System.Drawing.Size(100, 39);
            this.acceptFilterBtn.TabIndex = 6;
            this.acceptFilterBtn.Text = "Принять";
            this.acceptFilterBtn.UseVisualStyleBackColor = true;
            // 
            // deviceListPanel
            // 
            this.deviceListPanel.ColumnCount = 1;
            this.deviceListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 949F));
            this.deviceListPanel.Controls.Add(this.btnsPanel, 0, 0);
            this.deviceListPanel.Controls.Add(this.deviceTable, 0, 1);
            this.deviceListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceListPanel.Location = new System.Drawing.Point(330, 187);
            this.deviceListPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deviceListPanel.Name = "deviceListPanel";
            this.deviceListPanel.RowCount = 2;
            this.deviceListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.deviceListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.deviceListPanel.Size = new System.Drawing.Size(949, 621);
            this.deviceListPanel.TabIndex = 5;
            // 
            // btnsPanel
            // 
            this.btnsPanel.ColumnCount = 3;
            this.btnsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.btnsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.btnsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.btnsPanel.Controls.Add(this.addDeviceBtn, 0, 0);
            this.btnsPanel.Controls.Add(this.updateListBtn, 1, 0);
            this.btnsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsPanel.Location = new System.Drawing.Point(0, 0);
            this.btnsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnsPanel.Name = "btnsPanel";
            this.btnsPanel.RowCount = 1;
            this.btnsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.btnsPanel.Size = new System.Drawing.Size(200, 39);
            this.btnsPanel.TabIndex = 0;
            // 
            // addDeviceBtn
            // 
            this.addDeviceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDeviceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDeviceBtn.Image = ((System.Drawing.Image)(resources.GetObject("addDeviceBtn.Image")));
            this.addDeviceBtn.Location = new System.Drawing.Point(0, 0);
            this.addDeviceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addDeviceBtn.Name = "addDeviceBtn";
            this.addDeviceBtn.Size = new System.Drawing.Size(43, 39);
            this.addDeviceBtn.TabIndex = 0;
            this.addDeviceBtn.TabStop = false;
            // 
            // updateListBtn
            // 
            this.updateListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateListBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateListBtn.Image = global::Printers.Properties.Resources.updateBtn;
            this.updateListBtn.Location = new System.Drawing.Point(43, 0);
            this.updateListBtn.Margin = new System.Windows.Forms.Padding(0);
            this.updateListBtn.Name = "updateListBtn";
            this.updateListBtn.Size = new System.Drawing.Size(43, 39);
            this.updateListBtn.TabIndex = 1;
            this.updateListBtn.TabStop = false;
            // 
            // deviceTable
            // 
            this.deviceTable.AllowUserToAddRows = false;
            this.deviceTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deviceTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deviceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NetName,
            this.Number,
            this.Type,
            this.State,
            this.More});
            this.deviceTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceTable.Location = new System.Drawing.Point(4, 43);
            this.deviceTable.Margin = new System.Windows.Forms.Padding(4);
            this.deviceTable.Name = "deviceTable";
            this.deviceTable.ReadOnly = true;
            this.deviceTable.RowHeadersVisible = false;
            this.deviceTable.RowHeadersWidth = 51;
            this.deviceTable.Size = new System.Drawing.Size(941, 574);
            this.deviceTable.TabIndex = 1;
            this.deviceTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deviceTable_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NetName
            // 
            this.NetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NetName.FillWeight = 25F;
            this.NetName.HeaderText = "Имя устройства";
            this.NetName.MinimumWidth = 6;
            this.NetName.Name = "NetName";
            this.NetName.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.FillWeight = 25F;
            this.Number.HeaderText = "Инвентаризационный номер";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.FillWeight = 15F;
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.State.FillWeight = 15F;
            this.State.HeaderText = "Статус";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // More
            // 
            this.More.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.More.FillWeight = 10F;
            this.More.HeaderText = "Подробнее";
            this.More.MinimumWidth = 6;
            this.More.Name = "More";
            this.More.ReadOnly = true;
            this.More.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.More.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // topMenu
            // 
            this.topMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.устройстваToolStripMenuItem,
            this.базаДанныхToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.topMenu.Size = new System.Drawing.Size(1282, 28);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // устройстваToolStripMenuItem
            // 
            this.устройстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.посмотретьСписокToolStripMenuItem});
            this.устройстваToolStripMenuItem.Name = "устройстваToolStripMenuItem";
            this.устройстваToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.устройстваToolStripMenuItem.Text = "Устройства";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // посмотретьСписокToolStripMenuItem
            // 
            this.посмотретьСписокToolStripMenuItem.Name = "посмотретьСписокToolStripMenuItem";
            this.посмотретьСписокToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.посмотретьСписокToolStripMenuItem.Text = "Обновить список";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.структурныеПодразделенияToolStripMenuItem,
            this.типToolStripMenuItem,
            this.производительУстройствToolStripMenuItem,
            this.типРасхожныхМатериаловToolStripMenuItem,
            this.toolStripSeparator1,
            this.параметрыПодключенияToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // структурныеПодразделенияToolStripMenuItem
            // 
            this.структурныеПодразделенияToolStripMenuItem.Name = "структурныеПодразделенияToolStripMenuItem";
            this.структурныеПодразделенияToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.структурныеПодразделенияToolStripMenuItem.Text = "Структурное подразделение";
            this.структурныеПодразделенияToolStripMenuItem.Click += new System.EventHandler(this.структурныеПодразделенияToolStripMenuItem_Click);
            // 
            // типToolStripMenuItem
            // 
            this.типToolStripMenuItem.Name = "типToolStripMenuItem";
            this.типToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.типToolStripMenuItem.Text = "Тип устройств";
            this.типToolStripMenuItem.Click += new System.EventHandler(this.типToolStripMenuItem_Click);
            // 
            // производительУстройствToolStripMenuItem
            // 
            this.производительУстройствToolStripMenuItem.Name = "производительУстройствToolStripMenuItem";
            this.производительУстройствToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.производительУстройствToolStripMenuItem.Text = "Производитель устройств";
            this.производительУстройствToolStripMenuItem.Click += new System.EventHandler(this.производительУстройствToolStripMenuItem_Click);
            // 
            // типРасхожныхМатериаловToolStripMenuItem
            // 
            this.типРасхожныхМатериаловToolStripMenuItem.Name = "типРасхожныхМатериаловToolStripMenuItem";
            this.типРасхожныхМатериаловToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.типРасхожныхМатериаловToolStripMenuItem.Text = "Тип расходных материалов";
            this.типРасхожныхМатериаловToolStripMenuItem.Click += new System.EventHandler(this.типРасхожныхМатериаловToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(287, 6);
            // 
            // параметрыПодключенияToolStripMenuItem
            // 
            this.параметрыПодключенияToolStripMenuItem.Name = "параметрыПодключенияToolStripMenuItem";
            this.параметрыПодключенияToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.параметрыПодключенияToolStripMenuItem.Text = "Параметры подключения";
            this.параметрыПодключенияToolStripMenuItem.Click += new System.EventHandler(this.параметрыПодключенияToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 838);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.topMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1300, 830);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет печатной техники";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainLayoutPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.deviceListPanel.ResumeLayout(false);
            this.btnsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addDeviceBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateListBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTable)).EndInit();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem устройстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem структурныеПодразделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производительУстройствToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типРасхожныхМатериаловToolStripMenuItem;
        private System.Windows.Forms.Button filterCollapseBtn;
        private System.Windows.Forms.Button collapseBtn;
        private System.Windows.Forms.TreeView treeMenu;
        private System.Windows.Forms.TableLayoutPanel filterPanel;
        private System.Windows.Forms.Label devTypeLabel;
        private System.Windows.Forms.Label statementLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.ComboBox deviceTypeCB;
        private System.Windows.Forms.ComboBox statementCB;
        private System.Windows.Forms.ComboBox creatorCB;
        private System.Windows.Forms.Button acceptFilterBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem параметрыПодключенияToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel deviceListPanel;
        private System.Windows.Forms.TableLayoutPanel btnsPanel;
        private System.Windows.Forms.PictureBox addDeviceBtn;
        private System.Windows.Forms.PictureBox updateListBtn;
        private System.Windows.Forms.DataGridView deviceTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewLinkColumn More;
    }
}

