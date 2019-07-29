using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI
{
    public class NetworkAPI
    {
        public static string Ping(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/ping/?q="+ip+"");
            return result;
        }


        public static string Traceroute(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/mtr/?q="+ip+"");
            return result;
        }

        public static string DnsLookup(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/dnslookup/?q="+ip+"");
            return result;
        }

        public static string ReverseDnsLookup(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/reverseiplookup/?q="+ip+"");
            return result;
        }


        public static string Tcp_Scan(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/nmap/?q="+ip+"");
            return result;
        }

        public static string ZoneTransfer(string domain)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/zonetransfer/?q="+domain+"");
            return result;
        }

        public static string PortScan(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.c99.nl/portscanner?key=ILRNS-XDKV2-HUNDM-ZA22O&host="+ip+"");
            return result;
        }

        public static string GeoIP(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/geoip/?q="+ip+"");
            return result;
        }

        public static string PhoneLookup(string arg)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.c99.nl/phonelookup?key=ILRNS-XDKV2-HUNDM-ZA22O&number="+arg+"");
            return result;
        }

        public static string DnsHistory(string domain)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.c99.nl/domainhistory?key=ILRNS-XDKV2-HUNDM-ZA22O&domain="+domain+"");
            return result;
        }

        public static string CloudflareResolver(string domain)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.c99.nl/cfresolver?key=ILRNS-XDKV2-HUNDM-ZA22O&domain="+domain+"");
            return result;
        }

    }
}
