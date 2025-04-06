using System;

using WeatherStationApp.Core.Interfaces;

namespace WeatherStationApp.Core.Abstract
{
    public abstract class SensorBase : ISensorReader
    {
        public abstract string Type { get; }

        public abstract double ReadValue();

        public virtual void Calibrate()
        {
            Console.WriteLine($"{Type} calibration complete.");
        }
    }
}

