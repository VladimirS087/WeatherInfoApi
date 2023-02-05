using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraSolution_2
{
    internal class ConsoleUserService
    {

        public string ConsoleGetCity()
        {
            Console.WriteLine("Enter the city to view weather, for example \"Samara\"");

            string city = Console.ReadLine();

            return city;

        }

        public string ConsoleGetTemperatureScale()
        {
            Console.WriteLine("What temperature scale do you want? \n" +
                "Enter \"Celsius\" to view Celsius \n" +
                "Enter \"Fahrenheit\" to view Fahrenheit");


            string userCommand = Console.ReadLine();

            switch (userCommand)
            {
                case "Celsius":
                    return "Celsius";

                case "Fahrenheit":
                    return "Fahrenheit";

                default:
                    Console.WriteLine($"Incorrect value: {userCommand}");
                    return string.Empty;
            }
        }

        public string GetTemperatureUnits(string temperatureScale)
        {
            switch (temperatureScale)
            {
                case "Celsius":
                    return "metric";

                case "Fahrenheit":
                    return "imperial";

                default:
                    throw new ArgumentOutOfRangeException(temperatureScale);
            }
        }
        
    }
}


