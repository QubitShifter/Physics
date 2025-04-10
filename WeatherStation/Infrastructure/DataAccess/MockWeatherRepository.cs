using System;
using System.Collections.Generic;
using WeatherStationApp.Core.Entities;
using WeatherStationApp.Core.Interfaces;

namespace WeatherStationApp.Infrastructure.Repositories
{
    public class MockWeatherRepository : IWeatherRepository
    {
        public IEnumerable<WeatherMeasurement> GetAllMeasurements()
        {
            return new List<WeatherMeasurement>
            {
                new WeatherMeasurement
                {
                    AmbientTemperature = 23.4,
                    GroundTemperature = 18.1,
                    AirQualityPm25 = 10.2,
                    AirQualityPm10 = 15.5,
                    AirQualityIndex = 42,
                    AirPressure = 1012.3,
                    Humidity = 57.2,
                    WindDirection = 135.0,
                    WindSpeed = 12.4,
                    WindGustSpeed = 20.1,
                    Rainfall = 5.0
                }
            };
        }
    }
}
