using System;
using System.Collections.Generic;
using WeatherStation.Core.Entities;
using WeatherStation.Core.Interfaces;

namespace WeatherStation.Infrastructure.DataAccess
{
    public class MockWeatherRepository : IWeatherRepository
    {
        public IEnumerable<WeatherMeasurement> GetAllMeasurements()
        {
            return new List<WeatherMeasurement>
            {
                new WeatherMeasurement
                {
                    AmbientTemperature = 22.5,
                    GroundTemperature = 18.3,
                    AirQualityPm25 = 10.2,
                    AirQualityPm10 = 15.5,
                    AirQualityIndex = 42,
                    AirPressure = 1012.3,
                    Humidity = 55.6,
                    WindDirection = 270,
                    WindSpeed = 12.4,
                    WindGustSpeed = 18.9,
                    Rainfall = 0.0
                },
                new WeatherMeasurement
                {
                    AmbientTemperature = 21.0,
                    GroundTemperature = 19.0,
                    AirQualityPm25 = 11.0,
                    AirQualityPm10 = 16.0,
                    AirQualityIndex = 45,
                    AirPressure = 1013.1,
                    Humidity = 60.1,
                    WindDirection = 290,
                    WindSpeed = 11.2,
                    WindGustSpeed = 16.5,
                    Rainfall = 0.2
                }
            };
        }
    }
}
