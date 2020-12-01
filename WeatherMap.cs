using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace WeatherMap
{
    class WeatherMap
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var kelvin = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return (kelvin - 273.15) * (9 / 5) + 32;
        }
    }
}
