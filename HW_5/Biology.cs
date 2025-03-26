using System;

namespace HW_5
{
    public class Biology : ScienceLab
    {
        public int Semester { get; set; }
        public string AcademicDegree { get; set; }

        public Biology(string scienceSubBranch, string mainScienceBranch, string nameOfScience, string subjectOf, int semester, string academicDegree)
            : base(mainScienceBranch, scienceSubBranch, nameOfScience, subjectOf)
        {
            Semester = semester;
            AcademicDegree = academicDegree;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n{ScienceSubBranch} is a branch of {MainScienceBranch}.");
            Console.WriteLine($"{ScienceSubBranch} has different subjects like MicroBiology, MolecularBiology adn so on..");
            Console.WriteLine($"You can get {AcademicDegree} degree and it takes {Semester} semesters.");
            Console.WriteLine($"You can get a Master's degree and it takes {Semester + 2} semesters to complete.");
            Console.WriteLine($"Or even you can get a PhD if you suffer even more.");

            Console.WriteLine("\nWould you like to see an interesting facts and example? (y/n)");

            while (true)
            {
                string choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "y")
                {
                    DoBiologyProblems();
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

        public void DoBiologyProblems()
        {
            Console.WriteLine("\nIn Biology we are dealing with living organisms.");
            Console.WriteLine("We try to understand our DNA, the human genome.");
            Console.WriteLine("\nDNA is our genetic material and carries all the instructions from generation to generation.");
            Console.WriteLine($"DNA is made up of “letters”, represented as A, T, G and C. These letters are short for the chemical compounds they constitute.");
            Console.WriteLine("There are 3 billion DNA letters contained in every cell!");
            Console.WriteLine("Can you imagine!");
        }
    }
}
