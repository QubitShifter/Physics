using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    public class NewtonMain
    {
        public static void Main()
        {          
            Console.WriteLine("Calculated force: N");
            Console.WriteLine("Calculated Kinetic Energy: J");
            Console.WriteLine("Calculated Potential Energy: J");

            Force force = new Force(10, 5);  // m=10 kg, a=5 m/s^2
            KineticEnergy k_energy = new KineticEnergy(10, 15); // m=10 kg, v=15 m/s
            PotentialEnergy p_energy = new PotentialEnergy(70, Simulator.GravitationalConstant, 3); // PE =  m * g * h
            Simulator simulator = new Simulator(force, k_energy, p_energy);
            simulator.RunSimulation();
        }
    }
}
