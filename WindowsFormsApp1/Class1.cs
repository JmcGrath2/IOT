using System;
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

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
