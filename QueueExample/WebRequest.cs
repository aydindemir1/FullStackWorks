using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
   public class WebRequest
    {
        public string URL { get; set; }
        public string Method { get; set; }

        public WebRequest(string url, string method)
        {
            URL = url;
            Method = method;
        }

        public override string ToString()
        {
            return $"{Method} {URL}";
        }
    }
}
