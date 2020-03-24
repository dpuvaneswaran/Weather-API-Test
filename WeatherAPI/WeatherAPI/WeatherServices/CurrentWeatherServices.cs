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
        //call manager manages the call to the API to retrieve weather data
        public CallWeatherManager callWeatherManager = new CallWeatherManager();

        //DTO tranforms data into the format of our weather model
        public WeatherDTO weatherDTO = new WeatherDTO();

        //Current weather informations
        public string currentWeather;



        public CurrentWeatherServices()
        {
            currentWeather = callWeatherManager.GetCurrentWeather("Milton Keynes");
            weatherDTO.DeserilizationWeather(currentWeather);
        }
    }
}
