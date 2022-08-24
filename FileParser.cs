using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    abstract class FileParser
    {
        public abstract string ParserFormat { get; }
        public abstract string FileName { get; set; }
        public FileParser(string arg)
        {
            FileName = arg;
        }

        public static FileParser GetParser(string FileName) 
        {
            if (FileName.EndsWith(".Html"))
            {
                HtmlParser fileName = new HtmlParser();
                return filename;

            } else if (FileName.EndsWith(".Rtf"))
            {
                return RtfParser FileName = new RtfParser();

            } else if (FileName.EndsWith(".Xml"))
            {
                return FileName = new XmlParser();
            } else
            return null;
        }


        public abstract void Read();

        public abstract void Open();

        public abstract void Analize();

        public abstract void Close();

        public virtual void Parse()
        {

        }


    }
}
