using System;

namespace WeatherStationApp.Core.Interfaces
{
    public interface IWindProcessor
    {
        double CalculateWindSpeed(int rotationCount, double intervalSeconds);
    }
}

