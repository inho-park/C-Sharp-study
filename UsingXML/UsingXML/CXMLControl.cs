using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml;

namespace UsingXML
{
    class CXMLControl
    {
        public static string _TEXT_DATA = "TEXT_DATA";
        public static string _CBOX_DATA = "CBOX_DATA";
        public static string _NUMBER_DATA = "NUMBER_DATA";

        public Dictionary<string, string> fxmlReader(string strXmlPath) {
            Dictionary<string, string> DXmlConfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(strXmlPath))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["id"];
                            rd.Read();

                            string strText = rd.ReadElementContentAsString(_TEXT_DATA, "");
                            DXmlConfig.Add(_TEXT_DATA, strText);

                            string strCbox = rd.ReadElementContentAsString(_CBOX_DATA, "");
                            DXmlConfig.Add(_CBOX_DATA, strCbox);

                            string strNumber = rd.ReadElementContentAsString(_NUMBER_DATA, "");
                            DXmlConfig.Add(_NUMBER_DATA, strNumber);

                        }
                    }
                }
            }
                return DXmlConfig;
        }

        public void fxmlWriter(string strXmlPath, Dictionary<string, string> DXmlCOnfig)
        {
            using (XmlWriter wr = XmlWriter.Create(strXmlPath))
            {
                wr.WriteStartDocument();

                // SETTING
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(_TEXT_DATA, DXmlCOnfig[_TEXT_DATA]);
                wr.WriteElementString(_CBOX_DATA, DXmlCOnfig[_CBOX_DATA]);
                wr.WriteElementString(_NUMBER_DATA, DXmlCOnfig[_NUMBER_DATA]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }
    }
}
