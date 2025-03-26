using System;

namespace HW_5
{
    public class Physics : Science
    {
        private const double speedOfLight = 299792458;
        private const double earthCircumference = 40075000;
        private const double sunToEarthDistance = 149597870700;
        public string Branch { get; set; }

        public Physics(string name, string branch, string field, int semesters)
            : base(name, field, "Bachelor", semesters)
        {
            Branch = branch;
        }

        public  void DisplayInfo()
        {
            Console.WriteLine($"                                                                       ");
            Console.WriteLine($"{Name} is part of the {Branch} branch in {FieldOfStudy}.");
            Console.WriteLine($"You can get {AcademicDegree} degree and it takes {Semesters} semesters.");

            Console.WriteLine($"You can get Masters degree and it takes {Semesters} + 2 semesters to complete.");
            Console.WriteLine($"Or even You can get a PhD if you suffer even more.");

            int numOfEquations = 10; 
            int coffeeCups = numOfEquations > 8 ? 5 : 2; 
            int panicLevel = numOfEquations > 8 ? 9 : 3; 
            int confidence = numOfEquations > 8 ? 2 : 8; 

            float difficulty = LevelOfDificulty(numOfEquations, coffeeCups, panicLevel, confidence);

            Console.WriteLine($"                          ");
            Console.WriteLine($"  ----------------------- ");
            Console.WriteLine($"   stresfull warning:) ");
            Console.WriteLine($"   tons of equations -> more coffee (at least {coffeeCups} cups per hour)");
            Console.WriteLine($"   panic level raises up {panicLevel}/10");
            Console.WriteLine($"   and of course your confidence drops to {confidence}/10");
            
            Console.WriteLine($"  ----------------------- ");
            Console.WriteLine($"                          ");
            Console.WriteLine("Would you like to see an interesting facts and example? (y/n)");

            while (true)
            {
                string choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "y")
                {
                    DoPhysicsProblems();
                    break;
                }
                else if (choice == "n")
                {
                    Console.WriteLine("Bye!");
                    Environment.Exit(0);
                }
            }
        }

        public static void DoPhysicsProblems()
        {
            Console.WriteLine($"                                         ");
            Console.WriteLine("Speed of Light is denoted as constant 'C':");

            Console.WriteLine($"1. The speed of light is the universal constant measured to be {speedOfLight} meters per second.");
            double metersToKilometers = speedOfLight * 3.6;
            Console.WriteLine($"   Which is {metersToKilometers:F2} kilometers per hour.");
            Console.WriteLine($"   Or 1.08 times ten to the power of nine kilometers per hour.");
            Console.WriteLine($"                                                              ");

            double timesAroundEarth = (speedOfLight * 60) / earthCircumference;
            Console.WriteLine($"2. In just one minute, light can travel around the Earth approximately {timesAroundEarth:F2} times.");
            Console.WriteLine($"                                                              ");

            double timeFromSunToEarth = sunToEarthDistance / speedOfLight;
            Console.WriteLine($"3. It takes {timeFromSunToEarth:F2} seconds for light to reach the Earth from the sun.");
            double secondsToMinutes = timeFromSunToEarth / 60;
            Console.WriteLine($"   Which is just about {secondsToMinutes:F2} minutes.");
        }
    }
}
