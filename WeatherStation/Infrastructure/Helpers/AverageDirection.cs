using System;
using System.Collections.Generic;
using WeatherStationApp.Core.Interfaces;

namespace WeatherStationApp.Infrastructure.Helpers
{
    public class AverageDirection : ICalculateAverage
    {
        public double CalculateAverage(List<double> angles)
        {
            double sinSum = 0.0, cosSum = 0.0;

            foreach (var angle in angles)
            {
                double rad = Math.PI * angle / 180.0;
                sinSum += Math.Sin(rad);
                cosSum += Math.Cos(rad);
            }

            double avgRad = Math.Atan2(sinSum, cosSum);
            double avgDeg = avgRad * (180.0 / Math.PI);

            return (avgDeg + 360) % 360;
        }
    }
}
