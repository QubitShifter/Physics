using System;

using System;
using System.Collections.Generic;

public class DirectionAverager
{
    public double GetAverage(List<double> angles)
    {
        if (angles.Count == 0) return 0.0;

        double sinSum = 0.0;
        double cosSum = 0.0;

        foreach (var angle in angles)
        {
            double rad = Math.PI * angle / 180.0;
            sinSum += Math.Sin(rad);
            cosSum += Math.Cos(rad);
        }

        double s = sinSum / angles.Count;
        double c = cosSum / angles.Count;
        double arc = Math.Atan2(s, c) * (180.0 / Math.PI);

        double avg = arc < 0 ? arc + 360 : arc;
        return avg == 360 ? 0.0 : avg;
    }
}

