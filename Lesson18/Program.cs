using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les18
{
    internal class Program
    {
        public class Guest
        {
            public string Name { get; set; }
        }
        public class Table
        {
            public Table()
            {
                Guests = new List<Guest>()
        {
            new Guest(){Name = "John"}
            , new Guest(){Name = "Charlie"}
            , new Guest() {Name = "Jill"}
            , new Guest(){Name = "Jane"}
            , new Guest(){Name = "Martin"}
            , new Guest(){Name = "Ann"}
            , new Guest(){Name = "Eve"}
        };
            }

            private List<Guest> Guests { get; set; }

            public Guest this[int index]
            {
                get
                {
                    return Guests[index];
                }
                set
                {
                    Guests[index] = value;
                }
            }
            public Guest this[string name]
            {
                get
                {
                    foreach(Guest guest in Guests)
                    {
                        if(guest.Name == name)
                        {
                            return guest;
                        }
                    }
                    return null;

                }

            }
        }
        static void Main()
        {
            Table table = new Table();
            Console.WriteLine(table[2].Name);
            Console.WriteLine(table["Eve"].Name);
            Console.ReadLine();
        }

        static void Main2()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
        static void Main1(string[] args)
        {
            List<int> list = new List<int>() { 1, 4, 5, 6, 1, 2 };
            List<int> newlist = list.WhereMy(e=>e%2==0).ToList();
            Console.WriteLine(String.Join(",",newlist));
            int value = list.FirstOrDefaultMy(u => u %2 ==0);
            Console.WriteLine(value);
            Console.ReadKey();

        }
    }
    public delegate void MyDelegate(ref int intValue);

    public class DelegateExercises
    {
        void Method1(ref int intValue)
        {
            intValue = intValue + 5;
            System.Console.WriteLine("Method1 " + intValue);
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intParameter = 5;
            myDelegate2(ref intParameter);
        }
    }
    static class Testing
    {
        public static List<T> WhereMy<T>(this List<T> l,Func<T,bool> predicate)
        {
            List<T> list = new List<T>();
            foreach(T t in l)
            {
                if (predicate(t))
                {
                    list.Add(t);
                }
            }
            return list;
        }
        public static T FirstOrDefaultMy<T>(this List<T> l, Func<T, bool> predicate)
        {
            foreach(T t in l)
            {
                if (predicate(t))
                {
                    return t;
                }
            }
            return default(T);
        }
    }
   
}
