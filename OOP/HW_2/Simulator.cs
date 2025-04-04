using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    public class Simulator
    {
        private Force Force;
        private KineticEnergy KEnergy;
        private PotentialEnergy PEnergy;

        public static double GravitationalConstant = 9.8;
        
        public Simulator(Force force, KineticEnergy k_energy, PotentialEnergy p_energy)
        {
            this.Force = force;
            this.KEnergy = k_energy;
            this.PEnergy = p_energy;
        }

        public void RunSimulation()
        {
            Logger.Log("Physics Simulation Started...");

            double forceValue = Force.CalculateForce();
            double KineticEnergyValue = KEnergy.CalculateKineticEnergy();
            double PotentialEnergyValue = PEnergy.CalculatePotentialEnergy();

            Console.WriteLine($"Simulated Force: {forceValue} N");
            Console.WriteLine($"Simulated Kinetic Energy: {KineticEnergyValue} J");
            Console.WriteLine($"Simulated Potential Energy: {PotentialEnergyValue} J");
            DisplayPhysicsInfo();

            Logger.Log("Simulation Complete.");
        }

        private static void DisplayPhysicsInfo()
        {
            Console.WriteLine($"Gravity on Earth: {GravitationalConstant} m/s²");
        }
    }

    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
