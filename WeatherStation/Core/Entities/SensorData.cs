using System;

public class SensorData
{
    public double Humidity { get; set; }
    public double Pressure { get; set; }
    public double Temperature { get; set; }

    public override string ToString()
    {
        return $"Humidity: {Humidity:F2}% | Pressure: {Pressure:F2} hPa | Temp: {Temperature:F2}°C";
    }
}

