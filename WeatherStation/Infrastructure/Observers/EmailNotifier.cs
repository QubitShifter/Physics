using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationApp.Core.Entities;
using WeatherStationApp.Infrastructure.Services;

namespace WeatherStationApp.Infrastructure.Observers
{
    public class EmailNotifier
    {
        private readonly string _emailAddress;

        public EmailNotifier(string emailAddress)
        {
            _emailAddress = emailAddress;
        }

        public void Subscribe(WeatherStation station)
        {
            station.WeatherChanged += OnWeatherChanged;
        }

        public void Unsubscribe(WeatherStation station)
        {
            station.WeatherChanged -= OnWeatherChanged;
        }

        private void OnWeatherChanged(object sender, WeatherMeasurement e)
        {
            Console.WriteLine($"[Mock Email] To: {_emailAddress}");
            Console.WriteLine($"Subject: Weather Station Update");
            Console.WriteLine($"Body: New weather data - Temperature: {e.AmbientTemperature}°C, Wind: {e.WindSpeed} km/h.");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
