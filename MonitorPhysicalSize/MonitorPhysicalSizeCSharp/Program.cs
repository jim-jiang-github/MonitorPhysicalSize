using System;
using System.Management;

namespace MonitorPhysicalSizeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\root\wmi", @"SELECT * FROM WmiMonitorBasicDisplayParams");

            foreach (ManagementObject managementObject in searcher.Get())
            {
                double width = (byte)managementObject["MaxHorizontalImageSize"];
                double height = (byte)managementObject["MaxVerticalImageSize"];

                Console.WriteLine($"Monitor Size: width:{width}cm height:{height}");
            }
            Console.ReadKey();
        }
    }
}
