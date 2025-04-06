using WeatherStationApp.Core.Interfaces;

namespace WeatherStationApp.Core.Abstract
{
    public abstract class AdvancedSensor : SensorBase
    {
        public abstract double Sensitivity { get; set; }

        public override void Calibrate()
        {
            Console.WriteLine($"[AdvancedSensor] Calibrating {Type} with sensitivity {Sensitivity}");
        }

        public string CalibrationStatus => "Auto-Calibrated";
    }
}
