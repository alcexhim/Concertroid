using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.ObjectModels.Concert
{
    /// <summary>
    /// Defines a tuple of performer, song, and performer costume that will be used during an automated concert performance.
    /// </summary>
    public class ConcertPerformance : ICloneable
    {
        public class ConcertPerformanceCollection
            : System.Collections.ObjectModel.Collection<ConcertPerformance>
        {
        }

		private string mvarTitle = String.Empty;
		public string Title { get { return mvarTitle; } set { mvarTitle = value; } }

        private ConcertSongPerformer.ConcertSongPerformerCollection mvarPerformers = new ConcertSongPerformer.ConcertSongPerformerCollection();
        public ConcertSongPerformer.ConcertSongPerformerCollection Performers { get { return mvarPerformers; } }

        private ConcertSong mvarSong = null;
        public ConcertSong Song { get { return mvarSong; } set { mvarSong = value; } }

        public object Clone()
        {
            ConcertPerformance clone = new ConcertPerformance();
            foreach (ConcertSongPerformer performer in mvarPerformers)
            {
                clone.Performers.Add(performer.Clone() as ConcertSongPerformer);
            }
            clone.Song = (mvarSong.Clone() as ConcertSong);
            
            return clone;
        }
    }
}
