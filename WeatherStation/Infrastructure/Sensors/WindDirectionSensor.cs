using System;
using WeatherStationApp.Core.Abstract;

namespace WeatherStationApp.Infrastructure.Sensors
{
    public class WindDirectionSensor : SensorBase
    {
        public override string Type => "Wind Direction";

        public override double ReadValue()
        {
            return 135.0;
        }
    }
}
