using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI
{
   public class NetworkCommand
    {

        public static string DnsLoockup(string domain)
        {
            WebClient web = new WebClient();
            string result = web.DownloadString("https://api.hackertarget.com/dnslookup/?q="+domain+"");
            return result;
        }

    }
}
