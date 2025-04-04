using System;
using System.Device.I2c;
using Iot.Device.Bmxx80;
using UnitsNet;

public class Bme280Reader
{
    private readonly Bme280 _bme280;

    public Bme280Reader(int i2cBus = 1, int address = 0x76)
    {
        var settings = new I2cConnectionSettings(i2cBus, address);
        var device = I2cDevice.Create(settings);
        _bme280 = new Bme280(device);

        // Optional: configure oversampling here if needed
        _bme280.TemperatureSampling = Sampling.LowPower;
        _bme280.PressureSampling = Sampling.LowPower;
        _bme280.HumiditySampling = Sampling.LowPower;
    }

    public SensorData ReadAll()
    {
        _bme280.Read(); // Update internal measurement

        return new SensorData
        {
            Humidity = _bme280.Humidity?.Percent ?? 0,
            Pressure = _bme280.Pressure?.Hectopascal ?? 0,
            Temperature = _bme280.Temperature?.DegreesCelsius ?? 0
        };
    }
}
