using System;
using System.Collections.Generic;
using System.Text;

namespace Concertroid.ObjectModels.Concert
{
    public class ConcertPerformerCostume : ICloneable
    {
        public class ConcertPerformerCostumeCollection
            : System.Collections.ObjectModel.Collection<ConcertPerformerCostume>
        {
        }

        private string mvarName = String.Empty;
        /// <summary>
        /// The name of this costume.
        /// </summary>
        public string Name { get { return mvarName; } set { mvarName = value; } }

        private string mvarPrimaryModelFileName = String.Empty;
        /// <summary>
        /// The file name of the primary model to display.
        /// </summary>
        public string PrimaryModelFileName { get { return mvarPrimaryModelFileName; } set { mvarPrimaryModelFileName = value; } }

        private string mvarSecondaryModelFileName = String.Empty;
        /// <summary>
        /// The file name of the secondary model to display.
        /// </summary>
        public string SecondaryModelFileName { get { return mvarSecondaryModelFileName; } set { mvarSecondaryModelFileName = value; } }

        public object Clone()
        {
            ConcertPerformerCostume clone = new ConcertPerformerCostume();
            clone.Name = (mvarName.Clone() as string);
            clone.PrimaryModelFileName = (mvarPrimaryModelFileName.Clone() as string);
            clone.SecondaryModelFileName = (mvarSecondaryModelFileName.Clone() as string);
            return clone;
        }
    }
}
