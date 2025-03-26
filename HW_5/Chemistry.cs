using System;

namespace HW_5
{
    public class Chemistry : ScienceLab
    {
        public int Semester { get; set; }
        public string AcademicDegree { get; set; }

        public Chemistry(string scienceSubBranch, string mainScienceBranch, string nameOfScience, string subjectOf, int semester, string academicDegree)
            : base(mainScienceBranch, scienceSubBranch, nameOfScience, subjectOf)
        {
            Semester = semester;
            AcademicDegree = academicDegree;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n{ScienceSubBranch} is a branch of {MainScienceBranch}.");
            Console.WriteLine($"{ScienceSubBranch} has different subjects like BioChemistry, Nuclear Vhemistry, Organic Chemistry, Inorganic Chemistry adn so on..");
            Console.WriteLine($"You can get {AcademicDegree} degree and it takes {Semester} semesters.");
            Console.WriteLine($"You can get a Master's degree and it takes {Semester + 2} semesters to complete.");
            Console.WriteLine($"Or even you can get a PhD if you suffer even more.");

            Console.WriteLine("\nWould you like to see an interesting facts and example? (y/n)");

            while (true)
            {
                string choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "y")
                {
                    DoChemistryProblems();
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

        public void DoChemistryProblems()
        {

            Console.WriteLine("\nElectrons change their energy levels. Molecules change their bonds. Elements combine and change into compounds.");
            Console.WriteLine("It is all about reactions! Let's consider combustion:");
            Console.WriteLine("\nCH_{4} + 2O_{2} ---> CO_{2} + 2H_{2}O + Heat");
            Console.WriteLine("\nThis reaction powers cars!");
        }
    }
}
