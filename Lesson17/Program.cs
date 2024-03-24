using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        

    }
    class UserManager
    {
        List<User> users = new List<User>(10);
        public List<User> Print_Users()
        {

            for (int i = 0; i < 5; i++)
            {

                User user = new User();
                user.Name = Console.ReadLine();
                user.Surname = Console.ReadLine();
                user.Age = int.Parse(Console.ReadLine());
                user.Country = Console.ReadLine();
                users.Add(user);
            }

            return users;
        }
    }

    internal class Program
    {
        public delegate double NumericFunction(double d);
        static double factor = 4.0;

        public static NumericFunction MakeMultiplier(double factor)
        {
            return delegate (double input) { return input * factor; };

        }
        static void Main2()
        {
            NumericFunction f = MakeMultiplier(3.0);
            double input = 5.0;

            Console.WriteLine("factor = {0}", factor);
            Console.WriteLine("input = {0}", input);
            Console.WriteLine("f is a generated function which multiplies its input with factor");
            Console.WriteLine("f(input) = input * factor = {0}", f(input));

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values:");
            UserManager user = new UserManager();
           List<User> Users = user.Print_Users();
            Console.WriteLine("Users...");
            Print(Users);
            UsersDeleg del = new UsersDeleg(PrintUsersMoreThan20);
            var Userssss = new List<User>(del.Invoke(Users));
            Console.WriteLine("More than 20:");
            Print(Userssss);
            del += RemoveUser;
            Users = new List<User>(del.Invoke(Users));
            Console.WriteLine("Who is not from turkey:");
            Print(Users);

            Console.ReadLine();
          
        }
        public delegate IEnumerable <User> UsersDeleg(List<User> list);

        public static IEnumerable<User> PrintUsersMoreThan20(List<User> users)
        {
            
            return users.Where(user=>user.Age>20);
        }

        public static IEnumerable<User> RemoveUser(List<User> users)
        {
        
            return users.Where(user =>
            {
                return user.Country.ToLower() != "turkey" &&
                 user.Age > 10;
            });
        }
        public static void Print(List<User> list)
        {
            foreach (var user in list)
            {
                Console.WriteLine($"{user.Name} {user.Surname} {user.Age} {user.Country}");
            }
        }
    }
}
