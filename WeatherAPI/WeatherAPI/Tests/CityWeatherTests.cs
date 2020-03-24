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
        public void ChecksID()
        {
            Assert.AreEqual(2642465, currentWeather.weatherDTO.Weather.id);
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

       
        [Test]
        public void ChecksCoordinationsLatitude()
        {
            Assert.AreEqual(52.04f, currentWeather.weatherDTO.Weather.coord.lat);
        }

        [Test]

        public void ChecksCoordinationsLongituted()
        {
            Assert.AreEqual(-0.76f, currentWeather.weatherDTO.Weather.coord.lon);
        }

        [Test]

        public void ChecksCountryLocation()
        {
            Assert.AreEqual("GB", currentWeather.weatherDTO.Weather.sys.country);
        }

        [Test]
        public void CheckingHumidityOfCity()
        {
            Assert.That(currentWeather.weatherDTO.Weather.main.humidity.ToString, Is.Not.Empty);
        }


        // [Test]

        // public void CheckWeatherDescription()
        // {
        //     Assert.AreEqual("clear sky", currentWeather.weatherDTO.Weather.weather);
        // }



    }
}
