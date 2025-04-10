using System;

namespace WeatherStationApp.Core.Interfaces
{
    public interface ISensorReader
    {
        string Type { get; }
        double ReadValue();
        void Calibrate();
    }
}

