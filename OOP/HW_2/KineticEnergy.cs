using System;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Channels;

namespace HW_2
{
    public class KineticEnergy
    {
        private double mass;
        private double velocity;

        public double Mass { get { return mass; } set { mass = value; } }
        public double Velocity { get { return velocity; } set { velocity = value; } }

        public KineticEnergy()
        {
        }

        public KineticEnergy(double mass, double velocity): this()
        {
            this.Mass = mass;
            this.Velocity = velocity;
        }

        public double CalculateKineticEnergy()
        {
            return 0.5 * mass * velocity * velocity; // KE = 1/2 * m * v^2
        }
    }
}
