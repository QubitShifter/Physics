using System;

public abstract class AdvancedSensor : BaseSensor
{
    public override string SensorType => "Advanced Sensor";

    public void Calibrate()
    {
        Console.WriteLine("Calibrating...");
    }

    public abstract void Reset();
}

