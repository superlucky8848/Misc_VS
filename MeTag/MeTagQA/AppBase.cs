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
    }

    public class OutDoc
    {
        private XmlDocument xmlDoc = null;

        private string fileName = null;
        private string docType = null;
        private string docIntent = null;
        private Dictionary<string, string> docProperties = null;
        private List<TagInfo> tagInfoList = null;

        public string FileName { get { return fileName; } }
        public string DocType { get { return docType; } }
        public string DocIntent { get { return docIntent; } }
        public Dictionary<string, string> DocProperties { get { return docProperties; } }
        public List<TagInfo> TagInfoList { get { return tagInfoList; } }
        public string Content 
        { 
            get 
            {
                if (xmlDoc == null) return "";
                XmlNode contentNode = xmlDoc.SelectSingleNode("/doc/content");
                if (contentNode == null) return "";
                else return contentNode.InnerXml;
            } 
        }

        public OutDoc(string fileName)
        {
            this.LoadFile(fileName);
        }

        public bool LoadFile(string _fileName)
        {
            bool ret;
            try
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(_fileName);
                fileName = _fileName;
                
                if (xmlDoc.DocumentElement.Name != "doc") ret = false;
                else if (xmlDoc.SelectSingleNode("/doc/type") == null) ret = false;
                else if (xmlDoc.SelectSingleNode("/doc/intent") == null) ret = false;
                else if (xmlDoc.SelectSingleNode("/doc/content") == null) ret = false;
                else
                {
                    docType = xmlDoc.SelectSingleNode("/doc/type").InnerText;
                    docIntent = xmlDoc.SelectSingleNode("/doc/intent").InnerText;
                    docProperties = new Dictionary<string, string>(); ;
                    foreach (XmlAttribute attr in xmlDoc.DocumentElement.Attributes)
                    {
                        docProperties[attr.Name] = attr.Value;
                    }
                    tagInfoList = new List<TagInfo>();
                    XmlNode contentNode = xmlDoc.SelectSingleNode("/doc/content");
                    foreach (XmlNode curNode in contentNode.ChildNodes)
                    {
                        if (curNode is XmlElement)
                            tagInfoList.Add(new TagInfo((XmlElement)curNode, this));
                    }
                }
                ret = true;
            }
            catch
            {
                if (xmlDoc != null) xmlDoc = null;
                if (fileName != null) fileName = null;
                ret = false;
            }

            return ret;
        }

        public bool GetTagOffset(int tagIndex, out int tagStart, out int tagLength)
        {
            tagStart = tagLength = 0;
            if (xmlDoc == null) return false;
            XmlNode contentNode = xmlDoc.SelectSingleNode("/doc/content");
            if (tagIndex < 0) return false;
            bool isFound = false;
            int elementIndex = -1;

            int i = 0;
            while (!isFound && elementIndex <= tagIndex)
            {
                XmlNode curNode = contentNode.ChildNodes[i++];
                if (curNode is XmlElement) elementIndex++;
                if (elementIndex == tagIndex)
                {
                    tagLength = curNode.OuterXml.Replace("\r\n", "\n").Length;
                    isFound = true;
                }
                else 
                {
                    tagStart += curNode.OuterXml.Replace("\r\n", "\n").Length;
                }
            }

            return isFound;
        }
    }

    public class TagInfo
    {
        private string tagName = null;
        private string tagValue = null;
        private string tagText = null;
        private string tagDocName = null;
        public OutDoc ownerDoc = null;

        public string TagName { get { return tagName; } }
        public string TagValue { get { return tagValue; } }
        public string TagText { get { return tagText; } }
        public string TagDocName { get { return tagDocName; } }

        private TagInfo() { }

        public TagInfo(XmlElement xmlElement, OutDoc outDoc)
        {
            AssignElement(xmlElement, outDoc);
        }

        public void AssignElement(XmlElement xmlElement, OutDoc outDoc)
        {
            tagName = xmlElement.Name;
            if (xmlElement.Attributes["value"] != null) tagValue = xmlElement.Attributes["value"].Value;
            else tagValue = null;
            tagText = xmlElement.InnerText.Replace("\r\n", "");
            ownerDoc = outDoc;
            tagDocName = ownerDoc.FileName;
        }
    }
}
