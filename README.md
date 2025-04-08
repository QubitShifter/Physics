#   This is a mockup of Weatherstation 
##  It has hardcoded data to mockup and simulate reading from databse where measured values are inserted
### Actual files structure is shown bellow  

WeatherStationApp/
│
├── Core/
│   ├── Abstract/
│   │   ├── SensorBase.cs
│   │   ├── WindSensorBase.cs
│   │   └── AdvancedSensor.cs     
│   ├── Interfaces/
│   │   ├── IWeatherRepository.cs
│   │   ├── ISensorReader.cs
│   │   ├── IWindProcessor.cs
│   │   └── IAverageCalculator.cs
│   ├── Entities/
│   │   └── WeatherMeasurement.cs
│
├── Infrastructure/
│   ├── Repositories/
│   │   └── MockWeatherRepository.cs
│   ├── Sensors/
│   │   ├── Bme280Reader.cs
│   │   ├── WindSpeedSensor.cs
│   │   ├── WindDirectionSensor.cs
│   │   └── SmartTemperatureSensor.cs 
│   ├── Helpers/
│   │   ├── DirectionAverager.cs
│   │   └── VoltageToAngleMapper.cs
│── WeatherStationRun.cs
