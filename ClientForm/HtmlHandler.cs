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
                        w.WriteLine("<!DOCTYPE html>\n<html>\n<body>\n\t<div id='root'>");
                        w.WriteLine("\t</div>\n</body>\n</html>");
                        w.WriteLine("<script src= 'https://cdn.rawgit.com/caldwell/renderjson/master/renderjson.js'></script>");
                         w.WriteLine("<script>const data = JSON.parse('" + json + "'); console.log(data); document.getElementById('root').appendChild(renderjson(data)) </script>");
                        w.WriteLine("<script src='/path/to/dist/jsonview.bundle.js'></script>");
                        //w.WriteLine(json);
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