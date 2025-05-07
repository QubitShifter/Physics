using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationApp.Core.Entities;

namespace WeatherStationApp.Core.Interfaces
{
    public interface IObserver
    {
        void update(WeatherMeasurement measurement);
    }
}
