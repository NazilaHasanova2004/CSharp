using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Les9
{
    class Person
    {
        public string name;
       
        public string ToString()
        {
            return $"Hello!My name is {name}!";
        }
    }
    class Person2
    {
        public string name;
        public Person2(string name)
        {
            this.name = name;
        }
        ~Person2()
        {
            name = string.Empty;
        }
        public string toString()
        {
            return "Hello!My name is " + name;
        }
    }
   
    
    class PersoN
    {
       public int age;
        public void Greet()
        {
            Console.WriteLine("Hello,Guys!");
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

    }
    class Student:PersoN
    {
        public void Study()
        {
            Console.WriteLine("I'm studing!");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old!");
        }
    }
    class Teacher:PersoN
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining!");
        }
    }
    class PhotoBook
    {
        protected int numPages;
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int n)
        {
            numPages = n;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
    class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }

    class person
    {
        public string name;
        public person(string name)
        {
            this.name = name;
        }
        public string toString()
        {
            return name;
        }
    }
    class Students : person
    {
        public Students(string n):base(n)
        {
           
        }
    public void Studyy()
        {
            Console.WriteLine("Student is studing!");
        }
    }
    class Teachers : person
    {
        public Teachers(string n) : base(n)
        {

        }
        public void Explaining()
        {
            Console.WriteLine("Teacher is explaining!");
        }
    }
    class Program
     {
        static void Main(string[] args)
        {
            person[] p = new person[3];
            for(int i = 0; i < p.Length; i++)
            {
                if (i == 0)
                {
                    p[i] = new Teachers(Console.ReadLine());
                }
                else
                {
                    p[i] = new Students(Console.ReadLine());

                }
            }
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] is Teachers)
                {
                    Teachers s =  (Teachers)p[i];
                   
                    s.Explaining();
                }
                else
                {
                    Students s = (Students)p[i];
                    s.Studyy();
                }
            }
            Console.ReadLine();
        }

        static void Main5(string[] args)
        {
            PhotoBook book = new PhotoBook();
            Console.WriteLine(book.GetNumberPages());
            PhotoBook book2 = new PhotoBook(24);
            Console.WriteLine(book2.GetNumberPages());
            BigPhotoBook b = new BigPhotoBook();
            Console.WriteLine(b.GetNumberPages());

            Console.ReadLine();
        }


        static void Main4(string[] args)
        {
            PersoN p = new PersoN();
            p.Greet();
            Student st = new Student();
            st.Greet();
            st.SetAge(20);
            st.ShowAge();
            st.Study();
            Teacher teacher = new Teacher();
            teacher.SetAge(57);
            teacher.Greet();
            teacher.Explain();

            Console.ReadLine();
        }


        static void Main3(string[] args)
        {
            Person2[] p = new Person2[3];
            for(int i = 0; i < p.Length; i++)
            {
                p[i]=new Person2(Console.ReadLine());
            }
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i].toString());
            }
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            Person[] arr = new Person[3];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Person()
                {
                    name = Console.ReadLine()
                };
            }
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i].ToString()); 
            }
            Console.ReadLine();
        }
     }
}
