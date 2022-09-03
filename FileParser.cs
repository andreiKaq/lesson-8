using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    public abstract class FileParser
    {
        public abstract string FileName { get;  set; }
        public abstract string ParserFormat { get;}
        public FileParser(string filenanme)
        {
            FileName = filenanme;
        }
        public abstract void Read();

        public abstract void Open();

        public abstract void Analize();

        public abstract void Close();
        public virtual void Parse()
        {
            Open(); Read(); Analize(); Close();
        }
        public static FileParser GetParser(string fileName)
        {
            FileParser parser;

            if (fileName.EndsWith(".xml"))
                parser = new XmlParser(fileName);
            else if (fileName.EndsWith(".rtf"))
                parser = new RtfParser(fileName);
            else if (fileName.EndsWith(".html"))
                parser = new HtmlParser(fileName);
            else
                parser = null;

            return parser;
        }

    }
}
