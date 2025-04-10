using System;
using System.Collections.Generic;
using WeatherStationApp.Core.Entities;

namespace WeatherStationApp.Core.Interfaces
{
    public interface IWeatherRepository
    {
        IEnumerable<WeatherMeasurement> GetAllMeasurements();
    }
}


