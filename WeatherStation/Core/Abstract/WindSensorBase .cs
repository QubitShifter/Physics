using System;
using System.Collections.Generic;

namespace WeatherStationApp.Core.Abstract
{
    public abstract class WindSensorBase : SensorBase
    {
        public abstract double GustSpeed { get; }

        public override void Calibrate()
        {
            Console.WriteLine($"{Type} wind sensor calibration complete.");
        }
    }
}

