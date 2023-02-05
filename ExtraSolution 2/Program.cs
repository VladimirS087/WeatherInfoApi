using ExtraSolution_2;
using ExtraSolution_2.WeatherClasses;
using Newtonsoft.Json;
using System.Net;


var userService = new ConsoleUserService();

var city = userService.ConsoleGetCity();

var temperatureScale = userService.ConsoleGetTemperatureScale();

var temperatureUnits = userService.GetTemperatureUnits(temperatureScale);


var url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units={temperatureUnits}&appid=6af61d45b32f256b89a08ea694f00137";

using var httpClient = new HttpClient();

var response = await httpClient.GetAsync(url);

var json = await response.Content.ReadAsStringAsync();

var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(json);

Console.WriteLine("The name of city:\n" +
                  "{0}\n\n" +
                  "The temperature scale (Fahrenheit or Celsius):\n" +
                  "{1}\n" +
                  "-------------------------------------------------\n" +
                  "City: {0}\n" +
                  "Weather: {2} ({3}) \n" +
                  "Temperature({1}): {4}\n" +
                  "Temperature feels like ({1}): {5}", weatherResponse.Name, 
                                                       temperatureScale,
                                                       weatherResponse.Weather[0].Main,
                                                       weatherResponse.Weather[0].Description,
                                                       weatherResponse.Main.Temp, 
                                                       weatherResponse.Main.Feels_Like);

Console.ReadLine();