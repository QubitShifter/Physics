using System;

public abstract class BaseSensor : ISensor
{
    public virtual string SensorType => "Generic Sensor";
    public abstract double ReadValue();

    public string Status => "OK"; 
    public abstract string Unit { get; } 
}
