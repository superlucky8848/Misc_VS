using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Xml;

namespace MeTagQA
{
    public class AppBase
    {
        //static functions here
        public static OutDoc LoadFile(string fileName)
        {
            if (!File.Exists(fileName)) return null;
            OutDoc ret = null;
            string ext = Path.GetExtension(fileName).ToLower();

            ret = new OutDoc(fileName);

            return ret;
        }

        public static bool SaveFile(string fileName, OutDoc savedDoc)
        {
            if (savedDoc == null) return false;
            //TODO: Save doc
            return true;
        }
    }

    public class OutDoc
    {
        private string fileName;
        private XmlDocument xmlDoc;



        public OutDoc(string fileName)
        {
            this.LoadFile(fileName);
        }

        public bool LoadFile(string fileName)
        {
            return false;
        }
    }
}
