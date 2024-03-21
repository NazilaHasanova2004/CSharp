using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_a
{
    internal class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
        }
        static string url = @"C:\Users\Azay\Desktop";
        static string pathfolder = @"C:\Users\Azay\Desktop\MyFolderrrr";
        static void Main(string[] args)
        {
            string path = Path.Combine(url, "MyFolderrrr");

            DirectoryInfo dir = new DirectoryInfo(path);
            dir.Create();
            if (dir.Exists)
            {
                Console.WriteLine("Folder created");
            }
            string s;
            do
            {
                Student st = new Student();
                Console.WriteLine("Enter your ID:");
                st.Id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Name:");
                st.Name=Console.ReadLine();

                Console.WriteLine("Enter your DateBirth:");
                st.Date=DateTime.Parse(Console.ReadLine());

                var filepath = Path.Combine(pathfolder, st.Name + ".txt");
                string content = $"Your id is {st.Id},name is {st.Name} and DateBirth is {st.Date.Date}";
                File.WriteAllText(filepath,content);
                Console.WriteLine("If you want to add next person info,write Yes/or Not");
                s = Console.ReadLine();
            } while (s.ToLower()=="yes");

            Console.ReadLine();
        }
    }
}
