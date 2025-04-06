using System;
using System.Collections.Generic;
using WeatherStation.Core.Entities;

namespace WeatherStationApp.Core.Interfaces
{
    public interface IWeatherRepository
    {
        IEnumerable<WeatherMeasurement> GetAllMeasurements();
    }
}

