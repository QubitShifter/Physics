using WeatherStationApp.Core.Abstract;

namespace WeatherStationApp.Infrastructure.Sensors
{
    public class TemperatureSensor : AdvancedSensor
    {
        public override string Type => "Smart Temperature Sensor";

        public override double Sensitivity { get; set; } = 0.85;

        public override double ReadValue()
        {
           return 23.7 + (0.5 * Sensitivity);
        }
    }
}
