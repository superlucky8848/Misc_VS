using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;

namespace MeTag
{
    public class AppBase
    {
        //static functions here
        public static TagDoc LoadFile(string fileName)
        {
            if (!File.Exists(fileName)) return null;

            TagDoc ret = new TagDoc();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            XmlNode findNode = null;

            findNode = xmlDoc.DocumentElement.SelectSingleNode(@"/document[@id]");
            if (findNode != null) ret.id = findNode.Attributes["id"].Value;
            else return null;
            findNode = xmlDoc.DocumentElement.SelectSingleNode(@"/document/doc");
            if (findNode != null) ret.content = findNode.InnerText;
            else return null;

            findNode = xmlDoc.DocumentElement.SelectSingleNode(@"/document/title");
            if (findNode != null) ret.title = findNode.InnerText;
            findNode = xmlDoc.DocumentElement.SelectSingleNode(@"/document/author");
            if (findNode != null) ret.author = findNode.InnerText;
            findNode = xmlDoc.DocumentElement.SelectSingleNode(@"/document/meta[@url]");
            if (findNode != null) ret.url = findNode.Attributes["url"].Value;
   
            return ret;
        }

        public static bool SaveFile(string fileName, TagDoc savedDoc)
        {
            if (savedDoc == null 
                || String.IsNullOrEmpty(savedDoc.type)
                || String.IsNullOrEmpty(savedDoc.id)
                || string.IsNullOrEmpty(savedDoc.content)) return false;
            string objFileName = fileName + ".ws";

            BinaryFormatter binFormatter = new BinaryFormatter();
            binFormatter.Serialize(File.Create(objFileName), savedDoc);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\"<doc id=\"\">\"<type></type>\"<intent></intent>\"<content xml:space=\"preserve\">\"</content>\"</doc>");

            XmlNode curNode = xmlDoc.SelectSingleNode("/doc[@id]");
            curNode.Attributes["id"].Value = savedDoc.id;
            if (!String.IsNullOrEmpty(savedDoc.title))
            {
                XmlAttribute newAttribute = xmlDoc.CreateAttribute("title");
                newAttribute.Value = savedDoc.title;
                curNode.Attributes.Append(newAttribute);
            }
            if (!String.IsNullOrEmpty(savedDoc.author))
            {
                XmlAttribute newAttribute = xmlDoc.CreateAttribute("author");
                newAttribute.Value = savedDoc.author;
                curNode.Attributes.Append(newAttribute);
            }
            if (!String.IsNullOrEmpty(savedDoc.url))
            {
                XmlAttribute newAttribute = xmlDoc.CreateAttribute("ref");
                newAttribute.Value = savedDoc.url;
                curNode.Attributes.Append(newAttribute);
            }

            curNode = xmlDoc.SelectSingleNode("/doc/type");
            curNode.InnerText = savedDoc.type;

            curNode = xmlDoc.SelectSingleNode("/doc/intent");
            curNode.InnerText = savedDoc.intent;

            curNode = xmlDoc.SelectSingleNode("/doc/content");
            curNode.InnerXml = savedDoc.FormatContent();

            XmlWriter xw = XmlWriter.Create(File.Create(fileName));
            xw.Settings.Indent = true;
            xw.Settings.IndentChars = "\t";
            xw.Settings.Encoding = Encoding.UTF8;

            xmlDoc.WriteTo(xw);

            return true;
        }
    }

    public enum TagType
    {
        PURPOSE,
        DESTINATION,
        ATTENDER,
        TRANSPORT,
        BEFORE_TRAVEL,
        DURING_TRAVEL,
        AFTER_TRAVEL,
        TIME
    }

    [Serializable]
    public class TagNode
    {
        public TagType tagType;
        public int startPos;
        public int endPos;
        public List<KeyValuePair<string, string>> attributes = new List<KeyValuePair<string,string>>();

        public string GetHead()
        {
            StringBuilder sbTag = new StringBuilder();
            switch (tagType)
            {
                case TagType.PURPOSE:
                    sbTag.Append("<purpose");
                    break;
                case TagType.DESTINATION:
                    sbTag.Append("<destination");
                    break;
                case TagType.ATTENDER:
                    sbTag.Append("<attender");
                    break;
                case TagType.TRANSPORT:
                    sbTag.Append("<transport");
                    break;
                case TagType.BEFORE_TRAVEL:
                    sbTag.Append("<beforetravel");
                    break;
                case TagType.DURING_TRAVEL:
                    sbTag.Append("<duringtravel");
                    break;
                case TagType.AFTER_TRAVEL:
                    sbTag.Append("<aftertravel");
                    break;
                case TagType.TIME:
                    sbTag.Append("<time");
                    break;
            }

            foreach (KeyValuePair<string, string> attribute in attributes)
            {
                sbTag.Append(string.Format(" {0}=\"{1}\"", attribute.Key, SecurityElement.Escape(attribute.Value)));
            }
            sbTag.Append(">");
            return sbTag.ToString();
        }

        public string GetTail()
        {
            switch (tagType)
            { 
                case TagType.PURPOSE:
                    return "</purpose>";
                case TagType.DESTINATION:
                    return "</destination>";
                case TagType.ATTENDER:
                    return "</attender>";
                case TagType.TRANSPORT:
                    return "</transport>";
                case TagType.BEFORE_TRAVEL:
                    return "</beforetravel>";
                case TagType.DURING_TRAVEL:
                    return "</duringtravel>";
                case TagType.AFTER_TRAVEL:
                    return "</aftertravel>";
                case TagType.TIME:
                    return "</time>";
                default:
                    return "";
            }
        }
    }

    [Serializable]
    public class TagDoc
    {
        public string id;
        public string title;
        public string author;
        public string url;

        public string type;
        public string intent;
        public string content;

        public List<TagNode> tagNodeList = new List<TagNode>();

        public string FormatContent()
        {
            StringBuilder sbContent = new StringBuilder();

            int index=0;

            for (int curPos = 0; curPos < content.Length; ++curPos)
            {
                string curStr = SecurityElement.Escape(content[curPos].ToString());
                if (index >= tagNodeList.Count)
                {
                    sbContent.Append(curStr);
                    continue;
                }
                if (curPos < tagNodeList[index].startPos) sbContent.Append(curStr);
                else if (curPos == tagNodeList[index].startPos)
                {
                    sbContent.Append(tagNodeList[index].GetHead());
                    sbContent.Append(curStr);
                }
                else if (curPos > tagNodeList[index].startPos && curPos < tagNodeList[index].endPos) sbContent.Append(curStr);
                else if (curPos == tagNodeList[index].endPos)
                {
                    sbContent.Append(tagNodeList[index].GetTail());
                    index++;
                    curPos--;//Recheck posion for following tags
                }
            }

            return sbContent.ToString();
        }
    }
}
