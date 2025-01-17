﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm
{
    public class FlowFileHandler
    {
        private string DIRECTORY_PATH;
        private const string FILE_NAME = "saved.flows";

        private const char FILE_FLOW_SPLITTER = ';';

        public FlowFileHandler()
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            DIRECTORY_PATH = Path.Combine(projectPath, "Flows");
        }

        public Response<List<Flow>> GetSavedFlows()
        {
            try
            {
                List<Flow> savedFlows = new List<Flow>();

                Response<string> filePath = GetFilePath();

                if (filePath.Status != STATUS_CODE.OK)
                {
                    return new Response<List<Flow>>(new List<Flow>(), filePath.Message, STATUS_CODE.ERROR);
                }

                string flowsFileText = System.IO.File.ReadAllText(filePath.Data);

                if (flowsFileText.Length == 0)
                {
                    return new Response<List<Flow>>(new List<Flow>(), "There are no flows saved.", STATUS_CODE.ERROR);
                }

                String[] splittedFlowsJson = flowsFileText.Split(FILE_FLOW_SPLITTER);

                foreach (string flowJson in splittedFlowsJson)
                {
                    Flow flow = JsonConvert.DeserializeObject<Flow>(flowJson);
                    savedFlows.Add(flow);
                }

                return new Response<List<Flow>>(savedFlows, "Data returned successfully!", STATUS_CODE.OK);
            }
            catch (Exception e)
            {
                return new Response<List<Flow>>(new List<Flow>(), $"{e.Message}\nAn error has occurred while trying to get the flows from the file.\nPlease try again.", STATUS_CODE.ERROR);
            }

        }

        public Response<bool> UpdateSavedFlows(List<Flow> newFlows)
        {
            if (newFlows.Count == 0)
            {
                return new Response<bool>(false, "There are no flows to be saved.", STATUS_CODE.ERROR);
            }

            try
            {
                Response<string> filePath = GetFilePath();
                
                if (filePath.Status != STATUS_CODE.OK)
                {
                    return new Response<bool>(false, filePath.Message, STATUS_CODE.ERROR);
                }

                System.IO.File.WriteAllText(filePath.Data, String.Empty);

                StringBuilder flowsJsons = new StringBuilder();

                for (int i = 0; i < newFlows.Count; i++)
                {
                    // Since we are working with directories, to be sure that the slashes are escaped, a replace is applied
                    string flowJson = JsonConvert.SerializeObject(newFlows[i]).Replace("//", "/");
                    flowsJsons.Append(flowJson);

                    if (i < newFlows.Count - 1)
                    {
                        flowsJsons.Append(FILE_FLOW_SPLITTER);
                    }
                }

                System.IO.File.WriteAllText(filePath.Data, flowsJsons.ToString());

                return new Response<bool>(true, "Data exported successfully!", STATUS_CODE.OK);
            }
            catch (Exception e)
            {
                return new Response<bool>(false, $"{e.Message}\nAn error has occurred while trying to update the flows file.\nPlease try again.", STATUS_CODE.ERROR);
            }

        }

        private Response<string> GetFilePath()
        {
            try
            {
                if (!System.IO.Directory.Exists(DIRECTORY_PATH))
                {
                    System.IO.Directory.CreateDirectory(DIRECTORY_PATH);
                }

                string filePath = DIRECTORY_PATH + "/" + FILE_NAME;

                if (!System.IO.File.Exists(filePath))
                {
                    System.IO.File.Create(filePath);
                }

                return new Response<string>(filePath, STATUS_CODE.OK);
            } catch(Exception e)
            {
                return new Response<string>("There was an error while creating/checking directories.", STATUS_CODE.ERROR);
            }
        }
       
     
    }
}
