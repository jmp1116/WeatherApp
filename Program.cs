using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;

namespace WeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string apiKey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            Console.WriteLine("Please enter your zip code");
            string zipCode = Console.ReadLine();
            Console.WriteLine("Please enter your country code");
            string countryCode = Console.ReadLine().ToLower();

            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},{countryCode}&appid={apiKey}";

            Console.WriteLine(WeatherMap.GetTemp(apiCall));
        }
    }
}
