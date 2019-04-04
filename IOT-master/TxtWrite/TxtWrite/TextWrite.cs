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

       
        public static string getAvailableRAM()
        {
            return ramUsage.NextValue() + "MB";
        }

        public static void Main(string[] args)
        {
            
            string cpu = cpuUsage.NextValue() + "%";
            string ram = ramUsage.NextValue() + " MB";


            //for (int i = 0; i < 5;)
            //{

            //    StreamWriter SW = new StreamWriter(@"C:\Users\CeX\Desktop\Data.txt");

            //    SW.WriteLine(cpu);
            //    SW.WriteLine(ram);

            //}
            File.WriteAllText(@"C:\Users\CeX\Desktop\IOT\Data.txt", String.Empty);
            for (int i = 0; i < 100; i++)
            {

                float First = cpuUsage.NextValue();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Cpu usage" + cpuUSage() + "%");
                Console.WriteLine("Available Ram: " + getAvailableRAM());

                TextWriter writer = new StreamWriter(@"C:\Users\CeX\Desktop\IOT\Data.txt", append:true);
                


                
                writer.WriteLine(cpuUSage());
                writer.WriteLine(ram);
                writer.Close();
                

            }
            

        }
        public static string cpuUSage()
        {
            string percent = "";
             cpuUsage.NextValue();
            System.Threading.Thread.Sleep(1000);
            percent= cpuUsage.NextValue()+"%";
            return percent;

        }
    }
}
