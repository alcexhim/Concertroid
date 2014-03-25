namespace Concertroid.Manager.Panels
{
    partial class LibraryExplorerPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryExplorerPanel));
            this.scExplorer = new System.Windows.Forms.SplitContainer();
            this.tvExplorer = new System.Windows.Forms.TreeView();
            this.mnuContext = new AwesomeControls.CommandBars.CBContextMenu(this.components);
            this.mnuContextAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextAddExisting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextViewLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextViewSmallIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextViewTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextViewThumbnails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSortSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextSortAscending = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSortDescending = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSortSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextSortMore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGroupSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextGroupAscending = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGroupDescending = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGroupSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextGroupMore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.imlSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlExplorer = new System.Windows.Forms.Panel();
            this.lvExplorer = new AwesomeControls.SystemControls.ListView();
            this.imlLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.scExplorer.Panel1.SuspendLayout();
            this.scExplorer.Panel2.SuspendLayout();
            this.scExplorer.SuspendLayout();
            this.mnuContext.SuspendLayout();
            this.pnlExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // scExplorer
            // 
            this.scExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scExplorer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scExplorer.Location = new System.Drawing.Point(0, 0);
            this.scExplorer.Name = "scExplorer";
            // 
            // scExplorer.Panel1
            // 
            this.scExplorer.Panel1.Controls.Add(this.tvExplorer);
            // 
            // scExplorer.Panel2
            // 
            this.scExplorer.Panel2.Controls.Add(this.pnlExplorer);
            this.scExplorer.Size = new System.Drawing.Size(646, 362);
            this.scExplorer.SplitterDistance = 138;
            this.scExplorer.TabIndex = 1;
            // 
            // tvExplorer
            // 
            this.tvExplorer.ContextMenuStrip = this.mnuContext;
            this.tvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvExplorer.HideSelection = false;
            this.tvExplorer.ImageIndex = 0;
            this.tvExplorer.ImageList = this.imlSmallIcons;
            this.tvExplorer.Location = new System.Drawing.Point(0, 0);
            this.tvExplorer.Name = "tvExplorer";
            this.tvExplorer.SelectedImageIndex = 0;
            this.tvExplorer.Size = new System.Drawing.Size(138, 362);
            this.tvExplorer.TabIndex = 0;
            this.tvExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvExplorer_AfterSelect);
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextAddNew,
            this.mnuContextAddExisting,
            this.mnuContextSep1,
            this.mnuContextView,
            this.mnuContextSort,
            this.mnuContextGroup,
            this.mnuContextRefresh,
            this.mnuContextSep2,
            this.mnuContextCut,
            this.mnuContextCopy,
            this.mnuContextPaste,
            this.mnuContextDelete,
            this.mnuContextRename,
            this.mnuContextSep3,
            this.mnuContextProperties});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(221, 308);
            // 
            // mnuContextAddNew
            // 
            this.mnuContextAddNew.Name = "mnuContextAddNew";
            this.mnuContextAddNew.ShortcutKeyDisplayString = "Ins";
            this.mnuContextAddNew.Size = new System.Drawing.Size(220, 22);
            this.mnuContextAddNew.Text = "Add Ne&w Item";
            // 
            // mnuContextAddExisting
            // 
            this.mnuContextAddExisting.Name = "mnuContextAddExisting";
            this.mnuContextAddExisting.ShortcutKeyDisplayString = "Shift+Ins";
            this.mnuContextAddExisting.Size = new System.Drawing.Size(220, 22);
            this.mnuContextAddExisting.Text = "Add Existin&g Item";
            // 
            // mnuContextSep1
            // 
            this.mnuContextSep1.Name = "mnuContextSep1";
            this.mnuContextSep1.Size = new System.Drawing.Size(217, 6);
            // 
            // mnuContextView
            // 
            this.mnuContextView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextViewLargeIcons,
            this.mnuContextViewSmallIcons,
            this.mnuContextViewList,
            this.mnuContextViewDetails,
            this.mnuContextViewTiles,
            this.mnuContextViewThumbnails});
            this.mnuContextView.Name = "mnuContextView";
            this.mnuContextView.Size = new System.Drawing.Size(220, 22);
            this.mnuContextView.Text = "&View";
            // 
            // mnuContextViewLargeIcons
            // 
            this.mnuContextViewLargeIcons.Name = "mnuContextViewLargeIcons";
            this.mnuContextViewLargeIcons.Size = new System.Drawing.Size(128, 22);
            this.mnuContextViewLargeIcons.Text = "La&rge icons";
            // 
            // mnuContextViewSmallIcons
            // 
            this.mnuContextViewSmallIcons.Name = "mnuContextViewSmallIcons";
            this.mnuContextViewSmallIcons.Size = new System.Drawing.Size(128, 22);
            this.mnuContextViewSmallIcons.Text = "Small ico&ns";
            // 
            // mnuContextViewList
            // 
            this.mnuContextViewList.Name = "mnuContextViewList";
            this.mnuContextViewList.Size = new System.Drawing.Size(128, 22);
            this.mnuContextViewList.Text = "&List";
            // 
            // mnuContextViewDetails
            // 
            this.mnuContextViewDetails.Name = "mnuContextViewDetails";
            this.mnuContextViewDetails.Size = new System.Drawing.Size(128, 22);
            this.mnuContextViewDetails.Text = "&Details";
            // 
            // mnuContextViewTiles
            // 
            this.mnuContextViewTiles.Name = "mnuContextViewTiles";
            this.mnuContextViewTiles.Size = new System.Drawing.Size(128, 22);
            this.mnuContextViewTiles.Text = "Tile&s";
            // 
            // mnuContextViewThumbnails
            // 
            this.mnuContextViewThumbnails.Name = "mnuContextViewThumbnails";
            this.mnuContextViewThumbnails.Size = new System.Drawing.Size(128, 22);
            this.mnuContextViewThumbnails.Text = "T&humbnails";
            // 
            // mnuContextSort
            // 
            this.mnuContextSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextSortSep1,
            this.mnuContextSortAscending,
            this.mnuContextSortDescending,
            this.mnuContextSortSep2,
            this.mnuContextSortMore});
            this.mnuContextSort.Name = "mnuContextSort";
            this.mnuContextSort.Size = new System.Drawing.Size(220, 22);
            this.mnuContextSort.Text = "S&ort by";
            // 
            // mnuContextSortSep1
            // 
            this.mnuContextSortSep1.Name = "mnuContextSortSep1";
            this.mnuContextSortSep1.Size = new System.Drawing.Size(126, 6);
            // 
            // mnuContextSortAscending
            // 
            this.mnuContextSortAscending.Name = "mnuContextSortAscending";
            this.mnuContextSortAscending.Size = new System.Drawing.Size(129, 22);
            this.mnuContextSortAscending.Text = "&Ascending";
            // 
            // mnuContextSortDescending
            // 
            this.mnuContextSortDescending.Name = "mnuContextSortDescending";
            this.mnuContextSortDescending.Size = new System.Drawing.Size(129, 22);
            this.mnuContextSortDescending.Text = "&Descending";
            // 
            // mnuContextSortSep2
            // 
            this.mnuContextSortSep2.Name = "mnuContextSortSep2";
            this.mnuContextSortSep2.Size = new System.Drawing.Size(126, 6);
            // 
            // mnuContextSortMore
            // 
            this.mnuContextSortMore.Name = "mnuContextSortMore";
            this.mnuContextSortMore.Size = new System.Drawing.Size(129, 22);
            this.mnuContextSortMore.Text = "&More...";
            // 
            // mnuContextGroup
            // 
            this.mnuContextGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextGroupSep1,
            this.mnuContextGroupAscending,
            this.mnuContextGroupDescending,
            this.mnuContextGroupSep2,
            this.mnuContextGroupMore});
            this.mnuContextGroup.Name = "mnuContextGroup";
            this.mnuContextGroup.Size = new System.Drawing.Size(220, 22);
            this.mnuContextGroup.Text = "Grou&p by";
            // 
            // mnuContextGroupSep1
            // 
            this.mnuContextGroupSep1.Name = "mnuContextGroupSep1";
            this.mnuContextGroupSep1.Size = new System.Drawing.Size(126, 6);
            // 
            // mnuContextGroupAscending
            // 
            this.mnuContextGroupAscending.Name = "mnuContextGroupAscending";
            this.mnuContextGroupAscending.Size = new System.Drawing.Size(129, 22);
            this.mnuContextGroupAscending.Text = "&Ascending";
            // 
            // mnuContextGroupDescending
            // 
            this.mnuContextGroupDescending.Name = "mnuContextGroupDescending";
            this.mnuContextGroupDescending.Size = new System.Drawing.Size(129, 22);
            this.mnuContextGroupDescending.Text = "&Descending";
            // 
            // mnuContextGroupSep2
            // 
            this.mnuContextGroupSep2.Name = "mnuContextGroupSep2";
            this.mnuContextGroupSep2.Size = new System.Drawing.Size(126, 6);
            // 
            // mnuContextGroupMore
            // 
            this.mnuContextGroupMore.Name = "mnuContextGroupMore";
            this.mnuContextGroupMore.Size = new System.Drawing.Size(129, 22);
            this.mnuContextGroupMore.Text = "&More...";
            // 
            // mnuContextRefresh
            // 
            this.mnuContextRefresh.Name = "mnuContextRefresh";
            this.mnuContextRefresh.ShortcutKeyDisplayString = "F5";
            this.mnuContextRefresh.Size = new System.Drawing.Size(220, 22);
            this.mnuContextRefresh.Text = "R&efresh";
            // 
            // mnuContextSep2
            // 
            this.mnuContextSep2.Name = "mnuContextSep2";
            this.mnuContextSep2.Size = new System.Drawing.Size(217, 6);
            // 
            // mnuContextCut
            // 
            this.mnuContextCut.Name = "mnuContextCut";
            this.mnuContextCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.mnuContextCut.Size = new System.Drawing.Size(220, 22);
            this.mnuContextCut.Text = "Cu&t";
            // 
            // mnuContextCopy
            // 
            this.mnuContextCopy.Name = "mnuContextCopy";
            this.mnuContextCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.mnuContextCopy.Size = new System.Drawing.Size(220, 22);
            this.mnuContextCopy.Text = "&Copy";
            // 
            // mnuContextPaste
            // 
            this.mnuContextPaste.Name = "mnuContextPaste";
            this.mnuContextPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.mnuContextPaste.Size = new System.Drawing.Size(220, 22);
            this.mnuContextPaste.Text = "&Paste";
            // 
            // mnuContextDelete
            // 
            this.mnuContextDelete.Name = "mnuContextDelete";
            this.mnuContextDelete.ShortcutKeyDisplayString = "Del";
            this.mnuContextDelete.Size = new System.Drawing.Size(220, 22);
            this.mnuContextDelete.Text = "&Delete";
            // 
            // mnuContextRename
            // 
            this.mnuContextRename.Name = "mnuContextRename";
            this.mnuContextRename.ShortcutKeyDisplayString = "F3";
            this.mnuContextRename.Size = new System.Drawing.Size(220, 22);
            this.mnuContextRename.Text = "Rena&me";
            // 
            // mnuContextSep3
            // 
            this.mnuContextSep3.Name = "mnuContextSep3";
            this.mnuContextSep3.Size = new System.Drawing.Size(217, 6);
            // 
            // mnuContextProperties
            // 
            this.mnuContextProperties.Name = "mnuContextProperties";
            this.mnuContextProperties.ShortcutKeyDisplayString = "Alt+Enter";
            this.mnuContextProperties.Size = new System.Drawing.Size(220, 22);
            this.mnuContextProperties.Text = "P&roperties...";
            // 
            // imlSmallIcons
            // 
            this.imlSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSmallIcons.ImageStream")));
            this.imlSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlSmallIcons.Images.SetKeyName(0, "BandMusician");
            this.imlSmallIcons.Images.SetKeyName(1, "GuestMusician");
            this.imlSmallIcons.Images.SetKeyName(2, "Properties");
            this.imlSmallIcons.Images.SetKeyName(3, "Concert");
            this.imlSmallIcons.Images.SetKeyName(4, "Libraries");
            this.imlSmallIcons.Images.SetKeyName(5, "Library");
            this.imlSmallIcons.Images.SetKeyName(6, "Performer");
            // 
            // pnlExplorer
            // 
            this.pnlExplorer.Controls.Add(this.lvExplorer);
            this.pnlExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExplorer.Location = new System.Drawing.Point(0, 0);
            this.pnlExplorer.Name = "pnlExplorer";
            this.pnlExplorer.Size = new System.Drawing.Size(504, 362);
            this.pnlExplorer.TabIndex = 0;
            // 
            // lvExplorer
            // 
            this.lvExplorer.ContextMenuStrip = this.mnuContext;
            this.lvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExplorer.FullRowSelect = true;
            this.lvExplorer.GridLines = true;
            this.lvExplorer.HideSelection = false;
            this.lvExplorer.LargeImageList = this.imlLargeIcons;
            this.lvExplorer.Location = new System.Drawing.Point(0, 0);
            this.lvExplorer.Name = "lvExplorer";
            this.lvExplorer.ShadeColor = System.Drawing.Color.WhiteSmoke;
            this.lvExplorer.Size = new System.Drawing.Size(504, 362);
            this.lvExplorer.SmallImageList = this.imlSmallIcons;
            this.lvExplorer.SortOrder = true;
            this.lvExplorer.TabIndex = 0;
            this.lvExplorer.UseCompatibleStateImageBehavior = false;
            this.lvExplorer.ItemActivate += new System.EventHandler(this.lvExplorer_ItemActivate);
            // 
            // imlLargeIcons
            // 
            this.imlLargeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLargeIcons.ImageStream")));
            this.imlLargeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLargeIcons.Images.SetKeyName(0, "BandMusician");
            this.imlLargeIcons.Images.SetKeyName(1, "GuestMusician");
            this.imlLargeIcons.Images.SetKeyName(2, "Properties");
            this.imlLargeIcons.Images.SetKeyName(3, "Concert");
            this.imlLargeIcons.Images.SetKeyName(4, "Libraries");
            this.imlLargeIcons.Images.SetKeyName(5, "Library");
            this.imlLargeIcons.Images.SetKeyName(6, "Performer");
            // 
            // LibraryExplorerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scExplorer);
            this.Name = "LibraryExplorerPanel";
            this.Size = new System.Drawing.Size(646, 362);
            this.scExplorer.Panel1.ResumeLayout(false);
            this.scExplorer.Panel2.ResumeLayout(false);
            this.scExplorer.ResumeLayout(false);
            this.mnuContext.ResumeLayout(false);
            this.pnlExplorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scExplorer;
        private System.Windows.Forms.TreeView tvExplorer;
        private System.Windows.Forms.Panel pnlExplorer;
        private AwesomeControls.SystemControls.ListView lvExplorer;
        private System.Windows.Forms.ImageList imlSmallIcons;
        private System.Windows.Forms.ImageList imlLargeIcons;
        private AwesomeControls.CommandBars.CBContextMenu mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuContextAddNew;
        private System.Windows.Forms.ToolStripMenuItem mnuContextAddExisting;
        private System.Windows.Forms.ToolStripSeparator mnuContextSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuContextView;
        private System.Windows.Forms.ToolStripMenuItem mnuContextViewLargeIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuContextViewSmallIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuContextViewList;
        private System.Windows.Forms.ToolStripMenuItem mnuContextViewDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuContextViewTiles;
        private System.Windows.Forms.ToolStripMenuItem mnuContextViewThumbnails;
        private System.Windows.Forms.ToolStripMenuItem mnuContextSort;
        private System.Windows.Forms.ToolStripSeparator mnuContextSortSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuContextSortAscending;
        private System.Windows.Forms.ToolStripMenuItem mnuContextSortDescending;
        private System.Windows.Forms.ToolStripSeparator mnuContextSortSep2;
        private System.Windows.Forms.ToolStripMenuItem mnuContextSortMore;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGroup;
        private System.Windows.Forms.ToolStripSeparator mnuContextGroupSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGroupAscending;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGroupDescending;
        private System.Windows.Forms.ToolStripSeparator mnuContextGroupSep2;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGroupMore;
        private System.Windows.Forms.ToolStripMenuItem mnuContextRefresh;
        private System.Windows.Forms.ToolStripSeparator mnuContextSep2;
        private System.Windows.Forms.ToolStripMenuItem mnuContextCut;
        private System.Windows.Forms.ToolStripMenuItem mnuContextCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuContextPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuContextDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuContextRename;
        private System.Windows.Forms.ToolStripSeparator mnuContextSep3;
        private System.Windows.Forms.ToolStripMenuItem mnuContextProperties;
    }
}
