using System;
using System.Collections.Generic;
using WeatherStationApp.Core.Abstract;
using WeatherStationApp.Infrastructure.Sensors;

namespace WeatherStationApp.Infrastructure.Services
{
    public class SensorTestRunner
    {
        public void Run()
        {
            List<SensorBase> sensors = new List<SensorBase>
            {
                new Bme280Reader(),
                new WindSpeedSensor()
            };

            Console.WriteLine("Calibrating and reading sensors:");
            foreach (var sensor in sensors)
            {
                sensor.Calibrate();
                Console.WriteLine($"{sensor.Type}: {sensor.ReadValue()}");
            }
        }
    }
}
