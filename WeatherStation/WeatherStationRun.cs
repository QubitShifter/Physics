using WeatherStationApp.Core.Abstract;
using WeatherStationApp.Infrastructure.Sensors;
using WeatherStationApp.Core.Interfaces;
using WeatherStationApp.Infrastructure.Repositories;
using System.Collections.Generic;
using WeatherStationApp.Infrastructure.Observers;
using WeatherStationApp.Infrastructure.Services;

namespace WeatherStationApp
{
    class WeatherStationRun
    {
        static void Main(string[] args)
        {
            IWeatherRepository weatherRepo = new MockWeatherRepository();
            var measurements = weatherRepo.GetAllMeasurements();

            foreach (var measurement in measurements)
            {
                Console.WriteLine("Weather Station Data:");
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

            List<SensorBase> sensors = new List<SensorBase>
            {
                new Bme280Reader(),
                new WindSpeedSensor(),
                new TemperatureSensor()
            };

            foreach (var sensor in sensors)
            {
                sensor.Calibrate();
                Console.WriteLine($"{sensor.Type} reading: {sensor.ReadValue()}");
            }

            var weatherStation = new WeatherStation();
            var consoleDisplay = new ConsoleDisplay();
            var emailNotifier = new EmailNotifier("user@example.com");

            weatherStation.WeatherChanged += consoleDisplay.OnWeatherChanged;
            emailNotifier.Subscribe(weatherStation);

            weatherStation.SimulateWeatherChange();

            var station = new WeatherStation();
            var display = new ConsoleDisplay();

            // Subscribe to the event
            station.WeatherUpdated += display.OnWeatherUpdated;

            var repo = new MockWeatherRepository();

            foreach (var measurement in repo.GetAllMeasurements())
            {
                station.SetMeasurement(measurement);
            }
        }
    }
}
