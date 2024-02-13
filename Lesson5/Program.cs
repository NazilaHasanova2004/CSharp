using System;
using System.Collections.ObjectModel;


namespace Les4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print10Numbers();
            // Console.WriteLine(SumOddNumbers());
            //SumandAverage();
            //Multiplication();
            //Asterisks();
            //Angle();
            // Sum();

            //int n = int.Parse(Console.ReadLine());
            //for(int i = 2; i <= n; i++)
            //{
            //    if (Prime(i))
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //int n = int.Parse(Console.ReadLine());
            //for(int i = 0; i <= n; i++)
            //{
            //    for(int j = i; j <= n; j++)
            //    {
            //        if(SumOfPrimes(i) && SumOfPrimes(j))
            //        {
            //            if (i + j == n)
            //            {
            //                Console.WriteLine(i + " + " + j + " = " + n);

            //            }
            //        }
            //    }
            //}

            //int n = int.Parse(Console.ReadLine());
            //if (isPolindrome(n))
            //{
            //    Console.WriteLine($"{n} is polindrome number!");
            //}
           
            Console.ReadLine();

        }
        static void Print10Numbers()
        {
            Console.WriteLine("Task 1:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static int SumOddNumbers()
        {
            Console.WriteLine("Task 2:");
            int sum = 0;
            for(int i = 1; i < 40; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void SumandAverage()
        {
            Console.WriteLine("Task 3:");
            float sum = 0; float avg = 0; 
            for(int i = 1; i <= 5; i++)
            {
                int var1 = int.Parse(Console.ReadLine());
                sum += var1;
            }
            avg = sum / 5;
            Console.WriteLine($"Sum:{sum}");
            Console.WriteLine($"AVG:{avg}");

        }
        static void Multiplication()
        {
            Console.WriteLine("Multiplication table:");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<= n; i++)
            {
                for(int j=1;j<= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
        static void Asterisks()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Angle()
        {
            int k = 1;
            for(int i = 0; i < 4; i++)                  
            {
                for(int j = 0; j < i+1; j++)
                {

                    Console.Write($"{k} ");
                    k++;
                }
                
                Console.WriteLine();
            }

        }
        static void Sum()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string s = "";
                for (int j = 0; j < i + 1; j++)
                {
                    
                    s += "9";
                }
                Console.Write(s+" ");
               sum+=int.Parse(s);
               
            }
            Console.WriteLine($"Sum:{sum}");

        }
        static bool Prime(int n)
        {
            
                if (n <= 1)
            {
                return false;
            }
            else if(n == 2)
                {
                    return true;
                }
            else
            {
                for (int j = 2; j <= n / 2; j++)
                {
                    if (n % j == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
                
            
        }

        static bool SumOfPrimes(int n)
        {
            if(n <= 1) return false;
            else if(n==2) return true;
            else
            {
                for(int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
        static bool isPolindrome(int n)
        {
            int temp = 0;
            int N = n;
            while (n > 0)
            {
                temp = temp * 10 + n % 10;
                n /= 10;
            }
            if (temp == N)
            {
                return true;
            }
            else { return false; }
        }

    }
    }

