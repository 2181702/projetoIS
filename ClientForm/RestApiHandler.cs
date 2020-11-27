using System;

namespace ClientForm
{
    internal class RestApiHandler
    {
        public RestApiHandler()
        {
        }

        internal Response<string> RestApiToJson()
        {
            return new Response<string>("NO JSON INFO AVALIBLE", "Not implemented yet!", STATUS_CODE.ERROR);
        }

        public Response<string> JsonToRestApi(string json, string outputLocation)
        {
            return new Response<string>("NO JSON INFO AVALIBLE", "Not implemented yet!", STATUS_CODE.ERROR);
        }
    }
}