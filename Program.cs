using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

namespace CpuAndRamMonitor
{
    class Program
    {
       static PerformanceCounter cpuCounter;
       static  PerformanceCounter ramCounter;
        static void Main(string[] args)
        {
            Timer();
        }
        public static float getCurrentCpuUsage()
        {
            return cpuCounter.NextValue();

        }
        public static string getAvailableRAM()
        {
            return ramCounter.NextValue() + "MB";
        }
        public static void Timer()
        {
            for (int i = 0; i < 10;)
            {
                cpuCounter = new PerformanceCounter("Process", "% Processor Time", "_Total");
                ramCounter = new PerformanceCounter("Memory", "Available MBytes");

                float First = cpuCounter.NextValue();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Cpu usage"+ getCurrentCpuUsage() / 10 + "%");
                Console.WriteLine("Available Ram "+getAvailableRAM());
            }
        }
        
    }

}
