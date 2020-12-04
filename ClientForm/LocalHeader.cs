using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm
{
    public class LocalHeader
    {
        /**
         * Ideally the headers list would be a dictionary, but that doesn't work well with the listbox, so I made it a list
         * But a list only has one type, so I made the localheader type to hold two strings, and in the end, it will return a dictionary with the ToDictionary method
         */
            public string HeaderName { get; set; }
            public string HeaderData { get; set; }

            public LocalHeader(string name, string data)
            {
                HeaderName = name;
                HeaderData = data;
            }

            public override string ToString()
            {
                return "[" + HeaderName + "]" + HeaderData;
            }
    }
}
