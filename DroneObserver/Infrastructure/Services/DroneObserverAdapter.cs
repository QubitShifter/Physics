using DroneObserver.Core.Interfaces;

public class DroneObserverAdapter
{
    private readonly IWeatherProvider _weather;

    public DroneObserverAdapter(IWeatherProvider weatherProvider)
    {
        _weather = weatherProvider;
    }

    public void CaptureCropsData()
    {
        Console.WriteLine("🚁 Drone scanning crops...");
        Console.WriteLine($"Temp: {_weather.GetTemperature()} °C");
        Console.WriteLine($"Humidity: {_weather.GetHumidity()} %");
        Console.WriteLine($"Pressure: {_weather.GetPressure()} hPa");
        Console.WriteLine("Capturing high-res photos of crops...");
    }
}