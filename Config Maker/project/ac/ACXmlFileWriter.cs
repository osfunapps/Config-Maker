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
        public static string KEY = "key";
        public static string NAME = "name";
        public static string TYPE = "type";
        private int minDegree, maxDegree;
        private int fanMaxSpeed;
        private List<char> modesList;

        private string INFO_MIN_DEGREE = "min_degree";
        private string INFO_MAX_DEGREE = "max_degree";
        
        private string degreeType;
        private bool _aiRequired;
        private string remoteType;
        private XmlKeyNodeGenerator keyGenerator;

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

            keyGenerator = new XmlKeyNodeGenerator(document);

            string[] parsedString = outputXmlString.Split(' ');
            foreach (string nodeVal in parsedString)
            {
                if (nodeVal.Equals("\n") || nodeVal.Equals("")) continue;
                var strippedNode = nodeVal;
                if (nodeVal.StartsWith("\n"))
                    strippedNode = nodeVal.Substring(1);

                var keyNode = keyGenerator.GenerateScreenNode(strippedNode);
                keysNode.AppendChild(keyNode);
            }

            SetDisplayNode(document, keysNode);
            SetDegreesNodes(document, keysNode);
            SetAiNodes(document, keysNode);
            SetWindNodes(document, keysNode);


            remoteNode.AppendChild(keysNode);
            document.AppendChild(remoteNode);

            //append remote type
            new RemoteTypeAppender().AppendRemoteType(document, remoteNode, remoteType);

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
                windNode.SetAttribute(TYPE, XMLTypes.HEX);
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
                aiNode.SetAttribute(TYPE, XMLTypes.HEX);
                string num = i.ToString();
                if (i > 0)
                    num = "+" + num;
                aiNode.SetAttribute(NAME, TextTemplateHandler.AI_TXT + num);
                keysNode.AppendChild(aiNode);
            }

        }

        private void SetDisplayNode(XmlDocument document, XmlElement keysNode)
        {
            var acDisplayNode = keyGenerator.GenerateScreenPanelNode();
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
                keyNode.SetAttribute(TYPE, XMLTypes.HEX);
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
                keyNode.SetAttribute(TYPE, XMLTypes.HEX);
                keyNode.SetAttribute(NAME, modesList[mode].ToString() + degree + "F" + fanSpeed);
                keysNode.AppendChild(keyNode);
            }
            return false;
        }


        private void SetRemoteParams(XmlDocument document, XmlElement keysNode)
        {
            var minNode = keyGenerator.GenerateInfoNode(INFO_MIN_DEGREE, minDegree.ToString());
            var maxNode = keyGenerator.GenerateInfoNode(INFO_MAX_DEGREE, maxDegree.ToString());
            var modesNode = keyGenerator.GenerateInfoNode(TextTemplateHandler.INFO_MODES, FetchModesTxt());
            var maxFanPowerNode = keyGenerator.GenerateInfoNode(TextTemplateHandler.INFO_MAX_FAN_POWER, fanMaxSpeed.ToString());
            var degreeTypeNode = keyGenerator.GenerateInfoNode(TextTemplateHandler.INFO_DEGREE_TYPE, degreeType);

            keysNode.AppendChild(degreeTypeNode);
            keysNode.AppendChild(maxFanPowerNode);
            keysNode.AppendChild(modesNode);
            keysNode.AppendChild(minNode);
            keysNode.AppendChild(maxNode);
        }

        private string FetchModesTxt()
        {
            string modesTxt = "";
            foreach (var mode in modesList)
                modesTxt += " " + mode;
            modesTxt = modesTxt.Trim();
            modesTxt = modesTxt.Replace(" ", ", ");
            return modesTxt;
        }
    }
}