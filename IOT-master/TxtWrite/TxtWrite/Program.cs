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
        static PerformanceCounter cpuCounter;
        static PerformanceCounter ramCounter;
        
       public static void Main(string[] args)
        {
            
            for (int i=0;i < 100;i++)
            {
                System.IO.File.WriteAllText(@"C:\Users\User\Documents\TestFolder",);
                System.IO.File.WriteAllText(@"C:\Users\User\Documents\TestFolder", );

            }

        }
        public string CpuUsage()
        {
            return cpuCounter.NextValue() + "%";
        }
        public string RamUsage()
        {
            return ramCounter.NextValue() + "MB";
        }
        
        
       
    }
}
