using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm
{
    public class Flow
    {
        public DataType InputType { get; set; }
        public String InputLocation { get; set; }
        public DataType OutputType { get; set; }
        public String OutputLocation { get; set; }

        public Flow() { }
        public Flow(DataType inputType, string inputLocation, DataType outputType, string outputLocation)
        {
            InputType = inputType;
            InputLocation = inputLocation;
            OutputType = outputType;
            OutputLocation = outputLocation;
        }

        public override string ToString()
        {
            return "[" + InputType + "] " + InputLocation.ToString() + "  ->  " + OutputLocation.ToString() + " [" + OutputType + "]"; 
        }

        internal void Run()
        {
            string json = "";
            switch (InputType)
            {
                case DataType.EXCEL:
                    json = new ExcelHandler().ExcelToJson(InputLocation);
                    break;
                case DataType.XML:
                    json = new XmlHandler().XmlToJson(InputLocation);
                    break;
                case DataType.REST:
                    json = new RestApiHandler().RestApiToJson();
                    break;
            }
            switch (OutputType)
            {
                case DataType.HTML:
                    new HtmlHandler().JsonToHTML(json,OutputLocation);
                    break;
                case DataType.REST:
                    new RestApiHandler().JsonToRestApi(json,OutputLocation);
                    break;
            }
        }
    }

    public class FlowHandler
    {
        public static List<Flow> Flows { get; set; }

        private ClientForm clientForm;

        public FlowHandler(ClientForm form)
        {
            clientForm = form;
            Flows = new List<Flow>();
        }

        public List<Flow> GetFlows()
        {
            return Flows;
        }

        public void AddFlow(Flow newFlow)
        {
            Flows.Add(newFlow);
            clientForm.UpdateExistingFlows();
        }

        internal void RemoveFlow(Flow flow)
        {
            Flows.Remove(flow);
            clientForm.UpdateExistingFlows();
        }
    }

    public enum DataType
    {
        UNDEFINED, EXCEL, XML, JSON, REST, HTML
    }
}
