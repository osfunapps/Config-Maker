using Config_Maker.project;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Config_Maker
{
    internal class XmlFileWriter
    {
        private string outputPath;
        private string outputXmlString;
        private string KEYS = "keys";
        private string REMOTE = "remote";
        private string KEY = "key";
        private string NAME = "name";
        private string TYPE = "type";
        private string HEX = "hex";
        private string remoteType;

        public XmlFileWriter(string outputFolder, string outputXmlString, string remoteType)
        {
            this.outputPath = outputFolder;
            this.outputXmlString = outputXmlString;
            this.remoteType = remoteType;
        }

        public void WriteXml()
        {
            XmlDocument document = new XmlDocument();
            XmlDeclaration xmlDeclaration = document.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement remoteNode = document.CreateElement(REMOTE);
            XmlElement keysNode = document.CreateElement(KEYS);

            outputXmlString.Trim();
            string[] parsedString = outputXmlString.Split(' ');
            foreach (string nodeVal in parsedString)
            {
                if (nodeVal.Equals("")) continue;
                XmlElement keyNode = document.CreateElement(KEY);
                keyNode.SetAttribute(TYPE, XMLTypes.NORMAL_BUTTON);
                keyNode.SetAttribute(NAME, nodeVal);
                keysNode.AppendChild(keyNode);
            }

            remoteNode.AppendChild(keysNode);
            document.AppendChild(remoteNode);

            //append remote type
            new RemoteTypeAppender().AppendRemoteType(document, remoteNode, remoteType);


            document.InsertBefore(xmlDeclaration, remoteNode);
            if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
            document.Save(outputPath +"\\config.xml");
            System.Console.WriteLine("done! wrote to: "+ outputPath);
        }

    }
}