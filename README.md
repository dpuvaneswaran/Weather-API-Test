WEATHER API TESTING MINI PROJECT


HOW TO USE THE FRAMEWORK:

Firstly, create a Test.Net Framework project and download necessary packages such as:
  - NUNIT, NUNIT ADAPTER, RESTSHARP, NewtonSoft.JSON
  
Next step, create folders and create neccessary classes to be arranged neatly within the application for best access:

Here below are 5 classes that was created:

        1)  CITY WEATHER TESTS: Tests the Weather API
        2)  WEATHER DTO: This class deserilizes the data from Weather API data model
        3)  WEATHER MODEL: This class has all the data model of the Weather API
        4)  CALL WEATHER MANAGER: Makes a call to the Weather API
        5)  CURRENT WEATHER SERVICES: Code logic 
        
The main objective of this project was to test some properties and aspects of the weather API.
Here below is an example from my tests to give a better explanation:

            public void CheckCityLocation()
        {
            Assert.AreEqual("Milton Keynes", currentWeather.weatherDTO.Weather.name);
        }
                  
As you can see above to get access to the properties within the weather API, had to write currentWeather.weatherDTO.Weather.name to get access of the name of the city which is Milton Keynes. Other properties can be tested from the API as long as currentWeather.weatherDTO.Weather is typed and then type in the preffered properties that could give access.


INSTRUCTIONS:

Advice the tester to have a look at the previous codes that has been tested and test new properties that can potentially be tested using the frameworks.


CONCLUSION:

During this project, I understood how to use a live API Key effectively to be able to retrive data and connect it onto my C# application using POSTMAN. I gained a better understanding on how to test a weather API and specific areas.
Things that I would do differently next time, I felt like I did way too many basic test and created atleast one complex test which will only be able to perform as experience takes part. The complex tests could be to check whether the temperature is between 0-20 and displays pass or fails. 




