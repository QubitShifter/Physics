using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationApp.Core.Entities;

namespace WeatherStationApp.Infrastructure.Observers
{
    public class ConsoleDisplay
    {
        public void OnWeatherUpdated(WeatherMeasurement measurement)
        {
            Console.WriteLine("New Weather Update via Event:");
            Console.WriteLine($"Ambient Temp: {measurement.AmbientTemperature} °C");
            Console.WriteLine($"Humidity:     {measurement.Humidity} %");
            Console.WriteLine($"Wind Speed:   {measurement.WindSpeed} km/h");
            Console.WriteLine("------------------------------------");
        }

        public void OnWeatherChanged(object sender, WeatherMeasurement e)
        {
            OnWeatherUpdated(e);
        }
    }
}
