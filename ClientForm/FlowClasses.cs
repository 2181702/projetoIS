using System.Collections.Generic;

namespace ClientForm
{
    public class Flow
    {
        public InputType Input { get; set; }
        public OutputType Output { get; set; }

        public Flow(InputType _input, OutputType _output)
        {
            Input = _input;
            Output = _output;
        }


        public override string ToString()
        {
            return Input.ToString() + " -> " + Output.ToString();
        }

        internal Response<string> Run()
        { 
            return Output.Run(Input.Run());
        }
    }

    public class FlowHandler
    {
        public static List<Flow> Flows { get; set; }

        private ClientForm clientForm;
        private FlowFileHandler flowFileHandler;

        public FlowHandler(ClientForm form, FlowFileHandler fileHandler)
        {
            clientForm = form;
            flowFileHandler = fileHandler;
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

        public void SaveFlows()
        {
            List<Flow> _flows = new List<Flow>(Flows);
            if(!clientForm.AskMessage("Override?","Want to override previously saved flows?\nIf no, it will append current flows to the file\nIf yes, it will save current flows overriding previously saved ones"))
            {
                Response<List<Flow>> loadedFlows = flowFileHandler.GetSavedFlows();
                foreach (Flow flow in loadedFlows.Data)
                {
                    if (!_flows.Contains(flow))
                    {
                        Flows.Add(flow);
                    }
                }
            }
            Response<bool> updateResponse = flowFileHandler.UpdateSavedFlows(_flows);
            clientForm.ShowMessage(updateResponse.Message);
        }

        public void LoadSavedFlows()
        {
            Response<List<Flow>> loadedFlows = flowFileHandler.GetSavedFlows();

            if (loadedFlows.Status == STATUS_CODE.OK)
            {
                foreach (Flow flow in loadedFlows.Data)
                {
                    if (!Flows.Contains(flow))
                    {
                        Flows.Add(flow);
                    }
                }
                clientForm.UpdateSavedFlows();
            }

            clientForm.ShowMessage(loadedFlows.Message);
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
        OK, ERROR, PARSING_ERROR
    }
}

