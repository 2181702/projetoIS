using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    class RestApiHandlerInput : InputType
    {
        public HttpRequestMessage Location { get; set; }

        public RestApiHandlerInput(HttpRequestMessage _request)
        {
            Location = _request;
        }
        public override Response<string> Run()
        {
            return SendRequestAsync(Location).Result;
        }


        private async Task<Response<string>> SendRequestAsync(HttpRequestMessage request)
        {
            try
            {
                var client = new HttpClient();
                using (var ApiResponse = await client.SendAsync(request).ConfigureAwait(false)) //TODOStuck here!
                {
                    ApiResponse.EnsureSuccessStatusCode();
                    var body = await ApiResponse.Content.ReadAsStringAsync();
                    return new Response<string>(body, "Request Sent", STATUS_CODE.OK);
                }
            }
            catch (Exception e)
            {
                return new Response<string>("",e.Message, STATUS_CODE.ERROR);
            }
        }

        public override string ToString()
        {
            return $"[API]{Location.RequestUri}";
        }
    }

    class RestApiHandlerOutput : OutputType
    {
        public HttpRequestMessage Location { get; set; }

        public RestApiHandlerOutput(HttpRequestMessage _request)
        {
            Location = _request;
        }
        public override Response<string> Run(Response<string> json)
        {

            Response<string> response;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Location.RequestUri);
            try
            {
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = Location.Method.ToString();

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }
            }
            catch (Exception e)
            {

                response = new Response<string>("Unable to send message: ", "Unable to send message\nError:\n" + e.Message, STATUS_CODE.ERROR);
                Logs(response);
                return response;
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string result = "";
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                 response = new Response<string>(result, "Everything ok", STATUS_CODE.OK);
            
                Logs(response);
                return response;
            }
            catch (Exception e)
            {
                response = new Response<string>("No responsse", "No responsse\nError:\n" + e.Message, STATUS_CODE.ERROR);
                Logs(response);
                return response;
            }
        }


        public override string ToString()
        {
            return $"{Location.RequestUri}[API]";
        }

        public void Logs(Response<string> response)
        {
            

            string DIRECTORY_PATH;
            string FILE_NAME = "Logs.txt";
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            DIRECTORY_PATH = Path.Combine(projectPath, "Logs");


           
                if (!System.IO.Directory.Exists(DIRECTORY_PATH))
                {
                    System.IO.Directory.CreateDirectory(DIRECTORY_PATH);
                }

                string filePath = DIRECTORY_PATH + "/" + FILE_NAME;
            

                if (!System.IO.File.Exists(filePath))
                {
                    System.IO.File.Create(filePath);
                }
            string logsAnteriores = File.ReadAllText(filePath);
            
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(filePath);
               
                //Write a line of text
                sw.WriteLine(logsAnteriores + "-> Data: "+ DateTime.Now + " | Message: " + response.Message + " | Code: " + response.Status +" ; \n");
                //Write a second line of text
                
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }




        }

    }

    
}