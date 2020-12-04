using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm
{
    class ApiRequestFormHandler
    {
        private ClientForm client;

        private static Response<HttpRequestMessage> response;

        public ApiRequestFormHandler(ClientForm form)
        {
            client = form;
        }
        public ApiRequestFormHandler()
        {
        }

        public Response<HttpRequestMessage> GetRestRequest()
        {
            ApiRequestForm requestForm = new ApiRequestForm();
            requestForm.ShowDialog();
            return response;
        }

        public void UpdateRequest(HttpRequestHeaders headers, HttpMethods method, string url)
        {
            var request = new HttpRequestMessage()
            {
                Method = GetMethodFromEnum(method),
                RequestUri = new Uri(url)
                
            };
            foreach(var h in headers)
            {
                request.Headers.Add(h.Key,h.Value);
            }
            response = new Response<HttpRequestMessage>(request,"All Ok",STATUS_CODE.OK);
        }

        public HttpMethod GetMethodFromEnum(HttpMethods method)
        {
            switch (method)
            {
                case HttpMethods.GET:
                    return HttpMethod.Get;
                case HttpMethods.PUT:
                    return HttpMethod.Put;
                case HttpMethods.POST:
                    return HttpMethod.Post;
                case HttpMethods.DELETE:
                    return HttpMethod.Delete;
            }
            return HttpMethod.Get;
        }

        public string[] GetPairedString(string s1, string s2)
        {
            return new string[] { s1, s2 };
        }
    }
}
