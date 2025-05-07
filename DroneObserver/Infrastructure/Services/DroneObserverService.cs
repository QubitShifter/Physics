using DroneObserver.Core.Interfaces;

public class DroneObserverService
{
    private readonly IWeatherProvider _weatherProvider;

    public DroneObserverService(IWeatherProvider weatherProvider)
    {
        _weatherProvider = weatherProvider;
    }

    public void DisplayWeatherData()
    {
        Console.WriteLine("Drone Observing Weather:");
        Console.WriteLine($"Temperature: {_weatherProvider.GetTemperature()} °C");
        Console.WriteLine($"Humidity: {_weatherProvider.GetHumidity()} %");
        Console.WriteLine($"Pressure: {_weatherProvider.GetPressure()} hPa");
    }
}