using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double d = a;
            double div = d / b;
            Console.WriteLine(div);
            Console.ReadLine();

        }
        static void Main2(string[] args)
        {
            string a =(Console.ReadLine());
            string b = (Console.ReadLine());
            bool r = false;
            if (a.Contains(b)) { r = true; }
            Console.WriteLine(r);
            Console.ReadLine();

        }
        static void Main1(string[] args)
        {
          int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool r = false;
            if(a%2==0 && b%2==0 || a%2!=0 && b% 2 != 0)
            {
                r = true;
            }
            Console.WriteLine(r);
            Console.ReadLine();

        }

    }
}
