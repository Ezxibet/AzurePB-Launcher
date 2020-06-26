using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Launcher
{
    public class Settings
    {
        private readonly string configFile = "Config.xml";
        public string LAST_CLIENT_VERSION {get; set;}
        public string UPDATE_SERVER_LOCAL {get; set;}
        public int VERSION_UPDATE {get; set;}
        public Settings() {VERSION_UPDATE = 0;}
        public void Save()
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();
                {
                    xdoc.AppendChild(xdoc.CreateNode(XmlNodeType.XmlDeclaration, "", ""));

                    XmlNode conf = xdoc.CreateElement("ConfigurationFile");
                    {
                        XmlNode lNode = xdoc.CreateElement("LAST_CLIENT_VERSION");
                        XmlNode lNodeText = xdoc.CreateTextNode(LAST_CLIENT_VERSION);

                        lNode.AppendChild(lNodeText);
                        conf.AppendChild(lNode);

                        XmlNode pNode = xdoc.CreateElement("UPDATE_SERVER_LOCAL");
                        XmlNode pNodeText = xdoc.CreateTextNode(UPDATE_SERVER_LOCAL);

                        pNode.AppendChild(pNodeText);
                        conf.AppendChild(pNode);

                        XmlNode vNode = xdoc.CreateElement("VERSION_UPDATE");
                        XmlNode vNodeText = xdoc.CreateTextNode(VERSION_UPDATE.ToString());

                        vNode.AppendChild(vNodeText);
                        conf.AppendChild(vNode);
                    }
                    xdoc.AppendChild(conf);
                }
                xdoc.Save(configFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Load()
        {
            if (File.Exists(configFile))
            {
                try
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(configFile);

                    XmlNode reader = xdoc.SelectSingleNode("ConfigurationFile/LAST_CLIENT_VERSION");
                    if (reader != null)
                        LAST_CLIENT_VERSION = reader.InnerText;

                    reader = xdoc.SelectSingleNode("ConfigurationFile/UPDATE_SERVER_LOCAL");
                    if (reader != null)
                        UPDATE_SERVER_LOCAL = reader.InnerText;
     
                    reader = xdoc.SelectSingleNode("ConfigurationFile/VERSION_UPDATE");
                    if (reader != null)
                    {
                        if (int.TryParse(reader.InnerText, out int tmpInt)) VERSION_UPDATE = int.Parse(reader.InnerText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
