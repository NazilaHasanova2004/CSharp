using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class Program
    {
        const string path=@"C:\Users\Azay\Downloads";
        const string path2=@"C:\Users\Azay\Desktop";
        const string path3 = @"C:\Users\Azay\Pictures";
        interface IVehicle
        {
            void Drive();
            bool Refuel(int g);

        }
        class Car :IVehicle
        {
            public int gasoline;
            public void Drive()
            {
                if (gasoline > 0) { 
                Console.WriteLine("Car is driving...");
                    }
                else
                {
                    Console.WriteLine("No gasoline!");
                }
            }
            public bool Refuel(int g)
            {
               
                gasoline+=g;
                return true;
               
               
            }
        }
        static void Main(string[] args)
        {
            Car car =new Car();
            car.gasoline=0;
            int amount = int.Parse(Console.ReadLine());
            car.Refuel(amount);
            car.Drive();
          
            Console.ReadLine();
        }

        static void Main3(string[] args)
        {
            var directory = new DirectoryInfo(path3);
            int num = directory.GetFiles().Length;
            int dir_num = directory.GetDirectories().Length;
            Console.WriteLine(num+dir_num);
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter 3 lines text!");
            string content = $"{Console.ReadLine()}\n{Console.ReadLine()}\n{Console.ReadLine()}";
            
            var file= Path.Combine(path2,"c#example");
            File.WriteAllText(file,content);

            string [] arr = File.ReadAllLines(file);
           

            Console.WriteLine($"The content of the last line of the file {Path.GetFileName(file)} is: {arr[2]}");
            Console.ReadLine();
        }
        static void Main1(string[] args)
        {
            var directory = new DirectoryInfo(path);
            var files = directory.GetFiles();

            var pdfDir = Path.Combine(path,"PDFS");
            Directory.CreateDirectory(pdfDir);

            var pngDir = Path.Combine(path,"Photos");
            Directory.CreateDirectory(pngDir);

             var docDir = Path.Combine(path,"DOCs");
            Directory.CreateDirectory(docDir);

            var videoDir = Path.Combine(path,"Musics_Videos");
            Directory.CreateDirectory(videoDir);

            var txtDir = Path.Combine(path,"Text Files");
            Directory.CreateDirectory(txtDir);

            var pptxDir = Path.Combine(path,"PPTX Files");
            Directory.CreateDirectory(pptxDir);

            var otherDir = Path.Combine(path,"Others");
            Directory.CreateDirectory(otherDir);

            foreach(var file in files)
            {
                try { 
                if (file.Extension == ".pdf")
                {
                    var newFileDir = Path.Combine(pdfDir,file.Name);
                    File.Move(file.FullName,newFileDir);
                }
                else if(file.Extension == ".docx")
                {
                    var newDOcDIr = Path.Combine(docDir,file.Name);
                    File.Move(file.FullName,newDOcDIr);
                }
                else if (file.Extension == ".png" || file.Extension == ".jpg")
                {
                    var newPhotoDirect = Path.Combine(pngDir,file.Name);
                    File.Move(file.FullName,newPhotoDirect);
                }
                 else if (file.Extension == ".mp3")
                {
                   var newVideoPath = Path.Combine(videoDir,file.Name);
                    File.Move(file.FullName,newVideoPath);
                }
                else if(file.Extension == ".txt")
                {
                     var newtxtPath = Path.Combine(txtDir,file.Name);
                    File.Move(file.FullName,newtxtPath);
                }
                else if(file.Extension == ".pptx")
                {
                     var newpptxPath = Path.Combine(pptxDir,file.Name);
                    File.Move(file.FullName,newpptxPath);
                }
                else
                {
                    var otherPaths =Path.Combine(otherDir,file.Name);
                    File.Move(file.FullName,otherPaths);
                }
                }
                catch
                {
                    Console.WriteLine("eroror");
                }
            }
            
            Console.ReadLine();
        }
      
    }
  
}
