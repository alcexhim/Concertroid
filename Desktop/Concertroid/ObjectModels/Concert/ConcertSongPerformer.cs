using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;

namespace Concertroid.ObjectModels.Concert
{
    public class ConcertSongPerformer : ICloneable
    {
        public class ConcertSongPerformerCollection
            : System.Collections.ObjectModel.Collection<ConcertSongPerformer>
        {
            public ConcertSongPerformer Add(ConcertPerformer performer)
            {
                return Add(performer, null);
            }
            public ConcertSongPerformer Add(ConcertPerformer performer, ConcertPerformerCostume costume)
            {
                return Add(performer, costume, String.Empty, PositionVector3.Empty);
            }

			public ConcertSongPerformer Add(ConcertPerformer performer, ConcertPerformerCostume costume, string motionDataFileName, PositionVector3 offset)
			{
				ConcertSongPerformer performr = new ConcertSongPerformer();
				performr.Performer = performer;
				performr.Costume = costume;
				performr.MotionDataFileName = motionDataFileName;
				performr.ModelOffset = offset;
				base.Add(performr);
				return performr;
			}
		}

        private ConcertPerformer mvarPerformer = null;
        public ConcertPerformer Performer { get { return mvarPerformer; } set { mvarPerformer = value; } }

        private ConcertPerformerCostume mvarCostume = null;
        public ConcertPerformerCostume Costume { get { return mvarCostume; } set { mvarCostume = value; } }

		private string mvarMotionDataFileName = String.Empty;
		/// <summary>
		/// The motion data file to play.
		/// </summary>
		public string MotionDataFileName { get { return mvarMotionDataFileName; } set { mvarMotionDataFileName = value; } }

        private PositionVector3 mvarModelOffset = PositionVector3.Empty;
        public PositionVector3 ModelOffset
        {
            get { return mvarModelOffset; }
            set { mvarModelOffset = value; }
        }

        public object Clone()
        {
            ConcertSongPerformer clone = new ConcertSongPerformer();
            clone.Costume = mvarCostume;
            clone.ModelOffset = mvarModelOffset;
            clone.Performer = mvarPerformer; // (mvarPerformer.Clone() as ConcertPerformer);
            return clone;
        }
    }
}
