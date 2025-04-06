using System;

public class Bme280Reader : AdvancedSensor, IDataLogger, ICalculation
{
    public override double ReadValue() => 22.5; // temp as example
    public override string Unit => "°C";
    public override void Reset() => Console.WriteLine("BME280 Reset");
    public void LogData(double data) => Console.WriteLine($"Temp: {data}");
    public double Calculate() => ReadValue();
}
