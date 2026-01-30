using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Xml;
using Newtonsoft.Json;

namespace playwrightExample.Core.Utils
{
    public class XmlToJsonConverter
    {
        public static string ConvertXmlToJson(string xmlData)
        {
            XmlDocument doc = new XmlDocument();
            
            doc.LoadXml(xmlData); 
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            Console.WriteLine(jsonText);
            return jsonText;
        }

        public static string ConvertHtlmToJson(string htmlData)
        {
            string jsonText = "";
            return jsonText;
        }
    }
}