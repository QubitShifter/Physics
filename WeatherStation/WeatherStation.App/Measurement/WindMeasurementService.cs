using System;

public class WindMeasurementService
{
    private readonly IWindSensor _windSensor;

    public WindMeasurementService(IWindSensor windSensor)
    {
        _windSensor = windSensor;
    }

    public void PrintCurrentWind()
    {
        var speed = _windSensor.GetWindSpeed();
        var dir = _windSensor.GetWindDirection();
        Console.WriteLine($"Wind: {speed} km/h at {dir}°");
    }
}

