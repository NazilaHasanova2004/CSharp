using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Les11
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const string url = "https://dog.ceo/api/breeds/image/random";
            HttpClient client = new HttpClient();
            bool contin;
            do
            {
                string url = "https://dog.ceo/api/breeds/image/random";
            HttpClient h = new HttpClient();
            var result = h.GetStringAsync(url).Result;
            var final = JsonConvert.DeserializeObject<Dog>(result);
            string imgURL = $"{final.message}";
            string imgPath = @"C:\Users\Azay\Desktop\dog.jpg";
            byte[] imagebytes = await h.GetByteArrayAsync(imgURL);
            File.WriteAllBytes(imgPath, imagebytes);
            Console.WriteLine("Successfully downloaded!...");
            Console.ReadLine();
            }while(contin);

        }
        static async Task Main3(string[] args)
        {
             string name = Console.ReadLine();
            string url = $"https://api.nationalize.io?name={name}";
            HttpClient h = new HttpClient();
            var result = h.GetStringAsync(url).Result;
            var final = JsonConvert.DeserializeObject<Natinality>(result);
            foreach(var item in final.country)
            {
                Console.WriteLine($"Your country id is:{item.country_id},and probability is:{item.probability}");
            }
     Console.ReadLine();
        }
        static async Task Main2(string[] args)
        {
             string name = Console.ReadLine();
            string url = $"https://api.genderize.io/?name={name}";
            HttpClient h = new HttpClient();
            var result =  h.GetStringAsync(url).Result;
            var final = JsonConvert.DeserializeObject<Gender>(result);
            Console.WriteLine(final.gender);
           
                 Console.ReadLine();

        }
        static async Task Main1(string[] args)
        {
           const string url = "https://www.boredapi.com/api/activity";
           HttpClient client = new HttpClient();
            
            bool contin;
            do
            {
                var result = await client.GetStringAsync(url);
                var final = JsonConvert.DeserializeObject<Bored>(result);
                 Console.WriteLine(final.activity);
                contin =Convert.ToBoolean( Console.ReadLine() );
            }while(contin);
            //Console.ReadLine();
        }
        public class Bored
        {
            public string activity { get; set; }
            public string type { get; set; }
            public int participants { get; set; }
            public double price { get; set; }
            public string link { get; set; }
            public string key { get; set; }
            public double accessibility { get; set; }


        }
        public class Gender
        {
            public int count { get; set; }
            public string name { get; set; }    
            public string gender { get; set; }    
            public double probability { get; set; }

        }
        public class Nationality
        {
            public int count { get;set;}
            public string name { get;set;}
            public Country[] country { get; set; } 
        }
        public class Country
        {
            public string country_id { get; set; }
            public double probability { get; set;}
        }
        public class Dog
        {
            public string message { get; set; }
            public string status { get; set; }

        }
        
    }       
   
}
