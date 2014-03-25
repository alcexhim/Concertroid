using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;

namespace Concertroid.ObjectModels.Concert
{
    public class ConcertObjectModel : ObjectModel
    {
        public override ObjectModelReference MakeReference()
        {
            ObjectModelReference omr = base.MakeReference();
            omr.Title = "Concert";
            omr.Path = new string[] { "PolyMo Live!", "Concert Document" };
            return omr;
        }

		public override void Clear()
		{
			mvarBandMusicians.Clear();
			mvarBandTitle = String.Empty;
			mvarGuestMusicians.Clear();
			mvarID = Guid.Empty;
			mvarPerformers.Clear();
			mvarProperties.Clear();
			mvarSongs.Clear();
			mvarTitle = String.Empty;
		}

		private Guid mvarID = Guid.Empty;
		/// <summary>
		/// A unique identifier for the performer. If the value is not set, it will be
		/// automatically generated upon saving.
		/// </summary>
		public Guid ID
		{
			get { return mvarID; }
			set { mvarID = value; }
		}

        private string mvarTitle = String.Empty;
        public string Title
        {
            get { return mvarTitle; }
            set { mvarTitle = value; }
        }

        #region Band
        private string mvarBandTitle = String.Empty;
        public string BandTitle
        {
            get { return mvarBandTitle; }
            set { mvarBandTitle = value; }
        }

        private ConcertMusician.ConcertMusicianCollection mvarBandMusicians = new ConcertMusician.ConcertMusicianCollection();
        public ConcertMusician.ConcertMusicianCollection BandMusicians
        {
            get { return mvarBandMusicians; }
        }

        private ConcertMusician.ConcertMusicianCollection mvarGuestMusicians = new ConcertMusician.ConcertMusicianCollection();
        public ConcertMusician.ConcertMusicianCollection GuestMusicians
        {
            get { return mvarGuestMusicians; }
        }

		private ConcertPerformer.ConcertPerformerCollection mvarPerformers = new ConcertPerformer.ConcertPerformerCollection();
		public ConcertPerformer.ConcertPerformerCollection Performers
		{
			get { return mvarPerformers; }
		}
        #endregion
		#region Set List
		private ConcertSong.ConcertSongCollection mvarSongs = new ConcertSong.ConcertSongCollection();
		public ConcertSong.ConcertSongCollection Songs
		{
			get { return mvarSongs; }
		}
		#endregion

		private System.Collections.Generic.Dictionary<string, string> mvarProperties = new Dictionary<string, string>();
		public System.Collections.Generic.Dictionary<string, string> Properties
		{
			get { return mvarProperties; }
		}

        public override void CopyTo(ObjectModel destination)
        {
            ConcertObjectModel clone = (destination as ConcertObjectModel);
			clone.Title = mvarTitle;
			clone.BandTitle = mvarBandTitle;

			foreach (ConcertMusician mus in mvarBandMusicians)
			{
				clone.BandMusicians.Add(mus.Clone() as ConcertMusician);
			}
			foreach (ConcertMusician mus in mvarGuestMusicians)
			{
				clone.GuestMusicians.Add(mus.Clone() as ConcertMusician);
			}
			foreach (ConcertPerformer perf in mvarPerformers)
			{
				clone.Performers.Add(perf.Clone() as ConcertPerformer);
			}
			foreach (ConcertSong song in mvarSongs)
			{
				clone.Songs.Add(song.Clone() as ConcertSong);
			}
			foreach (System.Collections.Generic.KeyValuePair<string, string> prop in mvarProperties)
			{
				clone.Properties.Add(prop.Key, prop.Value);
			}
        }

        private ConcertPerformance.ConcertPerformanceCollection mvarPerformances = new ConcertPerformance.ConcertPerformanceCollection();
        public ConcertPerformance.ConcertPerformanceCollection Performances { get { return mvarPerformances; } }
    }
}
