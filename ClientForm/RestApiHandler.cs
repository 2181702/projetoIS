using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientForm
{
    internal class RestApiHandler
    {
        public RestApiHandler()
        {
        }

        internal Response<string> RestApiToJson(HttpRequestMessage request)
        {
            return SendRequestAsync(request).Result;
        }

        private async Task<Response<string>> SendRequestAsync(HttpRequestMessage request)
        {
            try
            {
                var client = new HttpClient();
                using (var ApiResponse = await client.SendAsync(request)) //TODOStuck here!
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

        public Response<string> JsonToRestApi(string json, HttpRequestMessage request)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(request.RequestUri);
            try {
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = request.Method.ToString();

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }
            }catch(Exception e)
            {
                return new Response<string>("Unable to send message: ", "Unable to send message\nError:\n" + e.Message, STATUS_CODE.OK);
            }
            try { 
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string result="";
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                return new Response<string>(result, "Everything ok", STATUS_CODE.OK);
            }catch(Exception e)
            {
                return new Response<string>("No responsse", "No responsse\nError:\n" + e.Message, STATUS_CODE.OK);
            }
        }
    }
}