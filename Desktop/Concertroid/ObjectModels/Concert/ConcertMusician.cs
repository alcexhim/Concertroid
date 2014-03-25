using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.ObjectModels.Concert
{
    public class ConcertMusician : ICloneable
	{
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

        private string mvarGivenName = String.Empty;
        public string GivenName
        {
            get { return mvarGivenName; }
            set { mvarGivenName = value; }
        }
        private string mvarFamilyName = String.Empty;
        public string FamilyName
        {
            get { return mvarFamilyName; }
            set { mvarFamilyName = value; }
        }

        private string mvarInstrument = String.Empty;
        public string Instrument
        {
            get { return mvarInstrument; }
            set { mvarInstrument = value; }
		}

		private System.Collections.Generic.Dictionary<string, string> mvarProperties = new Dictionary<string, string>();
		public System.Collections.Generic.Dictionary<string, string> Properties
		{
			get { return mvarProperties; }
		}

        public class ConcertMusicianCollection
            : System.Collections.ObjectModel.Collection<ConcertMusician>
        {

        }

		public string FullName
		{
			get { return (mvarGivenName + " " + mvarFamilyName).Trim(); }
		}

		public override string ToString()
		{
			return FullName + " [" + mvarInstrument + "]";
		}

		public object Clone()
		{
			ConcertMusician clone = new ConcertMusician();
			clone.FamilyName = mvarFamilyName;
			clone.GivenName = mvarGivenName;
			clone.ID = mvarID;
			clone.Instrument = mvarInstrument;
			foreach (System.Collections.Generic.KeyValuePair<string, string> prop in mvarProperties)
			{
				clone.Properties.Add(prop.Key, prop.Value);
			}
			return clone;
		}
	}
}
