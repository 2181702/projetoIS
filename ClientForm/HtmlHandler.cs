using System;
using System.IO;
using System.Text;

namespace ClientForm
{
    internal class HtmlHandler
    {
        public HtmlHandler()
        {
        }


        //TODO - Neste momento escreve o ficheiro, mas não escreve nada de jeito, tentei por tags html a volta mas ainda nao fica nada de jeito
        internal Response<string> JsonToHTML(string json, string outputLocation)
        {
            if (!outputLocation.EndsWith(".html"))
            {
                outputLocation += ".html";
            }
            try { 
                using (FileStream fs = new FileStream(outputLocation, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        //w.WriteLine("<!DOCTYPE html>\n<html>\n<body>\n<div id='root'>");
                        //w.WriteLine("</div>\n</body>\n</html>");
                        //w.WriteLine("<script>document.getElementById('root').innerText =JSON.parse(" + json + ") </script>");
                        w.WriteLine(json);
                    }
                }
                return new Response<string>(json, "HTML created!", STATUS_CODE.OK);
            }
            catch(Exception e)
            {
                return new Response<string>("NO JSON INFO AVALIBLE", "Not implemented yet!", STATUS_CODE.ERROR);
            }
        }
    }
}