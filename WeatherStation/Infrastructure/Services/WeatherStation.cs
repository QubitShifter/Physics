using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationApp.Core.Entities;

namespace WeatherStationApp.Infrastructure.Services
{
    public class WeatherStation
    {
        // Delegate type for event handler
        public delegate void WeatherUpdatedHandler(WeatherMeasurement measurement);

        // Event based on the delegate
        public event WeatherUpdatedHandler? WeatherUpdated;

        private WeatherMeasurement _latestMeasurement;

        public void SetMeasurement(WeatherMeasurement measurement)
        {
            _latestMeasurement = measurement;

            // Raise the event - notify all subscribers
            WeatherUpdated?.Invoke(_latestMeasurement);
        }

        public event EventHandler<WeatherMeasurement> WeatherChanged;

        // Method to trigger (raise) the event
        protected virtual void OnWeatherChanged(WeatherMeasurement measurement)
        {
            WeatherChanged?.Invoke(this, measurement);
        }

        public void NewMeasurementArrived(WeatherMeasurement measurement)
        {
            // Process the new measurement...

            // Raise the event
            OnWeatherChanged(measurement);
        }

        public void SimulateWeatherChange()
        {
            // Simulate generating a new measurement
            var measurement = new WeatherMeasurement
            {
                AmbientTemperature = new Random().Next(15, 35),
                Humidity = new Random().Next(30, 90),
                WindSpeed = new Random().Next(5, 20)
                // You can add other properties if needed
            };

            // Raise the event
            OnWeatherChanged(measurement);
        }
    }
}
