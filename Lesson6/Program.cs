using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());

            //int b = int.Parse(Console.ReadLine());
            //PrintResult(a, b);

            // Fibonacchi(a);

            //Console.WriteLine(SumOfDigits(a));
            string s = Console.ReadLine();
            PrintString(s);
            Console.ReadLine();

        }
        static void PrintResult(int a,int b)
        {
             a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"The 1st number is:{a}");
            Console.WriteLine($"The 2nd number is:{b}");

        }
        static void Fibonacchi(int n)
        {
            int a = 0, b = 1,c;
            Console.Write(a+" "+b+" ");
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                Console.Write(a+b+" ");
                a = b;
                b = c;
               
                
            }
        }
        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
           return sum;
            

        }
        static void PrintString(string s)
        {
            int space = 0;
            s = s.Trim();
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]==' ')
                {
                    space++;

                }
            }
            Console.WriteLine($"\"{s}\" contains {space} spaces");

        }
        static void Task123(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random r = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0,100);
            }
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }

            } //ascending order
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int thirdMax = arr[2];
            Console.WriteLine($"Third max number is :{thirdMax}");
            Console.WriteLine("Four max number are :");

            for (int i = 0; i < 4; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
        
    }
}
