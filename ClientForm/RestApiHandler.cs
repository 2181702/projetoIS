using System;
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
                using (var ApiResponse = await client.SendAsync(request))
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
            return new Response<string>("NO JSON INFO AVALIBLE", "Not implemented yet!", STATUS_CODE.ERROR);
        }
    }
}