using System;

namespace WeatherStationApp.Core.Entities
{
    public class WeatherMeasurement
    {
        public double AmbientTemperature { get; set; }
        public double GroundTemperature { get; set; }
        public double AirQualityPm25 { get; set; }
        public double AirQualityPm10 { get; set; }
        public int AirQualityIndex { get; set; }
        public double AirPressure { get; set; }
        public double Humidity { get; set; }
        public double WindDirection { get; set; }
        public double WindSpeed { get; set; }
        public double WindGustSpeed { get; set; }
        public double Rainfall { get; set; }
    }
}

