using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.WriteLine("Erorrrrr happened!!!!");
        }
    }
    internal class Program
    {
        static void Main4(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("It is odd number...");
                }
            }
            catch (Exception e)
            {
               Console.WriteLine("Entered input is not a valid number and the entering of the number has to be done again: "+e.Message);
             
            }
            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            string s = Console.ReadLine();
            try
            {
                double d = Convert.ToDouble(s);
                Console.WriteLine(d);

            }
            catch (FormatException e)
            {
                Console.WriteLine("You cannot enter strings...");
                
            }
            catch (OverflowException e)
            {
                Console.WriteLine("It is too large for double numbers...");

            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error...");
                throw;
            }
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (Exception e)
            {
                Console.WriteLine("StackOverFlowException happened... :"+e.Message);
                
            }
          
            
            Console.ReadLine();
        }
        static void Main1(string[] args)
        {
            string[] list = new string[5];
            list[0] = "Sunday";
            list[1] = "Monday";
            list[2] = "Tuesday";
            list[3] = "Wednesday";
            list[4] = "Thursday";
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error happened: "+e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
