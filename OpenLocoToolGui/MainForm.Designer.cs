﻿namespace OpenLocoToolGui
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			lbLogs = new ListBox();
			objectDirBrowser = new FolderBrowserDialog();
			tbFileFilter = new TextBox();
			lblFilenameRegex = new Label();
			saveFileDialog1 = new SaveFileDialog();
			flpImageTable = new FlowLayoutPanel();
			scObjectAndLogs = new SplitContainer();
			tcObjectOverview = new TabControl();
			tpObjectView = new TabPage();
			tcSubObjectView = new TabControl();
			tpObjectS5Header = new TabPage();
			pgS5Header = new PropertyGrid();
			tpObjectObjHeader = new TabPage();
			pgObjHeader = new PropertyGrid();
			tpObjectObject = new TabPage();
			pgObject = new PropertyGrid();
			tpObjectStringTable = new TabPage();
			ucStringTable = new StringTableUserControl();
			tpObjectGraphicsTable = new TabPage();
			scImageViewer = new SplitContainer();
			tbCurrentPage = new TextBox();
			btnPagePrevious = new Button();
			btnPageNext = new Button();
			tpObjectDump = new TabPage();
			scAnnnotationDump = new SplitContainer();
			tvDATDumpAnnotations = new TreeView();
			rtbDATDumpView = new RichTextBox();
			scTop = new SplitContainer();
			tcFileSelector = new TabControl();
			tabPage2 = new TabPage();
			tvObjType = new TreeView();
			tabPage1 = new TabPage();
			tvFileTree = new TreeView();
			pnFileFilter = new Panel();
			cbVanillaObjects = new CheckBox();
			menuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			objectDirectoriesToolStripMenuItem = new ToolStripMenuItem();
			setObjectDirectoryToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			dataDirectoriesToolStripMenuItem = new ToolStripMenuItem();
			setDataDirectoryToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			setPaletteToolStripMenuItem = new ToolStripMenuItem();
			recreateIndexToolStripMenuItem = new ToolStripMenuItem();
			saveChangesToolStripMenuItem = new ToolStripMenuItem();
			imgContextMenu = new ContextMenuStrip(components);
			imgContextMenuSave = new ToolStripMenuItem();
			goToHeaderInDumpToolStripMenuItem = new ToolStripMenuItem();
			headerToolStripMenuItem = new ToolStripMenuItem();
			pictureDataToolStripMenuItem = new ToolStripMenuItem();
			locoObjectBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)scObjectAndLogs).BeginInit();
			scObjectAndLogs.Panel1.SuspendLayout();
			scObjectAndLogs.Panel2.SuspendLayout();
			scObjectAndLogs.SuspendLayout();
			tcObjectOverview.SuspendLayout();
			tpObjectView.SuspendLayout();
			tcSubObjectView.SuspendLayout();
			tpObjectS5Header.SuspendLayout();
			tpObjectObjHeader.SuspendLayout();
			tpObjectObject.SuspendLayout();
			tpObjectStringTable.SuspendLayout();
			tpObjectGraphicsTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)scImageViewer).BeginInit();
			scImageViewer.Panel1.SuspendLayout();
			scImageViewer.Panel2.SuspendLayout();
			scImageViewer.SuspendLayout();
			tpObjectDump.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)scAnnnotationDump).BeginInit();
			scAnnnotationDump.Panel1.SuspendLayout();
			scAnnnotationDump.Panel2.SuspendLayout();
			scAnnnotationDump.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)scTop).BeginInit();
			scTop.Panel1.SuspendLayout();
			scTop.Panel2.SuspendLayout();
			scTop.SuspendLayout();
			tcFileSelector.SuspendLayout();
			tabPage2.SuspendLayout();
			tabPage1.SuspendLayout();
			pnFileFilter.SuspendLayout();
			menuStrip.SuspendLayout();
			imgContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)locoObjectBindingSource).BeginInit();
			SuspendLayout();
			// 
			// lbLogs
			// 
			lbLogs.Dock = DockStyle.Fill;
			lbLogs.FormattingEnabled = true;
			lbLogs.HorizontalScrollbar = true;
			lbLogs.ItemHeight = 32;
			lbLogs.Location = new Point(0, 0);
			lbLogs.Margin = new Padding(6);
			lbLogs.Name = "lbLogs";
			lbLogs.SelectionMode = SelectionMode.None;
			lbLogs.Size = new Size(1658, 276);
			lbLogs.TabIndex = 17;
			// 
			// tbFileFilter
			// 
			tbFileFilter.BorderStyle = BorderStyle.FixedSingle;
			tbFileFilter.Dock = DockStyle.Top;
			tbFileFilter.Location = new Point(7, 58);
			tbFileFilter.Margin = new Padding(7, 9, 7, 9);
			tbFileFilter.Name = "tbFileFilter";
			tbFileFilter.Size = new Size(549, 39);
			tbFileFilter.TabIndex = 24;
			tbFileFilter.TextChanged += tbFileFilter_TextChanged;
			// 
			// lblFilenameRegex
			// 
			lblFilenameRegex.Dock = DockStyle.Top;
			lblFilenameRegex.Location = new Point(7, 9);
			lblFilenameRegex.Margin = new Padding(7, 9, 7, 9);
			lblFilenameRegex.Name = "lblFilenameRegex";
			lblFilenameRegex.Size = new Size(549, 49);
			lblFilenameRegex.TabIndex = 25;
			lblFilenameRegex.Text = "Filename Filter";
			lblFilenameRegex.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// flpImageTable
			// 
			flpImageTable.AutoScroll = true;
			flpImageTable.BorderStyle = BorderStyle.FixedSingle;
			flpImageTable.Dock = DockStyle.Fill;
			flpImageTable.FlowDirection = FlowDirection.TopDown;
			flpImageTable.Location = new Point(0, 0);
			flpImageTable.Margin = new Padding(6);
			flpImageTable.Name = "flpImageTable";
			flpImageTable.Size = new Size(1608, 1056);
			flpImageTable.TabIndex = 30;
			// 
			// scObjectAndLogs
			// 
			scObjectAndLogs.Dock = DockStyle.Fill;
			scObjectAndLogs.Location = new Point(0, 0);
			scObjectAndLogs.Margin = new Padding(6);
			scObjectAndLogs.Name = "scObjectAndLogs";
			scObjectAndLogs.Orientation = Orientation.Horizontal;
			// 
			// scObjectAndLogs.Panel1
			// 
			scObjectAndLogs.Panel1.Controls.Add(tcObjectOverview);
			// 
			// scObjectAndLogs.Panel2
			// 
			scObjectAndLogs.Panel2.Controls.Add(lbLogs);
			scObjectAndLogs.Size = new Size(1658, 1527);
			scObjectAndLogs.SplitterDistance = 1242;
			scObjectAndLogs.SplitterWidth = 9;
			scObjectAndLogs.TabIndex = 31;
			// 
			// tcObjectOverview
			// 
			tcObjectOverview.Controls.Add(tpObjectView);
			tcObjectOverview.Controls.Add(tpObjectDump);
			tcObjectOverview.Dock = DockStyle.Fill;
			tcObjectOverview.Location = new Point(0, 0);
			tcObjectOverview.Margin = new Padding(6);
			tcObjectOverview.Name = "tcObjectOverview";
			tcObjectOverview.SelectedIndex = 0;
			tcObjectOverview.Size = new Size(1658, 1242);
			tcObjectOverview.TabIndex = 34;
			// 
			// tpObjectView
			// 
			tpObjectView.Controls.Add(tcSubObjectView);
			tpObjectView.Location = new Point(8, 46);
			tpObjectView.Margin = new Padding(6);
			tpObjectView.Name = "tpObjectView";
			tpObjectView.Padding = new Padding(6);
			tpObjectView.Size = new Size(1642, 1188);
			tpObjectView.TabIndex = 0;
			tpObjectView.Text = "Object View";
			tpObjectView.UseVisualStyleBackColor = true;
			// 
			// tcSubObjectView
			// 
			tcSubObjectView.Controls.Add(tpObjectS5Header);
			tcSubObjectView.Controls.Add(tpObjectObjHeader);
			tcSubObjectView.Controls.Add(tpObjectObject);
			tcSubObjectView.Controls.Add(tpObjectStringTable);
			tcSubObjectView.Controls.Add(tpObjectGraphicsTable);
			tcSubObjectView.Dock = DockStyle.Fill;
			tcSubObjectView.Location = new Point(6, 6);
			tcSubObjectView.Name = "tcSubObjectView";
			tcSubObjectView.SelectedIndex = 0;
			tcSubObjectView.Size = new Size(1630, 1176);
			tcSubObjectView.TabIndex = 33;
			// 
			// tpObjectS5Header
			// 
			tpObjectS5Header.Controls.Add(pgS5Header);
			tpObjectS5Header.Location = new Point(8, 46);
			tpObjectS5Header.Name = "tpObjectS5Header";
			tpObjectS5Header.Padding = new Padding(3);
			tpObjectS5Header.Size = new Size(1614, 1122);
			tpObjectS5Header.TabIndex = 0;
			tpObjectS5Header.Text = "S5 Header";
			tpObjectS5Header.UseVisualStyleBackColor = true;
			// 
			// pgS5Header
			// 
			pgS5Header.Dock = DockStyle.Fill;
			pgS5Header.HelpVisible = false;
			pgS5Header.Location = new Point(3, 3);
			pgS5Header.Margin = new Padding(6);
			pgS5Header.Name = "pgS5Header";
			pgS5Header.Size = new Size(1608, 1116);
			pgS5Header.TabIndex = 22;
			pgS5Header.ToolbarVisible = false;
			// 
			// tpObjectObjHeader
			// 
			tpObjectObjHeader.Controls.Add(pgObjHeader);
			tpObjectObjHeader.Location = new Point(8, 46);
			tpObjectObjHeader.Name = "tpObjectObjHeader";
			tpObjectObjHeader.Padding = new Padding(3);
			tpObjectObjHeader.Size = new Size(1614, 1122);
			tpObjectObjHeader.TabIndex = 1;
			tpObjectObjHeader.Text = "Object Header";
			tpObjectObjHeader.UseVisualStyleBackColor = true;
			// 
			// pgObjHeader
			// 
			pgObjHeader.Dock = DockStyle.Fill;
			pgObjHeader.HelpVisible = false;
			pgObjHeader.Location = new Point(3, 3);
			pgObjHeader.Margin = new Padding(6);
			pgObjHeader.Name = "pgObjHeader";
			pgObjHeader.Size = new Size(1608, 1116);
			pgObjHeader.TabIndex = 23;
			pgObjHeader.ToolbarVisible = false;
			// 
			// tpObjectObject
			// 
			tpObjectObject.Controls.Add(pgObject);
			tpObjectObject.Location = new Point(8, 46);
			tpObjectObject.Name = "tpObjectObject";
			tpObjectObject.Padding = new Padding(3);
			tpObjectObject.Size = new Size(1614, 1122);
			tpObjectObject.TabIndex = 2;
			tpObjectObject.Text = "Object";
			tpObjectObject.UseVisualStyleBackColor = true;
			// 
			// pgObject
			// 
			pgObject.Dock = DockStyle.Fill;
			pgObject.HelpVisible = false;
			pgObject.Location = new Point(3, 3);
			pgObject.Margin = new Padding(6);
			pgObject.Name = "pgObject";
			pgObject.Size = new Size(1608, 1116);
			pgObject.TabIndex = 24;
			pgObject.ToolbarVisible = false;
			// 
			// tpObjectStringTable
			// 
			tpObjectStringTable.Controls.Add(ucStringTable);
			tpObjectStringTable.Location = new Point(8, 46);
			tpObjectStringTable.Name = "tpObjectStringTable";
			tpObjectStringTable.Padding = new Padding(3);
			tpObjectStringTable.Size = new Size(1614, 1122);
			tpObjectStringTable.TabIndex = 3;
			tpObjectStringTable.Text = "Strings";
			tpObjectStringTable.UseVisualStyleBackColor = true;
			// 
			// ucStringTable
			// 
			ucStringTable.Dock = DockStyle.Fill;
			ucStringTable.Location = new Point(3, 3);
			ucStringTable.Name = "ucStringTable";
			ucStringTable.Size = new Size(1608, 1116);
			ucStringTable.TabIndex = 0;
			// 
			// tpObjectGraphicsTable
			// 
			tpObjectGraphicsTable.Controls.Add(scImageViewer);
			tpObjectGraphicsTable.Location = new Point(8, 46);
			tpObjectGraphicsTable.Name = "tpObjectGraphicsTable";
			tpObjectGraphicsTable.Padding = new Padding(3);
			tpObjectGraphicsTable.Size = new Size(1614, 1122);
			tpObjectGraphicsTable.TabIndex = 4;
			tpObjectGraphicsTable.Text = "Graphics";
			tpObjectGraphicsTable.UseVisualStyleBackColor = true;
			// 
			// scImageViewer
			// 
			scImageViewer.Dock = DockStyle.Fill;
			scImageViewer.IsSplitterFixed = true;
			scImageViewer.Location = new Point(3, 3);
			scImageViewer.Margin = new Padding(6);
			scImageViewer.Name = "scImageViewer";
			scImageViewer.Orientation = Orientation.Horizontal;
			// 
			// scImageViewer.Panel1
			// 
			scImageViewer.Panel1.Controls.Add(flpImageTable);
			// 
			// scImageViewer.Panel2
			// 
			scImageViewer.Panel2.Controls.Add(tbCurrentPage);
			scImageViewer.Panel2.Controls.Add(btnPagePrevious);
			scImageViewer.Panel2.Controls.Add(btnPageNext);
			scImageViewer.Size = new Size(1608, 1116);
			scImageViewer.SplitterDistance = 1056;
			scImageViewer.SplitterWidth = 9;
			scImageViewer.TabIndex = 32;
			// 
			// tbCurrentPage
			// 
			tbCurrentPage.BorderStyle = BorderStyle.FixedSingle;
			tbCurrentPage.Dock = DockStyle.Bottom;
			tbCurrentPage.Enabled = false;
			tbCurrentPage.Location = new Point(470, 12);
			tbCurrentPage.Margin = new Padding(6);
			tbCurrentPage.Name = "tbCurrentPage";
			tbCurrentPage.Size = new Size(715, 39);
			tbCurrentPage.TabIndex = 33;
			tbCurrentPage.TextAlign = HorizontalAlignment.Center;
			// 
			// btnPagePrevious
			// 
			btnPagePrevious.Dock = DockStyle.Left;
			btnPagePrevious.Location = new Point(0, 0);
			btnPagePrevious.Margin = new Padding(6);
			btnPagePrevious.Name = "btnPagePrevious";
			btnPagePrevious.Size = new Size(470, 51);
			btnPagePrevious.TabIndex = 0;
			btnPagePrevious.Text = "Previous Page";
			btnPagePrevious.UseVisualStyleBackColor = true;
			btnPagePrevious.Click += btnPagePrevious_Click;
			// 
			// btnPageNext
			// 
			btnPageNext.Dock = DockStyle.Right;
			btnPageNext.Location = new Point(1185, 0);
			btnPageNext.Margin = new Padding(6);
			btnPageNext.Name = "btnPageNext";
			btnPageNext.Size = new Size(423, 51);
			btnPageNext.TabIndex = 31;
			btnPageNext.Text = "Next Page";
			btnPageNext.UseVisualStyleBackColor = true;
			btnPageNext.Click += btnPageNext_Click;
			// 
			// tpObjectDump
			// 
			tpObjectDump.Controls.Add(scAnnnotationDump);
			tpObjectDump.Location = new Point(8, 46);
			tpObjectDump.Margin = new Padding(6);
			tpObjectDump.Name = "tpObjectDump";
			tpObjectDump.Padding = new Padding(6);
			tpObjectDump.Size = new Size(1642, 1188);
			tpObjectDump.TabIndex = 1;
			tpObjectDump.Text = "Object Data";
			tpObjectDump.UseVisualStyleBackColor = true;
			// 
			// scAnnnotationDump
			// 
			scAnnnotationDump.Dock = DockStyle.Fill;
			scAnnnotationDump.Location = new Point(6, 6);
			scAnnnotationDump.Margin = new Padding(6);
			scAnnnotationDump.Name = "scAnnnotationDump";
			// 
			// scAnnnotationDump.Panel1
			// 
			scAnnnotationDump.Panel1.AutoScroll = true;
			scAnnnotationDump.Panel1.Controls.Add(tvDATDumpAnnotations);
			// 
			// scAnnnotationDump.Panel2
			// 
			scAnnnotationDump.Panel2.Controls.Add(rtbDATDumpView);
			scAnnnotationDump.Size = new Size(1630, 1176);
			scAnnnotationDump.SplitterDistance = 562;
			scAnnnotationDump.SplitterWidth = 7;
			scAnnnotationDump.TabIndex = 2;
			// 
			// tvDATDumpAnnotations
			// 
			tvDATDumpAnnotations.Dock = DockStyle.Fill;
			tvDATDumpAnnotations.Location = new Point(0, 0);
			tvDATDumpAnnotations.Margin = new Padding(6);
			tvDATDumpAnnotations.Name = "tvDATDumpAnnotations";
			tvDATDumpAnnotations.Size = new Size(562, 1176);
			tvDATDumpAnnotations.TabIndex = 1;
			tvDATDumpAnnotations.AfterSelect += dataDumpAnnotations_AfterSelect;
			// 
			// rtbDATDumpView
			// 
			rtbDATDumpView.Dock = DockStyle.Fill;
			rtbDATDumpView.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
			rtbDATDumpView.HideSelection = false;
			rtbDATDumpView.Location = new Point(0, 0);
			rtbDATDumpView.Margin = new Padding(6);
			rtbDATDumpView.Name = "rtbDATDumpView";
			rtbDATDumpView.ReadOnly = true;
			rtbDATDumpView.ShowSelectionMargin = true;
			rtbDATDumpView.Size = new Size(1061, 1176);
			rtbDATDumpView.TabIndex = 0;
			rtbDATDumpView.Text = "";
			rtbDATDumpView.WordWrap = false;
			// 
			// scTop
			// 
			scTop.Dock = DockStyle.Fill;
			scTop.Location = new Point(7, 53);
			scTop.Margin = new Padding(6);
			scTop.Name = "scTop";
			// 
			// scTop.Panel1
			// 
			scTop.Panel1.Controls.Add(tcFileSelector);
			scTop.Panel1.Controls.Add(pnFileFilter);
			// 
			// scTop.Panel2
			// 
			scTop.Panel2.Controls.Add(scObjectAndLogs);
			scTop.Size = new Size(2228, 1527);
			scTop.SplitterDistance = 563;
			scTop.SplitterWidth = 7;
			scTop.TabIndex = 33;
			// 
			// tcFileSelector
			// 
			tcFileSelector.Controls.Add(tabPage2);
			tcFileSelector.Controls.Add(tabPage1);
			tcFileSelector.Dock = DockStyle.Fill;
			tcFileSelector.Location = new Point(0, 158);
			tcFileSelector.Margin = new Padding(6);
			tcFileSelector.Name = "tcFileSelector";
			tcFileSelector.SelectedIndex = 0;
			tcFileSelector.Size = new Size(563, 1369);
			tcFileSelector.TabIndex = 29;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(tvObjType);
			tabPage2.Location = new Point(8, 46);
			tabPage2.Margin = new Padding(6);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(6);
			tabPage2.Size = new Size(547, 1315);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Category";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// tvObjType
			// 
			tvObjType.Dock = DockStyle.Fill;
			tvObjType.Location = new Point(6, 6);
			tvObjType.Margin = new Padding(6);
			tvObjType.Name = "tvObjType";
			tvObjType.Size = new Size(535, 1303);
			tvObjType.TabIndex = 26;
			tvObjType.AfterSelect += tv_AfterSelect;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(tvFileTree);
			tabPage1.Location = new Point(8, 46);
			tabPage1.Margin = new Padding(6);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(6);
			tabPage1.Size = new Size(547, 1315);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "File";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tvFileTree
			// 
			tvFileTree.Dock = DockStyle.Fill;
			tvFileTree.Location = new Point(6, 6);
			tvFileTree.Margin = new Padding(6);
			tvFileTree.Name = "tvFileTree";
			tvFileTree.Size = new Size(535, 1303);
			tvFileTree.TabIndex = 1;
			tvFileTree.AfterSelect += tv_AfterSelect;
			// 
			// pnFileFilter
			// 
			pnFileFilter.Controls.Add(cbVanillaObjects);
			pnFileFilter.Controls.Add(tbFileFilter);
			pnFileFilter.Controls.Add(lblFilenameRegex);
			pnFileFilter.Dock = DockStyle.Top;
			pnFileFilter.Location = new Point(0, 0);
			pnFileFilter.Margin = new Padding(7, 9, 7, 9);
			pnFileFilter.Name = "pnFileFilter";
			pnFileFilter.Padding = new Padding(7, 9, 7, 9);
			pnFileFilter.Size = new Size(563, 158);
			pnFileFilter.TabIndex = 30;
			// 
			// cbVanillaObjects
			// 
			cbVanillaObjects.AutoSize = true;
			cbVanillaObjects.Dock = DockStyle.Top;
			cbVanillaObjects.Location = new Point(7, 97);
			cbVanillaObjects.Margin = new Padding(6);
			cbVanillaObjects.Name = "cbVanillaObjects";
			cbVanillaObjects.Size = new Size(549, 36);
			cbVanillaObjects.TabIndex = 26;
			cbVanillaObjects.Text = "Vanilla Objects Only";
			cbVanillaObjects.UseVisualStyleBackColor = true;
			cbVanillaObjects.CheckedChanged += cbVanillaObjects_CheckedChanged;
			// 
			// menuStrip
			// 
			menuStrip.ImageScalingSize = new Size(32, 32);
			menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip.Location = new Point(7, 9);
			menuStrip.Name = "menuStrip";
			menuStrip.Padding = new Padding(11, 4, 0, 4);
			menuStrip.Size = new Size(2228, 44);
			menuStrip.TabIndex = 23;
			menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { objectDirectoriesToolStripMenuItem, dataDirectoriesToolStripMenuItem, setPaletteToolStripMenuItem, recreateIndexToolStripMenuItem, saveChangesToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(71, 36);
			fileToolStripMenuItem.Text = "File";
			// 
			// objectDirectoriesToolStripMenuItem
			// 
			objectDirectoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setObjectDirectoryToolStripMenuItem, toolStripSeparator1 });
			objectDirectoriesToolStripMenuItem.Name = "objectDirectoriesToolStripMenuItem";
			objectDirectoriesToolStripMenuItem.Size = new Size(435, 44);
			objectDirectoriesToolStripMenuItem.Text = "ObjData Directories";
			// 
			// setObjectDirectoryToolStripMenuItem
			// 
			setObjectDirectoryToolStripMenuItem.Name = "setObjectDirectoryToolStripMenuItem";
			setObjectDirectoryToolStripMenuItem.Size = new Size(245, 44);
			setObjectDirectoryToolStripMenuItem.Text = "Add New";
			setObjectDirectoryToolStripMenuItem.Click += setObjectDirectoryToolStripMenuItem_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(242, 6);
			// 
			// dataDirectoriesToolStripMenuItem
			// 
			dataDirectoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setDataDirectoryToolStripMenuItem, toolStripSeparator2 });
			dataDirectoriesToolStripMenuItem.Name = "dataDirectoriesToolStripMenuItem";
			dataDirectoriesToolStripMenuItem.Size = new Size(435, 44);
			dataDirectoriesToolStripMenuItem.Text = "Data Directories";
			// 
			// setDataDirectoryToolStripMenuItem
			// 
			setDataDirectoryToolStripMenuItem.Name = "setDataDirectoryToolStripMenuItem";
			setDataDirectoryToolStripMenuItem.Size = new Size(245, 44);
			setDataDirectoryToolStripMenuItem.Text = "Add New";
			setDataDirectoryToolStripMenuItem.Click += setDataDirectoryToolStripMenuItem_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(242, 6);
			// 
			// setPaletteToolStripMenuItem
			// 
			setPaletteToolStripMenuItem.Name = "setPaletteToolStripMenuItem";
			setPaletteToolStripMenuItem.Size = new Size(435, 44);
			setPaletteToolStripMenuItem.Text = "Load Palette Bitmap";
			setPaletteToolStripMenuItem.Click += setPaletteToolStripMenuItem_Click;
			// 
			// recreateIndexToolStripMenuItem
			// 
			recreateIndexToolStripMenuItem.Name = "recreateIndexToolStripMenuItem";
			recreateIndexToolStripMenuItem.Size = new Size(435, 44);
			recreateIndexToolStripMenuItem.Text = "Recreate Index";
			recreateIndexToolStripMenuItem.Click += recreateIndexToolStripMenuItem_Click;
			// 
			// saveChangesToolStripMenuItem
			// 
			saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
			saveChangesToolStripMenuItem.Size = new Size(435, 44);
			saveChangesToolStripMenuItem.Text = "Save Object Changes (WIP)";
			saveChangesToolStripMenuItem.Click += saveChangesToolStripMenuItem_Click;
			// 
			// imgContextMenu
			// 
			imgContextMenu.ImageScalingSize = new Size(32, 32);
			imgContextMenu.Items.AddRange(new ToolStripItem[] { imgContextMenuSave, goToHeaderInDumpToolStripMenuItem });
			imgContextMenu.Name = "imgContextMenu";
			imgContextMenu.Size = new Size(253, 80);
			// 
			// imgContextMenuSave
			// 
			imgContextMenuSave.Name = "imgContextMenuSave";
			imgContextMenuSave.Size = new Size(252, 38);
			imgContextMenuSave.Text = "Export Image";
			imgContextMenuSave.Click += imgContextMenuSave_Click;
			// 
			// goToHeaderInDumpToolStripMenuItem
			// 
			goToHeaderInDumpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { headerToolStripMenuItem, pictureDataToolStripMenuItem });
			goToHeaderInDumpToolStripMenuItem.Name = "goToHeaderInDumpToolStripMenuItem";
			goToHeaderInDumpToolStripMenuItem.Size = new Size(252, 38);
			goToHeaderInDumpToolStripMenuItem.Text = "Select In Dump";
			// 
			// headerToolStripMenuItem
			// 
			headerToolStripMenuItem.Name = "headerToolStripMenuItem";
			headerToolStripMenuItem.Size = new Size(276, 44);
			headerToolStripMenuItem.Text = "Header";
			headerToolStripMenuItem.Click += headerToolStripMenuItem_Click;
			// 
			// pictureDataToolStripMenuItem
			// 
			pictureDataToolStripMenuItem.Name = "pictureDataToolStripMenuItem";
			pictureDataToolStripMenuItem.Size = new Size(276, 44);
			pictureDataToolStripMenuItem.Text = "Picture Data";
			pictureDataToolStripMenuItem.Click += pictureDataToolStripMenuItem_Click;
			// 
			// locoObjectBindingSource
			// 
			locoObjectBindingSource.DataSource = typeof(OpenLocoTool.DatFileParsing.LocoObject);
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2242, 1589);
			Controls.Add(scTop);
			Controls.Add(menuStrip);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip;
			Margin = new Padding(6);
			Name = "MainForm";
			Padding = new Padding(7, 9, 7, 9);
			Text = "OpenLocoTool";
			Load += MainForm_Load;
			scObjectAndLogs.Panel1.ResumeLayout(false);
			scObjectAndLogs.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)scObjectAndLogs).EndInit();
			scObjectAndLogs.ResumeLayout(false);
			tcObjectOverview.ResumeLayout(false);
			tpObjectView.ResumeLayout(false);
			tcSubObjectView.ResumeLayout(false);
			tpObjectS5Header.ResumeLayout(false);
			tpObjectObjHeader.ResumeLayout(false);
			tpObjectObject.ResumeLayout(false);
			tpObjectStringTable.ResumeLayout(false);
			tpObjectGraphicsTable.ResumeLayout(false);
			scImageViewer.Panel1.ResumeLayout(false);
			scImageViewer.Panel2.ResumeLayout(false);
			scImageViewer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)scImageViewer).EndInit();
			scImageViewer.ResumeLayout(false);
			tpObjectDump.ResumeLayout(false);
			scAnnnotationDump.Panel1.ResumeLayout(false);
			scAnnnotationDump.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)scAnnnotationDump).EndInit();
			scAnnnotationDump.ResumeLayout(false);
			scTop.Panel1.ResumeLayout(false);
			scTop.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)scTop).EndInit();
			scTop.ResumeLayout(false);
			tcFileSelector.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			pnFileFilter.ResumeLayout(false);
			pnFileFilter.PerformLayout();
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			imgContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)locoObjectBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ListBox lbLogs;
		private FolderBrowserDialog objectDirBrowser;
		private TextBox tbFileFilter;
		private Label lblFilenameRegex;
		private SaveFileDialog saveFileDialog1;
		private FlowLayoutPanel flpImageTable;
		private SplitContainer scTop;
		private SplitContainer scObjectAndLogs;
		private Panel pnFileFilter;
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem objectDirectoriesToolStripMenuItem;
		private ToolStripMenuItem recreateIndexToolStripMenuItem;
		private ToolStripMenuItem saveChangesToolStripMenuItem;
		private ToolStripMenuItem setPaletteToolStripMenuItem;
		private ToolStripMenuItem dataDirectoriesToolStripMenuItem;
		private ContextMenuStrip imgContextMenu;
		private ToolStripMenuItem imgContextMenuSave;
		private SplitContainer scImageViewer;
		private Button btnPageNext;
		private Button btnPagePrevious;
		private CheckBox cbVanillaObjects;
		private TextBox tbCurrentPage;
		private TabControl tcObjectOverview;
		private TabPage tpObjectView;
		private TabPage tpObjectDump;
		private TabControl tcFileSelector;
		private TabPage tabPage2;
		private TreeView tvObjType;
		private TabPage tabPage1;
		private TreeView tvFileTree;
		private RichTextBox rtbDATDumpView;
		private TreeView tvDATDumpAnnotations;
		private ToolStripMenuItem goToHeaderInDumpToolStripMenuItem;
		private ToolStripMenuItem headerToolStripMenuItem;
		private ToolStripMenuItem pictureDataToolStripMenuItem;
		private SplitContainer scAnnnotationDump;
		private ToolStripMenuItem setObjectDirectoryToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem setDataDirectoryToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private TabControl tcSubObjectView;
		private TabPage tpObjectS5Header;
		private TabPage tpObjectObjHeader;
		private TabPage tpObjectObject;
		private TabPage tpObjectStringTable;
		private TabPage tpObjectGraphicsTable;
		private BindingSource locoObjectBindingSource;
		private PropertyGrid pgS5Header;
		private PropertyGrid pgObjHeader;
		private PropertyGrid pgObject;
		private StringTableUserControl ucStringTable;
	}
}