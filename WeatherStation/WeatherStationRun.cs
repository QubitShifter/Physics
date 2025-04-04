using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        var services = new ServiceCollection();

        // Core + Infrastructure bindings
        services.AddSingleton<IWindSensor, WindSensor>();
        services.AddSingleton<WindMeasurementService>();

        var provider = services.BuildServiceProvider();
        var windService = provider.GetRequiredService<WindMeasurementService>();

        windService.PrintCurrentWind();
    }
}
