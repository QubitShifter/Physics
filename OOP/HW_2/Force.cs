using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    public class Force
    {
        private double mass;
        private double acceleration;

        public double Mass { get { return mass; } set { mass = value; } }
        public double Acceleration { get { return acceleration; } set { acceleration = value; } }

        public Force()
        {            
        }

        public Force(double mass, double acceleration): this()
        {
            this.Mass = mass;
            this.Acceleration = acceleration;
        }

        public double CalculateForce()
        {
            return mass * acceleration;          // f = ma
        }
    }
}
