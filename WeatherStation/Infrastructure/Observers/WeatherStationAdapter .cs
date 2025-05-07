using DroneObserver.Core.Interfaces;
using WeatherStationApp.Core.Entities;

public class WeatherStationAdapter : IWeatherProvider
{
    private readonly WeatherMeasurement _latestMeasurement;

    public WeatherStationAdapter(WeatherMeasurement measurement)
    {
        _latestMeasurement = measurement;
    }

    public double GetTemperature() => _latestMeasurement.AmbientTemperature;
    public double GetHumidity() => _latestMeasurement.Humidity;
    public double GetPressure() => _latestMeasurement.AirPressure;
}