﻿namespace HW_5
{
    public class Mathematics : ScienceLab
    {
        public int Semester { get; set; }
        public string AcademicDegree { get; set; }

        public Mathematics(string scienceSubBranch, string mainScienceBranch, string nameOfScience, string subjectOf, int semester, string academicDegree, string research)
            : base(mainScienceBranch, scienceSubBranch, nameOfScience, subjectOf, research)
        {
            Semester = semester;
            AcademicDegree = academicDegree;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n{ScienceSubBranch} is a branch of {MainScienceBranch}.");
            Console.WriteLine($"{ScienceSubBranch} has different subjects like Linear Algebra, Differential Geometry, Complex Numbers, Number Theory, adn so on..");
            Console.WriteLine($"You can get {AcademicDegree} degree and it takes {Semester} semesters.");
            Console.WriteLine($"You can get Masters degree and it takes {Semester} + 2 semesters to complete.");
            Console.WriteLine($"Or even You can get a PhD if you suffer even more.");

            int numOfEquations = 10;
            int coffeeCups = numOfEquations > 8 ? 5 : 2;
            int panicLevel = numOfEquations > 8 ? 9 : 3;
            int confidence = numOfEquations > 8 ? 2 : 8;

            float difficulty = LevelOfDificulty(numOfEquations, coffeeCups, panicLevel, confidence);

            Console.WriteLine($"\n------------------------------------------------------------------------");
            Console.WriteLine($"   stresfull warning............. ");
            Console.WriteLine($"   tons of equations -> hance gallons of coffee");
            Console.WriteLine($"   panic level raises up {panicLevel}/10");
            Console.WriteLine($"   and of course your confidence drops to {confidence}/10");
            Console.WriteLine($"\n----------------------------------------------------------------------- ");
            Console.WriteLine("\nWould you like to see an interesting facts and example? (y/n)");

            while (true)
            {
                string choice = Console.ReadLine().Trim().ToLower();

                if (choice == "y")
                {
                    DoMathProblems();
                    break;
                }
                else if (choice == "n")
                {
                    Console.WriteLine("Bye!");
                    Environment.Exit(0);
                }
            }
        }

        private void DoMathProblems()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("\nLet's calculate a quadratic equation..");
            
            Console.Write("Enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());
                       
            double discriminant = b * b - 4 * a * c;
                       
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"We have real roots: {root1} and {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"The root is real and the same: {root}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"We have complex roots: {realPart} + {imaginaryPart}i and {realPart} - {imaginaryPart}i");
            }

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("\nYou will also learn about most beautiful math equation -> The Euler's identity..\nBut it is hard to print it here in readable form");
        }
    }
}
