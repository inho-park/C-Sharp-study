using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml;

namespace SImpleClicker
{
    class CXMLControl
    {
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_50 = "LEVEL_50";

        public void fxmlWriter(string strXmlPath, Dictionary<string, string> DXmlConfig)
        {
            // using 범위 내에 XmlWriter 를 정의하여 using 을 벗어 나게 될 경우 자동으로 Dispose 하여 메모리 관리
            using (XmlWriter wr = XmlWriter.Create(strXmlPath))
            {
                wr.WriteStartDocument();

                // SETTING
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(_TICK, DXmlConfig[_TICK]);
                wr.WriteElementString(_TOTAL, DXmlConfig[_TOTAL]);
                wr.WriteElementString(_LEVEL_1, DXmlConfig[_LEVEL_1]);
                wr.WriteElementString(_LEVEL_3, DXmlConfig[_LEVEL_3]);
                wr.WriteElementString(_LEVEL_50, DXmlConfig[_LEVEL_50]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }

        public Dictionary<string, string> fxmlReader(string strXmlPath) {
            Dictionary<string, string> DXmlConfig = new Dictionary<string, string>();
            // using 범위 내에 XmlWriter 를 정의하여 using 을 벗어 나게 될 경우 자동으로 Dispose 하여 메모리 관리
            using (XmlReader rd = XmlReader.Create(strXmlPath))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["ID"];
                            rd.Read();

                            string strTICK = rd.ReadElementContentAsString(_TICK, "");
                            DXmlConfig.Add(_TICK, strTICK);

                            string strTOTAL = rd.ReadElementContentAsString(_TOTAL, "");
                            DXmlConfig.Add(_TOTAL, strTOTAL);

                            string strLEVEL_1 = rd.ReadElementContentAsString(_LEVEL_1, "");
                            DXmlConfig.Add(_LEVEL_1, strLEVEL_1);
                            
                            string strLEVEL_3 = rd.ReadElementContentAsString(_LEVEL_3, "");
                            DXmlConfig.Add(_LEVEL_3, strLEVEL_3);

                            string strLEVEL_50 = rd.ReadElementContentAsString(_LEVEL_50, "");
                            DXmlConfig.Add(_LEVEL_50, strLEVEL_50);

                        }
                    }
                }
            }
            return DXmlConfig;
        }

    }
}
