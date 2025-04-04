using System;


public class WindSensor : IWindSensor
{
    public double GetWindSpeed()
    {
        // Real GPIO logic here
        return 12.5;
    }

    public double GetWindDirection()
    {
        // Read analog voltage, map to angle
        return 157.5;
    }
}

