using System;

public class WindDirectionSensor : AdvancedSensor, IDataLogger, ICalculation
{
    public override double ReadValue() => 90;
    public override string Unit => "degrees";
    public override void Reset() => Console.WriteLine("WindDirectionSensor reset");
    public void LogData(double data) => Console.WriteLine($"Direction: {data}");
    public double Calculate() => ReadValue();
}