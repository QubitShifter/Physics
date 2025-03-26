using System;

namespace HW_5
{
    public class Chemistry : Science
    {
        public string Branch { get; set; }

        public Chemistry(string name, string branch, string fieldOfStudy)
            : base(name, fieldOfStudy, "Bachelor of Science", 4)  
        {
            Branch = branch;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"                                                                              ");
            Console.WriteLine($"{Name} is a branch of {FieldOfStudy} that studies matter and its interactions.");
            Console.WriteLine($"It awards a {AcademicDegree} degree and takes {Semesters} semesters.");
            Console.WriteLine($"                          ");
            Console.WriteLine($"  ----------------------- ");
            Console.WriteLine("Would you like to see an example? (y/n)");

            while (true)
            {
                string? choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "y")
                {
                    DoChemistryProblems();
                    break;
                }
                else if (choice == "n")
                {
                    Console.WriteLine("Bye!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 'y' or 'n'.");
                }
            }
        }

        public void DoChemistryProblems()
        {
            Console.WriteLine($"                                                                                                              ");
            Console.WriteLine("Electrons change their energy levels. Molecules change their bonds. Elements combine and change into compounds.");
            Console.WriteLine("It is all about reactions! Let's consider combustion:");
            Console.WriteLine($"                                           ");
            Console.WriteLine("CH_{4} + 2O_{2} ---> CO_{2} + 2H_{2}O + Heat");
            Console.WriteLine($"                         ");
            Console.WriteLine("This reaction powers cars!");
        }
    }
}
