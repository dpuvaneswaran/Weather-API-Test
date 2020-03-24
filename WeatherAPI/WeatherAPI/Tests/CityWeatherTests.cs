using NUnit.Framework;
using WeatherAPI.WeatherServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Tests
{
    [TestFixture]
    public class CityWeatherTests
    {
        private CurrentWeatherServices currentWeather = new CurrentWeatherServices();


        [Test]

        public void CheckStatusSucess()
        {
            int success = 200;
            Assert.AreEqual(success, currentWeather.weatherDTO.Weather.cod);
        }

        [Test]

        public void CheckingTimeZones()
        {
            Assert.AreEqual(0, currentWeather.weatherDTO.Weather.timezone);
        }

        [Test]

        public void CheckCityLocation()
        {
            Assert.AreEqual("Milton Keynes", currentWeather.weatherDTO.Weather.name);
        }



    }
}
