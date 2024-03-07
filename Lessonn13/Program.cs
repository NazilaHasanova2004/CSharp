using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonn13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformanceCounter pc = new PerformanceCounter("Processor","% Processor time","_total");
            pc.NextValue();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(Math.Round(pc.NextValue(),2));
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            Process p = Process.GetCurrentProcess();
            Console.WriteLine(Formatting(p.PrivateMemorySize64));
            Console.WriteLine(Formatting(GC.GetTotalMemory(true)));
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter number for shut down:");
            if(!int.TryParse(Console.ReadLine(),out int minute))
            {
                Console.WriteLine("Invalid input...");
                return;
            }
        TimeSpan ts = TimeSpan.FromMinutes(minute);
        DateTime dt = DateTime.Now.Add(ts);
            Console.WriteLine("Computer will shut down...");

            while (DateTime.Now < dt)
            {
                System.Threading.Thread.Sleep(1000);
            }

            Process.Start("shutdown", "/s /t 0");



        }

        static void Main1(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Name of the drive is : {drive.Name}");
                Console.WriteLine($"Available size of drive is: {Formatting(drive.TotalSize)}");
                Console.WriteLine($"Available size of drive is: {Formatting(drive.AvailableFreeSpace)}");
                Console.WriteLine($"Used size of drive is: {Formatting(drive.TotalSize - drive.AvailableFreeSpace)}");

            }
            Console.ReadLine();
        }
        public static string Formatting(long bytes)
        {
            string[] types = { "B", "KB", "MB", "GB", "TB" };
            int index = 0;
            long size = bytes;

            while(size>=1024 && index < types.Length - 1)
            {
                size /= 1024;
                index++;
            }

            return $"{size:n2}{types[index]}";
        }
    }
}
