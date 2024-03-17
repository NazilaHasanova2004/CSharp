using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    internal class Program
    {
        static void Main4()
        {
          List<string>process = new List<string> { "Explorer.exe","C#.txt",".net"};
         List<string>nextList = ProcessToKill(process);
            Console.ReadKey();
        }
        public static List<string> ProcessToKill(List<string> process)
        {
            List<string> processToKill = new List<string>(3);

            Console.WriteLine(string.Format("Capacity {0}", processToKill.Capacity));

            Console.WriteLine(string.Format("Count {0}", processToKill.Count));

                foreach (var p in process)
                {
                    if (p != "Explorer.exe")
                    {
                        processToKill.Add(p);
                    }
                }

                foreach (var p in processToKill)
                {
                    Console.WriteLine(p);
                }           

             return processToKill;
        }
        static void Main3()
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Nazila", 19);
            people["Sabir"] = 19;
            Console.WriteLine($"First age is {people["Nazila"]}");
            Console.ReadLine();
        }
        static void Main2()
        {
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
        {
            { "Luke", true },
            { "Han", false },
            { "Chewbacca", false }
        };
            
                characters.Remove("Han");
                foreach(var character in characters)
            {
                Console.WriteLine(character);
            }
                Console.ReadLine();
        }
        static void Main1()
        {
            MyList<int> list = new MyList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Remove(1);
            //Console.WriteLine(list.Contains(1));
            //Console.WriteLine(list.count);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

    }

    public class MyList<T> : IEnumerable
    {
        public int count;
        List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public void Remove(T item)
        {
            list.Remove(item);
        }
        public void Clear()
        {
            list.Clear();
        }
        public bool Contains(T item)
        {
            if (list.Contains(item))
            {
                return true;
            }
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}

