using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Config_Maker.project.ac
{
    internal class ACXmlFileWriter
    {
        private string outputPath;
        private string outputXmlString;
        private string KEYS = "keys";
        private string REMOTE = "remote";
        private string KEY = "key";
        private string NAME = "name";
        private string TYPE = "type";
        private string HEX = "hex";
        private int minDegree, maxDegree;
        private int fanMaxSpeed;
        private List<char> modesList;
        private string MIN_DEGREE = "min_degree";
        private string MAX_DEGREE = "max_degree";
        private string AC_DISPLAY = "ac_display";
        private string degreeType;
        private bool _aiRequired;
        private string remoteType;

        public ACXmlFileWriter
            (string outputFolder, string outputXmlString, string minDegree, string maxDegree, List<char> modesList, int fanMaxSpeed, string degreeType, bool aiRequired, string remoteType)
        {
            _aiRequired = aiRequired;
            this.minDegree = int.Parse(minDegree);
            this.maxDegree = int.Parse(maxDegree);
            this.modesList = modesList;
            this.fanMaxSpeed = fanMaxSpeed;
            this.outputPath = outputFolder;
            this.outputXmlString = outputXmlString;
            this.degreeType = degreeType;
            this.remoteType = remoteType;
        }

        public void WriteXml()
        {
            XmlDocument document = new XmlDocument();
            XmlDeclaration xmlDeclaration = document.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement remoteNode = document.CreateElement(REMOTE);
            XmlElement keysNode = document.CreateElement(KEYS);
            outputXmlString.Trim();

            //append remote type
            XmlElement remoteTypeNode = document.CreateElement(XmlFileWriter.REMOTE_TYPE);
            remoteTypeNode.SetAttribute(TYPE, remoteType);
            keysNode.AppendChild(remoteTypeNode);

            string[] parsedString = outputXmlString.Split(' ');
            foreach (string nodeVal in parsedString)
            {
                if (nodeVal.Equals("\n") || nodeVal.Equals("")) continue;
                var strippedNode = nodeVal;
                if (nodeVal.StartsWith("\n"))
                    strippedNode = nodeVal.Substring(1);

                XmlElement keyNode = document.CreateElement(KEY);
                keyNode.SetAttribute(TYPE, HEX);
                keyNode.SetAttribute(NAME, strippedNode);
                keysNode.AppendChild(keyNode);
            }

            SetDegreesNodes(document, keysNode);
            SetDisplayNode(document, keysNode);
            SetAiNodes(document, keysNode);
            SetWindNodes(document, keysNode);


            remoteNode.AppendChild(keysNode);
            document.AppendChild(remoteNode);

            document.InsertBefore(xmlDeclaration, remoteNode);
            if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
            document.Save(outputPath + "\\config.xml");
            System.Console.WriteLine("done! wrote to: " + outputPath);
        }

        private void SetWindNodes(XmlDocument document, XmlElement keysNode)
        {
            for (int fanSpeed = 1; fanSpeed < fanMaxSpeed + 1; fanSpeed++)
            {
                XmlElement windNode = document.CreateElement(KEY);
                windNode.SetAttribute(TYPE, HEX);
                windNode.SetAttribute(NAME, Form1.WIND + "F" + fanSpeed);
                keysNode.AppendChild(windNode);
            }
        }

        private void SetAiNodes(XmlDocument document, XmlElement keysNode)
        {
            if (!_aiRequired) return;

            for (int i = 2; i > -3; i--)
            {
                XmlElement aiNode = document.CreateElement(KEY);
                aiNode.SetAttribute(TYPE, HEX);
                string num = i.ToString();
                if (i > 0)
                    num = "+" + num;
                aiNode.SetAttribute(NAME, TextTemplateHandler.AI_TXT + num);
                keysNode.AppendChild(aiNode);
            }

        }

        private void SetDisplayNode(XmlDocument document, XmlElement keysNode)
        {
            XmlElement acDisplayNode = document.CreateElement(KEY);
            acDisplayNode.SetAttribute(TYPE, HEX);
            acDisplayNode.SetAttribute(NAME, AC_DISPLAY);
        
            keysNode.AppendChild(acDisplayNode);
        }

        private void SetDegreesNodes(XmlDocument document, XmlElement keysNode)
        {
            SetRemoteParams(document, keysNode);
            bool toReverse = false;
            int degreesModes = 0;
            if (modesList.Contains(Form1.HOT)) degreesModes++;
            if (modesList.Contains(Form1.COLD)) degreesModes++;
            for (int mode = 0; mode < degreesModes; mode++)
            {
                for (int fanSpeed = 1; fanSpeed < fanMaxSpeed + 1; fanSpeed++)
                {
                    if (toReverse)
                        toReverse = FillNodesInReverse(document, mode, fanSpeed, keysNode);
                    else
                        toReverse = FillNodesNormally(document, mode, fanSpeed, keysNode);

                }
            }
        }

        private bool FillNodesNormally(XmlDocument document, int mode, int fanSpeed, XmlElement keysNode)
        {
            for (int degree = minDegree; degree < maxDegree + 1; degree++)
            {
                XmlElement keyNode = document.CreateElement(KEY);
                keyNode.SetAttribute(TYPE, HEX);
                keyNode.SetAttribute(NAME, modesList[mode].ToString() + degree + "F" + fanSpeed);
                keysNode.AppendChild(keyNode);
            }
            return true;
        }

        private bool FillNodesInReverse(XmlDocument document, int mode, int fanSpeed, XmlElement keysNode)
        {
            for (int degree = maxDegree; degree > minDegree - 1; degree--)
            {
                XmlElement keyNode = document.CreateElement(KEY);
                keyNode.SetAttribute(TYPE, HEX);
                keyNode.SetAttribute(NAME, modesList[mode].ToString() + degree + "F" + fanSpeed);
                keysNode.AppendChild(keyNode);
            }
            return false;
        }


        private void SetRemoteParams(XmlDocument document, XmlElement keysNode)
        {
            XmlElement minNode = document.CreateElement(KEY);
            minNode.SetAttribute(TYPE, HEX);
            minNode.SetAttribute(NAME, MIN_DEGREE);
            minNode.InnerText = minDegree.ToString();

            XmlElement maxNode = document.CreateElement(KEY);
            maxNode.SetAttribute(TYPE, HEX);
            maxNode.SetAttribute(NAME, MAX_DEGREE);
            maxNode.InnerText = maxDegree.ToString();

            XmlElement modesNode = document.CreateElement(KEY);
            modesNode.SetAttribute(TYPE, HEX);
            modesNode.SetAttribute(NAME, TextTemplateHandler.MODES);
            foreach (var mode in modesList)
                modesNode.InnerText += " " + mode;
            modesNode.InnerText = modesNode.InnerText.Trim();
            modesNode.InnerText = modesNode.InnerText.Replace(" ", ", ");

            XmlElement maxFanPowerNode = document.CreateElement(KEY);
            maxFanPowerNode.SetAttribute(TYPE, HEX);
            maxFanPowerNode.SetAttribute(NAME, TextTemplateHandler.MAX_FAN_POWER);
            maxFanPowerNode.InnerText = fanMaxSpeed.ToString();

            XmlElement degreeTypeNode = document.CreateElement(KEY);
            degreeTypeNode.SetAttribute(TYPE, HEX);
            degreeTypeNode.SetAttribute(NAME, TextTemplateHandler.DEGREE_TYPE);
            degreeTypeNode.InnerText = degreeType;

            keysNode.AppendChild(degreeTypeNode);
            keysNode.AppendChild(maxFanPowerNode);
            keysNode.AppendChild(modesNode);
            keysNode.AppendChild(minNode);
            keysNode.AppendChild(maxNode);
        }
    }
}