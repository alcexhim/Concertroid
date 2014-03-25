using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;
using UniversalEditor.DataFormats.PropertyList;

using UniversalEditor.ObjectModels.PropertyList;
using Concertroid.ObjectModels.Concert;

namespace Concertroid.DataFormats
{
    public class AniMikuINIDataFormat : WindowsConfigurationDataFormat
    {
        public override DataFormatReference MakeReference()
        {
            DataFormatReference dfr = base.MakeReference();
            dfr.Clear();
            dfr.Capabilities.Add(typeof(ConcertObjectModel), DataFormatCapabilities.All);
            dfr.Filters.Add("AniMiku performance", new byte?[][] { new byte?[] { (byte)'A', (byte)'M', (byte)'P', (byte)'V', (byte)'2', (byte)'\r', (byte)'\n' } }, new string[] { "*.amp" });
            return dfr;
        }

        protected override void BeforeLoadInternal(Stack<ObjectModel> objectModels)
        {
            base.BeforeLoadInternal(objectModels);

            objectModels.Push(new PropertyListObjectModel());
            
            string magic = base.Stream.TextReader.ReadLine();
            if (magic != "AMPV2") throw new DataFormatException(UniversalEditor.Localization.StringTable.ErrorDataFormatInvalid);
        }
        protected override void AfterLoadInternal(Stack<ObjectModel> objectModels)
        {
            base.AfterLoadInternal(objectModels);

            PropertyListObjectModel plom = (objectModels.Pop() as PropertyListObjectModel);
            ConcertObjectModel concert = (objectModels.Pop() as ConcertObjectModel);

            Group grpPERF = plom.Groups["PERF"];
            if (grpPERF == null) throw new DataFormatException(UniversalEditor.Localization.StringTable.ErrorDataFormatInvalid);

            Property prpPERFnum = grpPERF.Properties["num"];
            if (prpPERFnum == null) throw new DataFormatException(UniversalEditor.Localization.StringTable.ErrorDataFormatInvalid);

            int perfNum = Int32.Parse(prpPERFnum.Value.ToString());

            for (int i = 0; i < perfNum; i++)
            {
                Group grp = plom.Groups["CHP-" + i.ToString()];
                
                Property prpName = grp.Properties["name"];
                Property prpVmd1 = grp.Properties["vmd1"];
                Property prpVmd2 = grp.Properties["vmd2"];
                Property prpSound = grp.Properties["sound"];
                Property prpDelay = grp.Properties["delay"];
                Property prpModel1 = grp.Properties["model1"];
                Property prpModel2 = grp.Properties["model2"];
                Property prpOffset1 = grp.Properties["offset1"];
                Property prpOffset2 = grp.Properties["offset2"];
            }
        }
    }
}

