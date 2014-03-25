using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.ObjectModels.Concert
{
	public class ConcertSong : ICloneable
	{
		public class ConcertSongCollection
			: System.Collections.ObjectModel.Collection<ConcertSong>
		{
		}

		private Guid mvarID = Guid.Empty;
		/// <summary>
		/// A unique identifier for the song. If the value is not set, it will be
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

		private ConcertMusician.ConcertMusicianCollection mvarGuestMusicians = new ConcertMusician.ConcertMusicianCollection();
		public ConcertMusician.ConcertMusicianCollection GuestMusicians
		{
			get { return mvarGuestMusicians; }
		}

		private System.Collections.Generic.Dictionary<string, string> mvarProperties = new Dictionary<string, string>();
		public System.Collections.Generic.Dictionary<string, string> Properties
		{
			get { return mvarProperties; }
		}

		public object Clone()
		{
			ConcertSong clone = new ConcertSong();
			foreach (ConcertMusician mus in mvarGuestMusicians)
			{
				clone.GuestMusicians.Add(mus.Clone() as ConcertMusician);
			}
			clone.ID = mvarID;
			clone.Title = mvarTitle;
			foreach (System.Collections.Generic.KeyValuePair<string, string> prop in mvarProperties)
			{
				clone.Properties.Add(prop.Key, prop.Value);
			}
			return clone;
		}

		public override string ToString()
		{
			return mvarTitle;
		}

        private string mvarSoundFileName = String.Empty;
        public string SoundFileName
        {
            get { return mvarSoundFileName; }
            set { mvarSoundFileName = value; }
        }

        private int mvarSoundDelay = 0;
        public int SoundDelay
        {
            get { return mvarSoundDelay; }
            set { mvarSoundDelay = value; }
        }
    }
}
