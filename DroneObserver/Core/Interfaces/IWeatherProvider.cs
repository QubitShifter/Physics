using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneObserver.Core.Interfaces
{
    public interface IWeatherProvider
    {
        double GetTemperature();
        double GetHumidity();
        double GetPressure();
    }
}
