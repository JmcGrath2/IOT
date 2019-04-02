using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TxtWrite

{
    class Program
    {
        public static PerformanceCounter cpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public static PerformanceCounter ramUsage = new PerformanceCounter("Memory", "Available MBytes");
        
       public static void Main(string[] args)
        {
            
            string cpu = cpuUsage.NextValue() + "%";
            string ram = ramUsage.NextValue() + " MB";

            for (int i = 0; i < 100; i++)
            {

                using (StreamWriter writer = new StreamWriter(@"C: \Users\User\Desktop\Data.txt"))
                {
                    writer.Write(cpu);
                    writer.Write(ram);
                }

            }
        }
       
        
        
       
    }
}
