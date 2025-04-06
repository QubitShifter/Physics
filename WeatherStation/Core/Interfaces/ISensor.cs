using System;


public interface ISensor
{
    string SensorType { get; }
    double ReadValue();
}

