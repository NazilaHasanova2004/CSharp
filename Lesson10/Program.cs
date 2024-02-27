using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_10
{
  class Shape
    {
      
        protected Location l;
        public string toString()
        {
            return "x is " + l.x +",y is "+ l.y;
        }
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Perimeter()
        {
            return 0;
        }
    }
    class Rectangle : Shape
    {
        private double s1;
        private double s2;
        public Rectangle(double a,double b)
        {
            s1 = a;
            s2 = b;
        }
        public override double Area()
        {
            return s1 * s2;
        }
        public override double Perimeter()
        {
            return 2*(s1 + s2);
        }

    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI*radius*radius;
        }
        public override double Perimeter()
        {
            return 2 *Math.PI*radius;
        }
    }
class Location
    {
        public double x, y;
    }
    class schoolPerson
    {
        public string schoolName { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        private int a;
        public int age
        {
            get { return a; }
            set
            {
                if(a<6 && a > 50)
                {
                    throw new Exception("Your age must be valid!");
                }
                a = value;
            }
        
        }
        public string DateOfBirth { get; set; }
        public int currentClass { get; set; }
        public void Greet()
        {
            Console.WriteLine($"Hello {name} {surname}");
        }
        public virtual void GoToClasses ()
        {
            Console.WriteLine("Inside Base GoToClasses method");
        }
    }
    class Student:schoolPerson
    {
        public override void GoToClasses()
        {
            Console.WriteLine($"I'm {name} {surname}, I am student and I'm going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
    class Teacher:schoolPerson
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine($"Explanation begin on subject {subject}");
        }
        public override void GoToClasses()
        {
            Console.WriteLine($"I'm {name} {surname}, I am a teacher.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            schoolPerson sp = new schoolPerson();
            sp.name = "Person";
            sp.surname = "Hasanova";
            sp.Greet();
            Student s = new Student();
            s.age = 21;
            s.name = "Student";
            s.surname = "Hasanova";
            s.Greet();
            s.ShowAge();
            s.GoToClasses();
            Teacher t = new Teacher();
            t.age = 30;
            t.name = "Teacher";
            t.surname = "Hasanova";
            t.Greet();
            t.GoToClasses();
            t.Explain();
            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
           Shape [] arr =  new Shape[2];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    arr[i] = new Rectangle(a,b);
                }
                else
                {
                    int r = int.Parse(Console.ReadLine());
                    arr[i] = new Circle(r);
                }
                Console.WriteLine("Perimeter is: "+arr[i].Perimeter());
                Console.WriteLine("Area is: " + arr[i].Area()); 
            }
            Console.ReadLine();
        }
    }
}
