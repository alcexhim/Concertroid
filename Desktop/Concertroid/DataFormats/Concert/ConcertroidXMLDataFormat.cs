using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;
using UniversalEditor.ObjectModels.Markup;
using UniversalEditor.DataFormats.Markup.XML;

using Concertroid.ObjectModels.Concert;

namespace Concertroid.DataFormats.Concert
{
    public class ConcertroidXMLDataFormat : XMLDataFormat
    {
        private static DataFormatReference _dfr = null;
        public override DataFormatReference MakeReference()
        {
            if (_dfr == null)
            {
                _dfr = base.MakeReference();
                _dfr.Clear();
                _dfr.Capabilities.Add(typeof(ConcertObjectModel), DataFormatCapabilities.All);
                _dfr.Filters.Add("Concertroid project (XML)", new string[] { "*.concert" });
            }
            return _dfr;
        }
        protected override void BeforeLoadInternal(Stack<ObjectModel> objectModels)
        {
            base.BeforeLoadInternal(objectModels);
            objectModels.Push(new MarkupObjectModel());
        }
        protected override void AfterLoadInternal(Stack<ObjectModel> objectModels)
        {
            base.AfterLoadInternal(objectModels);

            MarkupObjectModel mom = (objectModels.Pop() as MarkupObjectModel);
            ConcertObjectModel concert = (objectModels.Pop() as ConcertObjectModel);
        }

        protected override void BeforeSaveInternal(Stack<ObjectModel> objectModels)
        {
            base.BeforeSaveInternal(objectModels);
            
            ConcertObjectModel concert = (objectModels.Pop() as ConcertObjectModel);
            MarkupObjectModel mom = new MarkupObjectModel();

            // TODO : Load .concert XML files!

            objectModels.Push(mom);
        }
    }
}
