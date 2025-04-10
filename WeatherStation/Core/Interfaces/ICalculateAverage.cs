using System;
using System.Collections.Generic;

namespace WeatherStationApp.Core.Interfaces
{
    public interface ICalculateAverage
    {
        double CalculateAverage(List<double> angles);
    }
}
