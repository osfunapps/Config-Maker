using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Config_Maker.project
{
    class RemoteTypeAppender
    {
        public static string REMOTE_TYPE = "remote_type";
        private string PROPS = "props";
        private string PROP = "prop";

        public void AppendRemoteType(XmlDocument document, XmlElement remoteNode, string remoteType)
        {
            XmlElement propsNodeParent = document.CreateElement(PROPS);
            XmlElement prop = document.CreateElement(PROP);
            prop.SetAttribute(REMOTE_TYPE, remoteType);
            propsNodeParent.AppendChild(prop);
            remoteNode.AppendChild(propsNodeParent);
        }
    }
}
