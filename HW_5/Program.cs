using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    class Program
    {


        static void Main()
        {
            Console.WriteLine("You can choose a science lab...but Carefull what you wish!");
            Console.WriteLine("Your choise:");
            Console.WriteLine("\n1. Physics\n2. Math\n3. Biology \n4. Chemistry");
            Console.Write("\nLet me know: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Physics PhysicsLab = new("Physics", "Natural Science", "Bachelor's", "Physics", 4, "Bachelor's");
                    PhysicsLab.DisplayInfo();
                    PhysicsLab.DoPhysicsProblems();
                    break;

                case "2":
                    Mathematics MathLab = new("Mathematics", "Formal Science", "sciences studying numbers, complex numbers, and shapes", "Pure Math", 4, "Bachelor's");
                    MathLab.TheoreticalInformation();
                    MathLab.DisplayInfo();
                    MathLab.DoMathProblems();
                    break;

                case "3":
                    Biology BiologyLab = new("Biology", "Natural Science", "Nature sciences studying living organisms", "Life Sciences", 4, "Bachelor's");
                    BiologyLab.TheoreticalInformation();
                    BiologyLab.DisplayInfo();
                    BiologyLab.DoBiologyProblems();
                    break;

                case "4":
                    Chemistry ChemistryLab = new("Chemistry", "Natural Science", "Nature sciences", "Physical Sciences", 4, "Bachelor's");
                    ChemistryLab.TheoreticalInformation();
                    ChemistryLab.DisplayInfo();
                    ChemistryLab.DoChemistryProblems();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid subject.");
                    break;
            }

            Research research = new Research($"This is {choice} PhD researh.", "CopyRight protected");
            research.DisplayResearch();

            Console.WriteLine("\nYou have reached singularity. Everythong is zeroed out.");
            Console.WriteLine("\nSo long, and thanks for the fish.");
            Console.ReadLine();
        }
    } 
}

