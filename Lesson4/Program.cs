using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLM
{
    internal class Program
    {
        static void Main9(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var n = (options)int.Parse(Console.ReadLine());
            switch (n)
            {
                case options.Addition:
                    Console.WriteLine($"Addition of {a} and {b} is:{a + b}");
                    break;
                case options.Subtracton:
                    Console.WriteLine($"Subtraction of {a} and {b} is:{a - b}");
                    break;
                case options.Multiplication:
                    Console.WriteLine($"Multiplication of {a} and {b} is:{a * b}");
                    break;
                case options.Division:
                    Console.WriteLine($"Division of {a} and {b} is:{(double)a / b}");
                    break;
                case options.Exit:
                    Console.WriteLine("EXIT");
                    break;
                default:
                    Console.WriteLine("You cannot write this number.Out of range!");
                    break;

            }

            Console.ReadLine();
        }
        public enum options
        {
            Addition=1,
            Subtracton,
            Multiplication,
            Division,
            Exit
        }
        static void Main8(string[] args)
        {
            var n = (DayOfWeek)int.Parse(Console.ReadLine());
            switch (n)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                             Console.WriteLine(n);
                    break;

                default:
                    Console.WriteLine("There is no day of week");
                    break;

            }

            Console.ReadLine();
        }
        static void Main7(string[] args)
        {
            int[] arr = new int[3];
            int max = int.MinValue;
            int index = 0;
           for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if(arr[i] > max)
                {
                    max = arr[i];
                    index = i+1;
                }
            }
            Console.WriteLine($"The {index}nd number is the greatest among three:{max}");


            Console.ReadLine();
        }
        static void Main6(string[] args)
        {

            DateTime input = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(input.DayOfWeek);
            int n = (int)input.DayOfWeek;
            int day = 6 - n;
            DateTime last = input.AddDays(day);
            Console.WriteLine(n);
            Console.WriteLine(last.ToString("dd/MM/yyyy"));



            Console.ReadLine();
        }
        static void Main5(string[] args)
        {

            DateTime input = DateTime.Parse(Console.ReadLine());
            DateTime lastday = new DateTime(input.Year, 12, 31);
            Console.WriteLine(input.ToString("dd/MM/yyyy"));
            Console.WriteLine(lastday.ToString("dd/MM/yyyy"));
            Console.WriteLine(lastday.DayOfWeek);

            Console.ReadLine();
        }
        static void Main4(string[] args)
        {
            DateTime input = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            bool check=false;
            if (input.CompareTo(now.Date) == 0)
            {
                check= true;
            }
            Console.WriteLine(input.ToString("dd/MM/yyyy"));
            Console.WriteLine($"The current data status : {check}");
            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
           
            DateTime now = DateTime.Now;
           DateTime afternow = now.Add(TimeSpan.FromDays(40));
            Console.WriteLine(afternow.DayOfWeek);
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            DateTime myBirthday = DateTime.Parse("09.18.2004");
            DateTime now = DateTime.Now;
            TimeSpan ts = now - myBirthday;
            Console.WriteLine(ts.Days);
            Console.ReadLine();
        }
        static void Main1(string[] args)
        {
            DateTime myBirthday = DateTime.Parse("09.18.2004");
            Console.WriteLine(myBirthday.DayOfWeek);
            Console.ReadLine();
        }
    }
}
