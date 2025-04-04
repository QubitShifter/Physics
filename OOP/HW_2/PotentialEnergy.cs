using System;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Channels;

namespace HW_2
{
    public class PotentialEnergy
    {
        private double mass;
        private double height;
        private double acceleration;

        public double Mass { get { return mass; } set { mass = value; } }
        public double Height { get { return height; } set { height = value; } }

        public double Acceleration { get { return acceleration; } set { acceleration = value; } }

        public PotentialEnergy()
        {
        }

        public PotentialEnergy(double mass, double height, double acceleration) : this()
        {
            this.Mass = mass;
            this.Height = height;
            this.Acceleration = acceleration;
        }

        public double CalculatePotentialEnergy()
        {
            return mass * Simulator.GravitationalConstant * height; // PE =  m * g * h
        }
    }
}
