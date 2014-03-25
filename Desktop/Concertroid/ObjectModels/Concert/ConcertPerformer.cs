using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.ObjectModels.Concert
{
    public class ConcertPerformer : ICloneable
    {
		public class ConcertPerformerCollection
			: System.Collections.ObjectModel.Collection<ConcertPerformer>
		{
			public ConcertPerformer this[Guid id]
			{
				get
				{
					foreach (ConcertPerformer perf in this)
					{
						if (perf.ID == id) return perf;
					}
					return null;
				}
			}

			public override string ToString()
			{
				StringBuilder sb = new StringBuilder();

				for (int i = 0; i < Count; i++)
				{
					sb.Append(this[i].FullName);
					if (i < Count - 1)
					{
						sb.Append("; ");
					}
				}

				return sb.ToString();
			}
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

        private ConcertPerformerCostume.ConcertPerformerCostumeCollection mvarCostumes = new ConcertPerformerCostume.ConcertPerformerCostumeCollection();
        public ConcertPerformerCostume.ConcertPerformerCostumeCollection Costumes { get { return mvarCostumes; } }

		public string FullName
		{
			get { return (mvarGivenName + " " + mvarFamilyName).Trim(); }
            set
            {
                string[] givenAndFamilyName = value.Split(new char[] { ' ' }, 2, StringSplitOptions.None);
                mvarGivenName = givenAndFamilyName[0];
                if (givenAndFamilyName.Length > 1)
                {
                    mvarFamilyName = givenAndFamilyName[1];
                }
            }
		}

        private System.Collections.Generic.Dictionary<string, string> mvarProperties = new Dictionary<string, string>();
        public System.Collections.Generic.Dictionary<string, string> Properties
        {
            get { return mvarProperties; }
        }

		public object Clone()
		{
			ConcertPerformer clone = new ConcertPerformer();
			clone.FamilyName = mvarFamilyName;
			clone.GivenName = mvarGivenName;
			clone.ID = mvarID;
            foreach (ConcertPerformerCostume costume in mvarCostumes)
            {
                clone.Costumes.Add(costume.Clone() as ConcertPerformerCostume);
            }
			foreach (System.Collections.Generic.KeyValuePair<string, string> prop in mvarProperties)
			{
				clone.Properties.Add(prop.Key, prop.Value);
			}
			return clone;
		}

		public override string ToString()
		{
			return FullName;
		}
    }
}
