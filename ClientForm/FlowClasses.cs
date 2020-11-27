﻿using System;
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

        internal Response<string> Run()
        {
            Response<string> response = new Response<string>();
            switch (InputType)
            {
                case DataType.EXCEL:
                    response = new ExcelHandler().ExcelToJson(InputLocation);
                    break;
                case DataType.XML:
                    response = new XmlHandler().XmlToJson(InputLocation);
                    break;
                case DataType.REST:
                    response = new RestApiHandler().RestApiToJson();
                    break;
            }
            switch (OutputType)
            {
                case DataType.HTML:
                    response = new HtmlHandler().JsonToHTML(response.Data, OutputLocation);
                    break;
                case DataType.REST:
                    response = new RestApiHandler().JsonToRestApi(response.Data,OutputLocation);
                    break;
            }
            return response;
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

    public class Response<T>
    {
        public Response(T _data, STATUS_CODE _status)
        {
            Status = _status;
            Data = _data;
        }
        public Response(T _data, string _message, STATUS_CODE _status)
        {
            Status = _status;
            Data = _data;
            Message = _message;
        }
        public Response()
        {

        }

        public T Data { get; set; }
        public STATUS_CODE Status { get; set; }
        public string Message { get; set; }
    }

    public enum STATUS_CODE
    {
        OK,ERROR, PARSING_ERROR
    }
}
