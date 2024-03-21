using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_b
{
    internal class Program
    {
        static string pathfolder = @"C:\Users\Azay\Desktop\MyFolderrrr";
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(pathfolder);
            watcher.EnableRaisingEvents = true;

            // Subscribe to the Created event
            watcher.Created += OnCreated;

            Console.WriteLine("Waiting for new student info files. Press 'q' to quit.");
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Q)
                    break;
            }
        }


        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created && !e.Name.StartsWith("."))
            {
                // read and visualize the contents of the new student info file
                string filepath = Path.Combine(pathfolder, e.Name);
                string studentinfo = File.ReadAllText(filepath);
                Console.WriteLine($"new student info: {studentinfo}");

                // wait for 1 second before processing the next file system change event
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
