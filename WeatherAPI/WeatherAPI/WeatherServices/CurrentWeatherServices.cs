using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.WeatherServices.HTTPManager;
using WeatherAPI.WeatherServices.DataHandler;

namespace WeatherAPI.WeatherServices
{
    public class CurrentWeatherServices
    {
        public CallWeatherManager callWeatherManager = new CallWeatherManager();



        public WeatherDTO weatherDTO = new WeatherDTO();


        public string currentWeather;



        public CurrentWeatherServices()
        {
            currentWeather = callWeatherManager.GetCurrentWeather("Milton Keynes");
            weatherDTO.DeserilizationWeather(currentWeather);
        }
    }
}
