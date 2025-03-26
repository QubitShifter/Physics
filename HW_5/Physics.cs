using System;

namespace HW_5
{
    public class Physics : ScienceLab
    {
        private const double speedOfLight = 299792458;
        private const double earthCircumference = 40075000;
        private const double sunToEarthDistance = 149597870700;
        public int Semester { get; set; }
        public string AcademicDegree { get; set; }

        public Physics(string scienceSubBranch, string mainScienceBranch,  string nameOfScience, string subjectOf, int semester, string academicDegree)
            : base(mainScienceBranch, scienceSubBranch, nameOfScience, subjectOf)

        {
            Semester = semester;
            AcademicDegree = academicDegree;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n{ScienceSubBranch} is a branch of {MainScienceBranch}.");
            Console.WriteLine($"{ScienceSubBranch} has different subjects like Classical Mechanics, Quantum Mechanics, Thermodynamics, Electrodynamics adn so on..");
            Console.WriteLine($"You can get {AcademicDegree} degree and it takes {Semester} semesters.");
            Console.WriteLine($"You can get a Master's degree and it takes {Semester + 2} semesters to complete.");
            Console.WriteLine($"Or even you can get a PhD if you suffer even more.");

            int numOfEquations = 10; 
            int coffeeCups = numOfEquations > 8 ? 5 : 2; 
            int panicLevel = numOfEquations > 8 ? 9 : 3; 
            int confidence = numOfEquations > 8 ? 2 : 8; 

            float difficulty = LevelOfDificulty(numOfEquations, coffeeCups, panicLevel, confidence);

            Console.WriteLine($"\n----------------------- ");
            Console.WriteLine($"   stresfull warning:) ");
            Console.WriteLine($"   tons of equations -> more coffee (at least {coffeeCups} cups per hour)");
            Console.WriteLine($"   panic level raises up {panicLevel}/10");
            Console.WriteLine($"   and of course your confidence drops to {confidence}/10");
            
            Console.WriteLine("\nWould you like to see an interesting facts and example? (y/n)");

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
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }
            }
        }

        public  void DoPhysicsProblems()
        {
            Console.WriteLine("\nSpeed of Light is denoted as constant 'C':");

            Console.WriteLine($"\n1. Speed of light is the universal constant measured to be {speedOfLight} meters per second.");
            double metersToKilometers = speedOfLight * 3.6;
            Console.WriteLine($"Which is {metersToKilometers:F2} kilometers per hour.");
            Console.WriteLine($"Or 1.08 times ten to the power of nine kilometers per hour.");
            
            double timesAroundEarth = (speedOfLight * 60) / earthCircumference;
            Console.WriteLine($"\n2. In just one minute, light can travel around the Earth approximately {timesAroundEarth:F2} times.");
            
            double timeFromSunToEarth = sunToEarthDistance / speedOfLight;
            Console.WriteLine($"\n3. It takes {timeFromSunToEarth:F2} seconds for light to reach the Earth from the sun.");
            double secondsToMinutes = timeFromSunToEarth / 60;
            Console.WriteLine($"Which is just about {secondsToMinutes:F2} minutes.");
        }
    }
}
