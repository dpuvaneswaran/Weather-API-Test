using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.WeatherServices.HTTPManager
{
    public class CallWeatherManager
    {
        private readonly IRestClient restClient;

        public CallWeatherManager()
        {
            restClient = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetCurrentWeather(string city)
        {
            var request = new RestRequest($"/weather?q={city}&{AppConfigReader.ApiUrlMod}{AppConfigReader.ApiKey}");
            var response = restClient.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
