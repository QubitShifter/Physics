using System;

public class WindSpeedSensor : AdvancedSensor, IDataLogger, ICalculation
{
    public override double ReadValue() => 5.5;
    public override string Unit => "km/h";
    public override void Reset() => Console.WriteLine("WindSpeedSensor reset");
    public void LogData(double data) => Console.WriteLine($"Speed: {data}");
    public double Calculate() => ReadValue() * 1.2;
}

