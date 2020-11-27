using System;

namespace ClientForm
{
    internal class HtmlHandler
    {
        public HtmlHandler()
        {
        }

        internal Response<string> JsonToHTML(string json, string outputLocation)
        {
            return new Response<string>("NO JSON INFO AVALIBLE", "Not implemented yet!", STATUS_CODE.ERROR);
        }
    }
}