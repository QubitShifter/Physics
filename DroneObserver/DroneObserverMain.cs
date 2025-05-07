var weatherData = new WeatherMeasurement
{
    AmbientTemperature = 26.5,
    Humidity = 65.2,
    AirPressure = 1013.2
};

var adapter = new WeatherStationAdapter(weatherData);
var droneService = new DroneObserverService(adapter);

droneService.DisplayWeatherData();