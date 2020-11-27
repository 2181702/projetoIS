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
        public Response<string> XmlToJson(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            try
            {
                return new Response<string>(JsonConvert.SerializeXmlNode(doc), "XML -> Json | OK!", STATUS_CODE.OK);
            }
            catch(Exception e)
            {
                return new Response<string>("Unable to Serialize Xml Document: " + filePath,e.Message,STATUS_CODE.ERROR);
            }
            
        }
    }
}
