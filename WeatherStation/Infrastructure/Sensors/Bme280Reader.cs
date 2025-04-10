using System;

using WeatherStationApp.Core.Abstract;

namespace WeatherStationApp.Infrastructure.Sensors
{
    public class Bme280Reader : SensorBase
    {
        public override string Type => "BME280";

        public override double ReadValue()
        {
            return 23.5; // Mocked ambient temp
        }
    }
}

