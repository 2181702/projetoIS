using System;
using System.IO;
using System.Text;

namespace ClientForm
{
    internal class HtmlHandler : OutputType
    {
        public string Location { get; set; }

        public HtmlHandler(string _location)
        {
            Location = _location;
        }

        //TODO - Neste momento escreve o ficheiro, mas não escreve nada de jeito, tentei por tags html a volta mas ainda nao fica nada de jeito
        public override Response<string> Run(Response<string> json)
        {
            if (!Location.EndsWith(".html"))
            {
                Location += ".html";
            }
            try { 
                using (FileStream fs = new FileStream(Location, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine("<!DOCTYPE html>\n<html>\n<body>\n\t<div style='font-family:courier;font-weight:bold;background-color: #f5f5f5;border-color: #ccc;border-style: solid;border-width: 1px;box-sizing: border-box;color:black;/*height: 300px;*/margin: 1px 0;overflow: auto;padding: 9px;' id='root'>");
                        w.WriteLine("\t</div>\n</body>\n</html>");
                        w.WriteLine("<script src= 'https://cdn.rawgit.com/caldwell/renderjson/master/renderjson.js'></script>");
                         w.WriteLine("<script>const data = JSON.parse('" + json.Data + "'); console.log(data); document.getElementById('root').appendChild(renderjson(data));renderjson.set_icons('>', '^');; </script>");
                        
                        w.WriteLine("<script src='/path/to/dist/jsonview.bundle.js'></script>");
                        //w.WriteLine(json);
                    }
                }
                return new Response<string>(json.Data, "HTML created!", STATUS_CODE.OK);
            }
            catch(Exception e)
            {
                return new Response<string>("NO JSON INFO AVALIBLE", e.Message, STATUS_CODE.ERROR);
            }
        }
    }
}