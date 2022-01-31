using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class ValuesController : ApiController
    {
        string key = "e74267b6c9764d0185d193133223001";
        string url = "http://api.weatherapi.com/v1/current.json?key=";
        string forecastUrl = "http://api.weatherapi.com/v1/forecast.json?key=";
        HttpClient client = new HttpClient();

        // GET api/values
        [HttpGet]
        [Route(("api/weather"))]
        public async Task<Root> Get(string city)
        {
            Console.WriteLine("Trying to find the weather for city {0}", city);
            HttpResponseMessage res = await client.GetAsync(url + key + "&q=" + city + "&aqi=yes");
            res.EnsureSuccessStatusCode();
            Root root = await res.Content.ReadAsAsync<Root>();
           
            Console.WriteLine("In city with name {0} , lat: {4} , long : {5} the weather now is {1} , wind is {2} , temp (Celcius) is {3}"
            , root.location.name, root.current.condition.text, root.current.wind_kph, root.current.temp_c, root.location.lat, root.location.lon);
           
            return root ;
        }

        [HttpGet]
        [Route("api/weather/forecast")]
        public async Task<Models.forecast.Root> GetForecast(string city,int days)
        {
            Console.WriteLine("Trying to find the weather for city {0} for {1} days", city,days);
            HttpResponseMessage res = await client.GetAsync(forecastUrl + key + "&q=" + city + "&aqi=yes&alerts=yes&days="+days);
            res.EnsureSuccessStatusCode();
            Models.forecast.Root root = await res.Content.ReadAsAsync<Models.forecast.Root>();

            Console.WriteLine("In city with name {0} , lat: {4} , long : {5} the weather now is {1} , wind is {2} , temp (Celcius) is {3}"
            , root.location.name, root.current.condition.text, root.current.wind_kph, root.current.temp_c, root.location.lat, root.location.lon);

            return root;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
