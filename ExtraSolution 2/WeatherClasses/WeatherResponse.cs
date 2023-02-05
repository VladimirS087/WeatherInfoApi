using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraSolution_2.WeatherClasses
{
    internal class WeatherResponse
    {
        public string Name { get; set; }

        public TemperatureInfo Main { get; set; }

        public List<DescriptionWeather> Weather { get; set; }
    }
}
