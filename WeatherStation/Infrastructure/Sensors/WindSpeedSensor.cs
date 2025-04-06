using System;

using WeatherStationApp.Core.Abstract;

namespace WeatherStationApp.Infrastructure.Sensors
{
    public class WindSpeedSensor : WindSensorBase
    {
        public override string Type => "Wind Speed";
        public override double GustSpeed => 25.3;

        public override double ReadValue()
        {
            return 12.4;
        }
    }
}


