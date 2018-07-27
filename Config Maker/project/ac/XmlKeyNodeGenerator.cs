using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Config_Maker.project.ac
{
    class XmlKeyNodeGenerator
    {
        private XmlDocument document;
        private string AC_DISPLAY = "ac_display";
        private string SCREEN_ELEMENT = "screen_element";

        public XmlKeyNodeGenerator(XmlDocument document)
        {
            this.document = document;
        }

        public XmlNode GenerateScreenNode(string strippedNode)
        {
            XmlElement keyNode = document.CreateElement(ACXmlFileWriter.KEY);

            if (strippedNode == TextTemplateHandler.POWER_1_TXT_NO_NEW_LINE)
                keyNode.SetAttribute(ACXmlFileWriter.TYPE, XMLTypes.NORMAL_BUTTON);
            else if (strippedNode == TextTemplateHandler.POWER_2_TXT_NO_NEW_LINE)
                keyNode.SetAttribute(ACXmlFileWriter.TYPE, XMLTypes.HEX);
            else
                keyNode.SetAttribute(ACXmlFileWriter.TYPE, XMLTypes.SCREEN_ELEMENT);
            keyNode.SetAttribute(ACXmlFileWriter.NAME, strippedNode);
            return keyNode;
        }


        public XmlNode GenerateScreenPanelNode()
        {
            XmlElement acDisplayNode = document.CreateElement(ACXmlFileWriter.KEY);
            acDisplayNode.SetAttribute(ACXmlFileWriter.TYPE, XMLTypes.SCREEN_ELEMENT);
            acDisplayNode.SetAttribute(ACXmlFileWriter.NAME, AC_DISPLAY);
            return acDisplayNode;
        }


        public XmlNode GenerateInfoNode(string nodeName, string nodeVal)
        {
            XmlElement keyNode = document.CreateElement(ACXmlFileWriter.KEY);
            keyNode.SetAttribute(ACXmlFileWriter.TYPE, XMLTypes.INFO);
            keyNode.SetAttribute(ACXmlFileWriter.NAME, nodeName);
            keyNode.InnerText = nodeVal;
            return keyNode;
        }

    }
}
