using System;

public class WindDirectionSensor
{
    // Mocked read method for now. Replace with real MCP3008 SPI read.
    public double ReadVoltage()
    {
        // Simulate analog read (0.0 - 3.3V)
        Random rand = new Random();
        return Math.Round(rand.NextDouble() * 3.3, 1);
    }
}

