using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClientForm
{
    class XmlHandler
    {
        public string XmlToJson(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            return JsonConvert.SerializeXmlNode(doc); ;
        }
    }
}
