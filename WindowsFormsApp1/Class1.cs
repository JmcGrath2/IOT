﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class Class1
    {
       static PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
       static PerformanceCounter ram = new PerformanceCounter("Memory", "Available MBytes");

        private static void Main()
        {
           
        }


        public string getCpuUsage()
        {
            string usage = cpu.NextValue() + "%";
            return usage;

        }

        public string getAvailableRam()
        {
            string availableWam = ram.NextValue()+"MB";
            return availableWam;
        }
    }
}
