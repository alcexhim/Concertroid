using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.ObjectModels.Library
{
    public class Library : ICloneable
    {
        public class LibraryCollection
            : System.Collections.ObjectModel.Collection<Library>
        {
        }

        private string mvarTitle = String.Empty;
        public string Title { get { return mvarTitle; } set { mvarTitle = value; } }

        public object Clone()
        {
            Library clone = new Library();
            clone.Title = (mvarTitle.Clone() as string);
            return clone;
        }
    }
}
