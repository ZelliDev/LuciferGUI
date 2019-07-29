using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI
{
    public class PingAPI
    {
        public static string Ping(string ip)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

          
            options.DontFragment = true;

      
            string data = "SENDING PING TEST";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(ip, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                return "**Address: **"+ reply.Address.ToString() + Environment.NewLine+
                "**RoundTrip time: **"+ reply.RoundtripTime+Environment.NewLine+
                "**Time to live: **"+ reply.Options.Ttl + Environment.NewLine+
                "**Don't fragment: **"+ reply.Options.DontFragment+ Environment.NewLine+
                "**Buffer size: **"+ reply.Buffer.Length;
                
            }
            else
            {
                return "L'adresse IP est impossible à ping ou est hors ligne";
            }
        }
    }
}
