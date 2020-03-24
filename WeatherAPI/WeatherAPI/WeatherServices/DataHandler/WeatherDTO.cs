using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WeatherAPI.WeatherServices.DataHandler.WeatherModel;

namespace WeatherAPI.WeatherServices.DataHandler
{
    public class WeatherDTO
    {

        public Rootobject Weather { get; set; }


        //Here below is a method that shows the object above follows passing through a response from API
        public void DeserilizationWeather(string WeatherResponse)
        {
            Weather = JsonConvert.DeserializeObject<Rootobject>(WeatherResponse);
        }
    }
}
