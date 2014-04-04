using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;
using UniversalEditor.Accessors;

using UniversalEditor.ObjectModels.Concertroid.Library;
using UniversalEditor.DataFormats.Concertroid.Library;

namespace Concertroid.Renderer
{
    public static class LibraryManager
    {
        private static string[] mvarLibraryPaths = null;
        public static string[] LibraryPath { get { return mvarLibraryPaths; } set { mvarLibraryPaths = value; } }

        static LibraryManager()
        {
            mvarLibraryPaths = new string[]
            {
                String.Join(System.IO.Path.DirectorySeparatorChar.ToString(), new string[]
                {
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                    "Libraries"
                }),
                String.Join(System.IO.Path.DirectorySeparatorChar.ToString(), new string[]
                {
                    System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "Mike Becker's Software",
                    "Concertroid",
                    "Libraries"
                })
            };
        }

        private static LibraryObjectModel mvarLibrary = new LibraryObjectModel();
        public static LibraryObjectModel Library { get { return mvarLibrary; } }

        public static void Load()
        {
            foreach (string path in mvarLibraryPaths)
            {
                LoadPath(path);
            }
        }
        public static void Load(string FileName)
        {
            LibraryXMLDataFormat xml = new LibraryXMLDataFormat();
            try
            {
                Document.Load(mvarLibrary, xml, new FileAccessor(FileName), true);
            }
            catch (InvalidDataFormatException ex)
            {
                Console.WriteLine("Invalid data format for file: \"" + FileName + "\"");
            }
        }
        public static void LoadPath(string path)
        {
            if (!System.IO.Directory.Exists(path))
            {
                Console.Error.WriteLine("LibraryManager.cs[43]: library path does not exist: \"" + path + "\"");
                return;
            }

            string[] libraryFileNames = System.IO.Directory.GetFiles(path);
            foreach (string fileName in libraryFileNames)
            {
                Load(fileName);
            }
        }
    }
}
