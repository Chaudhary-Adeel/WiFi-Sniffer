namespace WifiSniffer.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorQuit = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPacketsInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainerCapturedPackets = new System.Windows.Forms.SplitContainer();
            this.listViewPackets = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSourceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSourcePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDestinationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDestinationPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProtocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainerPacketInfo = new System.Windows.Forms.SplitContainer();
            this.treeViewPacketInfo = new System.Windows.Forms.TreeView();
            this.dataGridViewPacketData = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAscii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openCaptureFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCapturedPackets)).BeginInit();
            this.splitContainerCapturedPackets.Panel1.SuspendLayout();
            this.splitContainerCapturedPackets.Panel2.SuspendLayout();
            this.splitContainerCapturedPackets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPacketInfo)).BeginInit();
            this.splitContainerPacketInfo.Panel1.SuspendLayout();
            this.splitContainerPacketInfo.Panel2.SuspendLayout();
            this.splitContainerPacketInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacketData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.captureToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(916, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparatorQuit,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openFileToolStripMenuItem.Text = "Open...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparatorQuit
            // 
            this.toolStripSeparatorQuit.Name = "toolStripSeparatorQuit";
            this.toolStripSeparatorQuit.Size = new System.Drawing.Size(120, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.quitToolStripMenuItem.Text = "Quit ";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devicesToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.captureToolStripMenuItem.Text = "Capture";
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.devicesToolStripMenuItem.Text = "Devices...";
            this.devicesToolStripMenuItem.Click += new System.EventHandler(this.devicesToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Enabled = false;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelState,
            this.toolStripStatusLabelPacketsInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 589);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(916, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(136, 17);
            this.toolStripStatusLabelState.Text = "Ready to load or capture";
            // 
            // toolStripStatusLabelPacketsInfo
            // 
            this.toolStripStatusLabelPacketsInfo.Name = "toolStripStatusLabelPacketsInfo";
            this.toolStripStatusLabelPacketsInfo.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabelPacketsInfo.Text = "|No packets";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripTextBox1,
            this.toolStripLabel3,
            this.toolStripTextBox2,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.toolStripButton4,
            this.toolStripSeparator6,
            this.toolStripButton5,
            this.toolStripSeparator7,
            this.toolStripLabel5});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(916, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(150, 22);
            this.toolStripLabel1.Text = "Start Hosted Network --> ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel2.Text = "SSID";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(26, 22);
            this.toolStripLabel3.Text = "Key";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Start Hosted Network";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel4.Text = "          ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Start";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Stop";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Clear";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Help";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Enabled = false;
            this.toolStripLabel5.Font = new System.Drawing.Font("Courier New", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(224, 22);
            this.toolStripLabel5.Text = "  Muhammad Adeel aka The Stoker";
            // 
            // splitContainerCapturedPackets
            // 
            this.splitContainerCapturedPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCapturedPackets.Location = new System.Drawing.Point(0, 49);
            this.splitContainerCapturedPackets.Name = "splitContainerCapturedPackets";
            this.splitContainerCapturedPackets.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCapturedPackets.Panel1
            // 
            this.splitContainerCapturedPackets.Panel1.Controls.Add(this.listViewPackets);
            // 
            // splitContainerCapturedPackets.Panel2
            // 
            this.splitContainerCapturedPackets.Panel2.Controls.Add(this.splitContainerPacketInfo);
            this.splitContainerCapturedPackets.Size = new System.Drawing.Size(916, 540);
            this.splitContainerCapturedPackets.SplitterDistance = 270;
            this.splitContainerCapturedPackets.TabIndex = 4;
            // 
            // listViewPackets
            // 
            this.listViewPackets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderSource,
            this.columnHeaderSourceName,
            this.columnHeaderSourcePort,
            this.columnHeaderDestination,
            this.columnHeaderDestinationName,
            this.columnHeaderDestinationPort,
            this.columnHeaderProtocol,
            this.columnHeaderInfo});
            this.listViewPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPackets.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPackets.FullRowSelect = true;
            this.listViewPackets.HideSelection = false;
            this.listViewPackets.Location = new System.Drawing.Point(0, 0);
            this.listViewPackets.MultiSelect = false;
            this.listViewPackets.Name = "listViewPackets";
            this.listViewPackets.Size = new System.Drawing.Size(916, 270);
            this.listViewPackets.TabIndex = 2;
            this.listViewPackets.UseCompatibleStateImageBehavior = false;
            this.listViewPackets.View = System.Windows.Forms.View.Details;
            this.listViewPackets.SelectedIndexChanged += new System.EventHandler(this.listViewPackets_SelectedIndexChanged);
            this.listViewPackets.Resize += new System.EventHandler(this.listViewPackets_Resize);
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Sr. No";
            this.columnHeaderNumber.Width = 56;
            // 
            // columnHeaderSource
            // 
            this.columnHeaderSource.Text = "Source";
            this.columnHeaderSource.Width = 100;
            // 
            // columnHeaderSourceName
            // 
            this.columnHeaderSourceName.Text = "Src. Name";
            this.columnHeaderSourceName.Width = 110;
            // 
            // columnHeaderSourcePort
            // 
            this.columnHeaderSourcePort.Text = "Src. Port";
            this.columnHeaderSourcePort.Width = 78;
            // 
            // columnHeaderDestination
            // 
            this.columnHeaderDestination.Text = "Destination";
            this.columnHeaderDestination.Width = 100;
            // 
            // columnHeaderDestinationName
            // 
            this.columnHeaderDestinationName.Text = "Dst. Name";
            this.columnHeaderDestinationName.Width = 110;
            // 
            // columnHeaderDestinationPort
            // 
            this.columnHeaderDestinationPort.Text = "Dst. Port";
            this.columnHeaderDestinationPort.Width = 75;
            // 
            // columnHeaderProtocol
            // 
            this.columnHeaderProtocol.Text = "Protocol";
            this.columnHeaderProtocol.Width = 72;
            // 
            // columnHeaderInfo
            // 
            this.columnHeaderInfo.Text = "Information";
            this.columnHeaderInfo.Width = 231;
            // 
            // splitContainerPacketInfo
            // 
            this.splitContainerPacketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPacketInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPacketInfo.Name = "splitContainerPacketInfo";
            // 
            // splitContainerPacketInfo.Panel1
            // 
            this.splitContainerPacketInfo.Panel1.Controls.Add(this.treeViewPacketInfo);
            // 
            // splitContainerPacketInfo.Panel2
            // 
            this.splitContainerPacketInfo.Panel2.Controls.Add(this.dataGridViewPacketData);
            this.splitContainerPacketInfo.Size = new System.Drawing.Size(916, 266);
            this.splitContainerPacketInfo.SplitterDistance = 379;
            this.splitContainerPacketInfo.TabIndex = 1;
            // 
            // treeViewPacketInfo
            // 
            this.treeViewPacketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPacketInfo.Location = new System.Drawing.Point(0, 0);
            this.treeViewPacketInfo.Name = "treeViewPacketInfo";
            this.treeViewPacketInfo.ShowLines = false;
            this.treeViewPacketInfo.Size = new System.Drawing.Size(379, 266);
            this.treeViewPacketInfo.TabIndex = 0;
            // 
            // dataGridViewPacketData
            // 
            this.dataGridViewPacketData.AllowUserToAddRows = false;
            this.dataGridViewPacketData.AllowUserToDeleteRows = false;
            this.dataGridViewPacketData.AllowUserToResizeColumns = false;
            this.dataGridViewPacketData.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            this.dataGridViewPacketData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPacketData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacketData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.ColumnA,
            this.ColumnB,
            this.ColumnC,
            this.ColumnD,
            this.ColumnE,
            this.ColumnF,
            this.ColumnAscii});
            this.dataGridViewPacketData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPacketData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPacketData.Name = "dataGridViewPacketData";
            this.dataGridViewPacketData.ReadOnly = true;
            this.dataGridViewPacketData.RowHeadersWidth = 62;
            this.dataGridViewPacketData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPacketData.RowTemplate.Height = 20;
            this.dataGridViewPacketData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPacketData.Size = new System.Drawing.Size(533, 266);
            this.dataGridViewPacketData.TabIndex = 0;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "0";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Width = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 23;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 23;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 23;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 23;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 23;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 23;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 23;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 23;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 23;
            // 
            // ColumnA
            // 
            this.ColumnA.HeaderText = "A";
            this.ColumnA.Name = "ColumnA";
            this.ColumnA.ReadOnly = true;
            this.ColumnA.Width = 23;
            // 
            // ColumnB
            // 
            this.ColumnB.HeaderText = "B";
            this.ColumnB.Name = "ColumnB";
            this.ColumnB.ReadOnly = true;
            this.ColumnB.Width = 23;
            // 
            // ColumnC
            // 
            this.ColumnC.HeaderText = "C";
            this.ColumnC.Name = "ColumnC";
            this.ColumnC.ReadOnly = true;
            this.ColumnC.Width = 23;
            // 
            // ColumnD
            // 
            this.ColumnD.HeaderText = "D";
            this.ColumnD.Name = "ColumnD";
            this.ColumnD.ReadOnly = true;
            this.ColumnD.Width = 23;
            // 
            // ColumnE
            // 
            this.ColumnE.HeaderText = "E";
            this.ColumnE.Name = "ColumnE";
            this.ColumnE.ReadOnly = true;
            this.ColumnE.Width = 23;
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "F";
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.ReadOnly = true;
            this.ColumnF.Width = 23;
            // 
            // ColumnAscii
            // 
            this.ColumnAscii.HeaderText = "ASCII";
            this.ColumnAscii.Name = "ColumnAscii";
            this.ColumnAscii.ReadOnly = true;
            // 
            // openCaptureFileDialog
            // 
            this.openCaptureFileDialog.DefaultExt = "pcap";
            this.openCaptureFileDialog.FileName = "*.pcap";
            this.openCaptureFileDialog.Filter = "Capture Files (*.pcap;*.cap)|*.pcap;*.cap|Text Documents (*.txt)|*.txt|All Files|" +
                "*.*";
            this.openCaptureFileDialog.SupportMultiDottedExtensions = true;
            this.openCaptureFileDialog.Title = "Select an output capture file";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pcap";
            this.saveFileDialog.FileName = "*.pcap";
            this.saveFileDialog.Filter = "Capture Files (*.pcap;*.cap)|*.pcap;*.cap|Text Documents (*.txt)|*.txt|All Files|" +
                "*.*";
            this.saveFileDialog.SupportMultiDottedExtensions = true;
            this.saveFileDialog.Title = "Save As";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Wi-Fi sniffer is Working in System Tray !";
            this.notifyIcon1.BalloonTipTitle = "Wi-Fi Sniffer";
            this.notifyIcon1.Text = "Minimize to Tray";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 611);
            this.Controls.Add(this.splitContainerCapturedPackets);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wi-Fi Sniffer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainerCapturedPackets.Panel1.ResumeLayout(false);
            this.splitContainerCapturedPackets.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCapturedPackets)).EndInit();
            this.splitContainerCapturedPackets.ResumeLayout(false);
            this.splitContainerPacketInfo.Panel1.ResumeLayout(false);
            this.splitContainerPacketInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPacketInfo)).EndInit();
            this.splitContainerPacketInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacketData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.SplitContainer splitContainerCapturedPackets;
        private System.Windows.Forms.ListView listViewPackets;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderSource;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceName;
        private System.Windows.Forms.ColumnHeader columnHeaderSourcePort;
        private System.Windows.Forms.ColumnHeader columnHeaderDestination;
        private System.Windows.Forms.ColumnHeader columnHeaderDestinationName;
        private System.Windows.Forms.ColumnHeader columnHeaderDestinationPort;
        private System.Windows.Forms.ColumnHeader columnHeaderProtocol;
        private System.Windows.Forms.ColumnHeader columnHeaderInfo;
        private System.Windows.Forms.SplitContainer splitContainerPacketInfo;
        private System.Windows.Forms.TreeView treeViewPacketInfo;
        private System.Windows.Forms.DataGridView dataGridViewPacketData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAscii;
        private System.Windows.Forms.OpenFileDialog openCaptureFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPacketsInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorQuit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

