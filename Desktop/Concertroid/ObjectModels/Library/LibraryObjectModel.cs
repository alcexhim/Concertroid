using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;

namespace Concertroid.ObjectModels.Library
{
    public class LibraryObjectModel : ObjectModel
    {
        private ObjectModelReference _omr = null;
        public override ObjectModelReference MakeReference()
        {
            if (_omr == null)
            {
                _omr = base.MakeReference();
            }
            _omr.Title = "Concertroid asset library";
            _omr.Description = "A collection of assets (songs, producers, performers, etc.) for Concertroid.";
            _omr.Path = new string[] { "Concertroid", "Asset Library" };
            return _omr;
        }

        public override void Clear()
        {
            mvarLibraries.Clear();
        }
        public override void CopyTo(ObjectModel where)
        {
            LibraryObjectModel clone = (where as LibraryObjectModel);
            foreach (Library library in mvarLibraries)
            {
                clone.Libraries.Add(library.Clone() as Library);
            }
        }

        private Library.LibraryCollection mvarLibraries = new Library.LibraryCollection();
        public Library.LibraryCollection Libraries { get { return mvarLibraries; } }
    }
}
