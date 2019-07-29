using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Threading;

namespace LuciferGUI.API
{
    public class ComputingAPI
    {
        public static string GetTotalRam()
        {
            try
            {
                ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
                ManagementObjectCollection results = searcher.Get();
                int resultat = 0;
                foreach (ManagementObject result in results)
                {
                    resultat = Convert.ToInt32(result["TotalVisibleMemorySize"]);
                    resultat = resultat / 1024;
                    return resultat.ToString();
                }
                return resultat.ToString();
            }

            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
          
        }

        public static string CurrentAppUsingRam()
        {

            try
            {
                double memory = 0.0;
                using (Process proc = Process.GetCurrentProcess())
                {
                    
                    memory = proc.PrivateMemorySize64 / 1e+6;
                    memory = memory - 27;
                    int result = Convert.ToInt32(memory);
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
            
        }


        public static string CurrentCPUusage()
        {
            var searcher = new ManagementObjectSearcher(
            "select MaxClockSpeed from Win32_Processor");
            uint clockspeed = 0;
            foreach (var item in searcher.Get())
            {
                clockspeed = (uint)item["MaxClockSpeed"];
                double result = Convert.ToDouble(clockspeed) / 1000;
                double finished = Math.Round(result, 2,MidpointRounding.ToEven);
                return finished.ToString();
            }
            return clockspeed.ToString();
        }


        public static string GetLuciferUSAGE()
        {
            PerformanceCounter myAppCpu =
                 new PerformanceCounter(
                     "Process", "% Processor Time", "LuciferGUI", true);

            
            
                double pct = Math.Round(myAppCpu.NextValue(), 2, MidpointRounding.ToEven);
            return pct.ToString();
                
            

        }
    }
}
