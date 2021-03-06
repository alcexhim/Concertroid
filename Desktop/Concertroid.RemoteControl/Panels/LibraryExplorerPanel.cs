﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Concertroid.ObjectModels.Concert;

namespace Concertroid.Manager.Panels
{
    public partial class LibraryExplorerPanel : UserControl
    {
        public LibraryExplorerPanel()
        {
            InitializeComponent();

            IconMethods.PopulateSystemIcons(ref imlLargeIcons);
            IconMethods.PopulateSystemIcons(ref imlSmallIcons);
        }

        private void tvExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshListView();
        }

        private ConcertObjectModel mvarConcert = null;
        public ConcertObjectModel Concert { get { return mvarConcert; } set { mvarConcert = value; RefreshExplorer(); } }

        public void RefreshExplorer()
        {
            RefreshTreeView();
            RefreshListView();
        }
        private void RefreshTreeView()
        {
            tvExplorer.Nodes.Clear();
            if (mvarConcert == null) return;

            #region Libraries
            {
                TreeNode tnLibraries = new TreeNode();
                tnLibraries.Name = "tnLibrary";
                tnLibraries.ImageKey = "Libraries";
                tnLibraries.SelectedImageKey = "Libraries";
                tnLibraries.Text = "Library";
                tvExplorer.Nodes.Add(tnLibraries);

                #region Band
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = "tnBand";
                    tn.Text = "Band";
                    tn.ImageKey = "generic-folder-closed";
                    tn.SelectedImageKey = "generic-folder-closed";
					tnLibraries.Nodes.Add(tn);
                }
                #endregion
                #region Guests
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = "tnGuests";
                    tn.Text = "Guests";
                    tn.ImageKey = "generic-folder-closed";
                    tn.SelectedImageKey = "generic-folder-closed";
					tnLibraries.Nodes.Add(tn);
                }
                #endregion
                #region Performers
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = "tnPerformers";
                    tn.Text = "Performers";
                    tn.ImageKey = "generic-folder-closed";
                    tn.SelectedImageKey = "generic-folder-closed";
					tnLibraries.Nodes.Add(tn);
                }
                #endregion
                #region Producers
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = "tnProducers";
                    tn.Text = "Producers";
                    tn.ImageKey = "generic-folder-closed";
                    tn.SelectedImageKey = "generic-folder-closed";
					tnLibraries.Nodes.Add(tn);
                }
                #endregion
                #region Songs
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = "tnSongs";
                    tn.Text = "Songs";
                    tn.ImageKey = "generic-folder-closed";
                    tn.SelectedImageKey = "generic-folder-closed";
					tnLibraries.Nodes.Add(tn);
                }
                #endregion
            }
            #endregion
        }
        private void RefreshListView()
        {
            lvExplorer.Clear();
            if (tvExplorer.SelectedNode == null) return;

            if (tvExplorer.SelectedNode.Name == "tnLibraries")
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageKey = "Library";
                lvi.Text = "Generic Library";
                lvExplorer.Items.Add(lvi);
            }
            else if (tvExplorer.SelectedNode.Name == "tnBand")
            {
            }
            else if (tvExplorer.SelectedNode.Name == "tnGuests")
            {
                lvExplorer.Columns.Add("Name");
                lvExplorer.Columns.Add("Instrument");
                foreach (ConcertMusician mus in mvarConcert.GuestMusicians)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "GuestMusician";
                    lvi.Text = mus.FullName;
                    lvi.SubItems.Add(mus.Instrument);
                    lvExplorer.Items.Add(lvi);
                }
            }
            else if (tvExplorer.SelectedNode.Name == "tnPerformers")
            {
                lvExplorer.Columns.Add("Name");
                foreach (ConcertPerformer perf in mvarConcert.Performers)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "Performer";
                    lvi.Text = perf.FullName;
                    lvExplorer.Items.Add(lvi);
                }
            }
            else if (tvExplorer.SelectedNode.Name == "tnProducers")
            {
                /*
                lvExplorer.Columns.Add("Name");
                foreach (ConcertSongProducer producer in mvarConcert.Producers)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "Producer";
                    lvi.Text = producer.FullName;
                    lvExplorer.Items.Add(lvi);
                }
                */
            }
            else if (tvExplorer.SelectedNode.Name == "tnSongs")
            {
                lvExplorer.Columns.Add("Name");
                foreach (ConcertSong song in mvarConcert.Songs)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "Song";
                    lvi.Text = song.Title;
                    lvExplorer.Items.Add(lvi);
                }
            }
            else if (tvExplorer.SelectedNode.Tag == null)
            {
                #region Band
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "generic-folder-closed";
                    lvi.Text = "Band";
                    lvExplorer.Items.Add(lvi);
                }
                #endregion
                #region Guests
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "generic-folder-closed";
                    lvi.Text = "Guests";
                    lvExplorer.Items.Add(lvi);
                }
                #endregion
                #region Performers
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "generic-folder-closed";
                    lvi.Text = "Performers";
                    lvExplorer.Items.Add(lvi);
                }
                #endregion
                #region Producers
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "generic-folder-closed";
                    lvi.Text = "Producers";
                    lvExplorer.Items.Add(lvi);
                }
                #endregion
                #region Songs
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = "generic-folder-closed";
                    lvi.Text = "Songs";
                    lvExplorer.Items.Add(lvi);
                }
                #endregion
            }
        }

        private void lvExplorer_ItemActivate(object sender, EventArgs e)
        {

        }
    }
}
