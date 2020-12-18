using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClientForm
{
    class XmlHandlerInput : InputType
    {
        public string Location { get; set; }
        public XmlHandlerInput(string location)
        {
            Location = location;
        }
        public override Response<string> Run()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Location);
                return new Response<string>(JsonConvert.SerializeXmlNode(doc), "XML -> Json | OK!", STATUS_CODE.OK);
            }
            catch (Exception e)
            {
                return new Response<string>("Unable to Serialize Xml Document: " + Location, e.Message, STATUS_CODE.ERROR);
            }
            
        }
        public override string ToString()
        {
            return $"[XML]{Location}";
        }
    }
    class XmlHandlerOutput : OutputType
    {
        public string Location { get; set; }
        public XmlHandlerOutput(string location)
        {
            Location = location;
        }
        public override Response<string> Run(Response<string> response)
        {
            if (!Location.EndsWith(".xml"))
            {
                Location += ".xml";
            }
            try
            {
                response.Data = "{root:" + response.Data + "}";
                XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(response.Data);
                doc.Save(Location);
                return new Response<string>(response.Data + "\nSaved to file " + Location, "Json -> XML | OK!", STATUS_CODE.OK);
            }
            catch (Exception e)
            {
                return new Response<string>("Unable to Serialize Xml Document: " + Location, e.Message, STATUS_CODE.ERROR);
            }
        }
        public override string ToString()
        {
            return $"{Location}[XML]";
        }
    }
}
