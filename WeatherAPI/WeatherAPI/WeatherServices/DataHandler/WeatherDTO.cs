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
        //this class is the model data
        public Rootobject Weather { get; set; }


        public void DeserilizationWeather(string WeatherResponse)
        {
            Weather = JsonConvert.DeserializeObject<Rootobject>(WeatherResponse);
        }
    }
}
