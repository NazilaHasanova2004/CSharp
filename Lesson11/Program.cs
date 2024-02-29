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
                var result = await client.GetStringAsync(url);
                var final = JsonConvert.DeserializeObject<Dog>(result);
                 Console.WriteLine(final.message);
                Process.Start(final.message);
                contin =Convert.ToBoolean( Console.ReadLine() );
            }while(contin);

        }
        static async Task Main3(string[] args)
        {
            const string url = "https://api.nationalize.io/?name=nathaniel";
             HttpClient client = new HttpClient();
           
             var st = await client.GetStringAsync(url);
             var result = JsonConvert.DeserializeObject<Nationality>(st);
            if (result.name == "nathaniel")
            {
                double max=0;
                for(int i = 0; i <  result.country.Length; i++)
                {
                    if (result.country[i].probability > max)
                    {
                        max=result.country[i].probability;
                    }
                }
                 for(int i = 0; i < result.country.Length; i++)
                {
                    if (result.country[i].probability == max)
                    {
                         Console.WriteLine("Nationalty = " + result.country[i].country_id);
                         Console.WriteLine("Name = "+result.name);
                    }
                }
                

            }
           
     Console.ReadLine();
        }
        static async Task Main2(string[] args)
        {
             const string url = "https://api.genderize.io?name=luc";
             HttpClient client = new HttpClient();
           
                var st = await client.GetStringAsync(url);
                var result = JsonConvert.DeserializeObject<Gender>(st);
                if (result.name == "luc")
                {
                     Console.WriteLine("Gender = "+result.gender);
                     Console.WriteLine("Name = "+result.name);

                }
           
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
