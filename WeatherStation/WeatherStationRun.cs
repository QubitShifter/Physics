using System;
using WeatherStation.Infrastructure.DataAccess;
using WeatherStation.Core.Interfaces;

namespace WeatherStationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeatherRepository weatherRepo = new MockWeatherRepository();
            var measurements = weatherRepo.GetAllMeasurements();

            foreach (var measurement in measurements)
            {
                Console.WriteLine($"Weather Station Data:");
                Console.WriteLine($"Ambient Temp:      {measurement.AmbientTemperature} °C");
                Console.WriteLine($"Ground Temp:       {measurement.GroundTemperature} °C");
                Console.WriteLine($"Air Quality PM2.5: {measurement.AirQualityPm25} µg/m³");
                Console.WriteLine($"Air Quality PM10:  {measurement.AirQualityPm10} µg/m³");
                Console.WriteLine($"AQI:               {measurement.AirQualityIndex}");
                Console.WriteLine($"Air Pressure:      {measurement.AirPressure} hPa");
                Console.WriteLine($"Humidity:          {measurement.Humidity} %");
                Console.WriteLine($"Wind Direction:    {measurement.WindDirection} °");
                Console.WriteLine($"Wind Speed:        {measurement.WindSpeed} km/h");
                Console.WriteLine($"Wind Gust:         {measurement.WindGustSpeed} km/h");
                Console.WriteLine($"Rainfall:          {measurement.Rainfall} mm");
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}