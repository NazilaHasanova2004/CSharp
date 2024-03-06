using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic;
namespace Lesson13
{ 
    internal class Program {
       
        public static void Main(string[] args)
        {
            DriveInfo[] alldrives = DriveInfo.GetDrives();
          /*  foreach (DriveInfo drive in alldrives)
            {
                Console.WriteLine($"Name of drive is: {drive.Name}");
                Console.WriteLine($"Total size of drive is :{Formatting(drive.TotalSize)}");
                Console.WriteLine($"Available size of drive is :{Formatting(drive.AvailableFreeSpace)}");
                Console.WriteLine($"Used size of drive is :{Formatting(drive.TotalSize-drive.AvailableFreeSpace)}");

            }*/
          /*
            PerformanceCounter p = new PerformanceCounter("Processor","% Processor Time", "_Total");
            p.NextValue();
            System.Threading.Thread.Sleep(1000);
            var percentage = p.NextValue();
            Console.WriteLine($"Percentage is: {percentage:n2}");
          */
          Console.WriteLine("Enter the value to shut down the computer:");

            if(!int.TryParse(Console.ReadLine(), out int minute)){
                Console.WriteLine("You cannot enter this value!");
                return;
            }
            TimeSpan ts =  TimeSpan.FromMinutes(minute);
            DateTime dt = DateTime.Now.Add(ts);

            Console.WriteLine($"Computer will shut down in {minute} minutes...");

            while(DateTime.Now < dt)
            {
                System.Threading.Thread.Sleep(1000);
            }

            Process.Start("shutdown","/s /t 0");
           Console.ReadLine();
        }
        public static string Formatting(long bytes)
        {
            string[] s = {"B","KB","MB","GB","TB","PB","EB"};
            int index =0;
            long size = bytes;
            while(size>=1024 && index < s.Length - 1)
            {
                size/=1024;
                index++;
            }
            return $"{ size:n2} { s[index] }";
        }
       
    }
}
